module Main where

import Numeric
import Data.Char
import System.Random (randomRIO)
import System.Directory

data TestNumber = Rnd Integer Integer | Fixed Integer deriving Show

rndLong :: TestNumber
rndLong = Rnd (2 ^ 30) (2 ^ 60)

rndSmallInt :: TestNumber
rndSmallInt = Rnd 0 5000

tests :: [[TestNumber]]
tests = hardcoded ++ randomLong ++ randomBigInt
    where
        hardcoded = [
                        [Fixed 0, Rnd 1 15, Rnd 1 15]
                        , [Fixed 1, Fixed 1, Fixed 1]
                        , [Fixed 15, Fixed 15, Fixed 15]
                    ]
        randomLong = replicate 3 [rndSmallInt, rndSmallInt, rndSmallInt]
        randomBigInt = replicate 4 [rndLong, rndLong, rndLong]

zeroTests :: [[TestNumber]]
zeroTests =  [
                 [Fixed 66, Fixed 40, Fixed 33]
                 , [Fixed 5, Fixed 11, Fixed 18]
                 , [Fixed 10, Fixed 22, Fixed 100]
                 , [Fixed 30, Fixed 40, Fixed 2]
             ]

hexDigitToInt :: Char -> Int
hexDigitToInt d
    | ('0' <= d) && (d <= '9') = Data.Char.ord d - 48
    | ('a' <= d) && (d <= 'z') = Data.Char.ord d - 97 + 10
    | otherwise                 = error "Kaun!"

hexDigitToFLang :: Char -> String
hexDigitToFLang = (!!) digits . hexDigitToInt
    where
        digits = [
                    "ocaml"
                    , "haskell"
                    , "scala"
                    , "f#"
                    , "lisp"
                    , "rust"
                    , "ml"
                    , "clojure"
                    , "erlang"
                    , "standardml"
                    , "racket"
                    , "elm"
                    , "mercury"
                    , "commonlisp"
                    , "scheme"
                    , "curry"
                 ]

showFunctional :: String -> String
showFunctional = foldr ((++) . hexDigitToFLang) ""

genTest :: [TestNumber] -> IO (String, String)
genTest xs = do
    ts <- mapM toHex xs
    return $ gosho ts
    where
        toHex :: TestNumber -> IO (String, Integer)
        toHex (Fixed n) = return (showFunctional $ showHex n "", n)
        toHex (Rnd low high) = do
            rgn <- randomRIO (low, high)
            return (showFunctional $ showHex rgn "", rgn)
        gosho [(a, a1), (b, b1), (c, c1)] = (a ++ ", " ++ b ++ ", " ++ c, show $ a1 * b1* c1)

folder :: String
folder = "./Tests/"

padLeft :: Int -> Char -> String -> String
padLeft len symbol str = replicate (len - length str) symbol ++ str

fileName :: Int -> String -> String -> Bool -> String
fileName n testType folder isZero = folder ++ "test." ++ (if isZero then "000." else "") ++ padLeft 3 '0' (show n) ++ "." ++ testType ++ ".txt"

main = do
    createDirectoryIfMissing False folder
    readyContenst <- mapM genTest tests
    readyZero <- mapM genTest zeroTests
    sequence_ $ writeTests readyContenst False
    sequence_ $ writeTests readyZero True
            where
                writeTests tests isZero = map (\(n, i, o) -> writeFile (fileName n "in" folder isZero) i >> writeFile (fileName n "out" folder isZero) o)
                                          $ zipWith (\(i, o) n -> (n, i, o)) tests [1..]