module Main where

import Numeric
import Data.Char
import System.Random (randomRIO)
import System.Directory

data TestNumber = Rnd Integer Integer | Fixed Integer deriving Show

rndLong :: TestNumber
rndLong = Rnd (2 ^ 25) (2 ^ 40)

rndSmallInt :: TestNumber
rndSmallInt = Rnd 0 5000

tests :: [[TestNumber]]
tests = hardcoded ++ randomLong ++ randomBigInt
    where
        hardcoded = [
                        [Fixed 0, Rnd 1 15, Rnd 1 15, Rnd 1 15]
                        , [Fixed 1, Fixed 1, Fixed 1, Fixed 1]
                        , [Fixed 15, Fixed 15, Fixed 15, Fixed 15]
                    ]
        randomLong = replicate 3 [rndSmallInt, rndSmallInt, rndSmallInt, rndSmallInt]
        randomBigInt = replicate 4 [rndLong, rndLong, rndLong, rndLong]

zeroTests :: [[TestNumber]]
zeroTests =  [
                 [Fixed 33, Fixed 20, Fixed 13, Fixed 2]
                 , [Fixed 5, Fixed 11, Fixed 18, Fixed 15]
                 , [Fixed 10, Fixed 22, Fixed 100, Fixed 4]
                 , [Fixed 30, Fixed 27, Fixed 2, Fixed 101]
             ]

octDigitToProgrammer :: Char -> String
octDigitToProgrammer d = digits !! (Data.Char.ord d - 48)
    where
        digits = [
                    "hristo"    
                    , "tosho"    
                    , "pesho"    
                    , "hristofor"   
                    , "vlad"     
                    , "haralampi"
                    , "zoro"     
                    , "vladimir"
                 ]

showFunctional :: String -> String
showFunctional = foldr ((++) . octDigitToProgrammer) ""

genTest :: [TestNumber] -> IO (String, String)
genTest xs = do
    ts <- mapM toHex xs
    return $ ioTestTuple ts
    where
        toHex :: TestNumber -> IO (String, Integer)
        toHex (Fixed n) = return (showFunctional $ showOct n "", n)
        toHex (Rnd low high) = do
            rgn <- randomRIO (low, high)
            return (showFunctional $ showOct rgn "", rgn)
        ioTestTuple [(a, a1), (b, b1), (c, c1), (d, d1)] = (a ++ ", " ++ b ++ ", " ++ c ++ ", " ++ d, show $ a1 * b1 * c1 * d1)

folder :: String
folder = "./Tests/"

padLeft :: Int -> Char -> String -> String
padLeft len symbol str = replicate (len - length str) symbol ++ str

fileName :: Int -> String -> String -> Bool -> String
fileName n testType folder isZero = folder ++ "test." ++ (if isZero then "000." else "") ++ padLeft 3 '0' (show n) ++ "." ++ testType ++ ".txt"

main = do
    createDirectoryIfMissing False folder
    readyContest <- mapM genTest tests
    readyZero <- mapM genTest zeroTests
    sequence_ $ writeTests readyContest False
    sequence_ $ writeTests readyZero True
        where
            writeTests tests isZero = map (\(n, i, o) -> writeFile (fileName n "in" folder isZero) i >> writeFile (fileName n "out" folder isZero) o)
                                      $ zipWith (\(i, o) n -> (n, i, o)) tests [1..]