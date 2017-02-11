function Solve(params) {
    var arrayLength = +params[0],   // взимаме си първия елемент от масива(дължината му която ни се подава, като първи елемент)
        numbers = params.slice(1).map(Number), // така взимаме след 1-вия елемент в масива(след дължината на масива(горното!)) останналите елементи с (params.slice(1)) и с .map(Number) 
                                                // си ги конвертираме от стрингов масив в масив с числа !!!!!!
        maxSum = -2000000, // Number.MIN_VALUE,-обаче е препоръчително да не ползваме тая константа!!!, затова - в случая от условието си взимаме най-малкото число, защото с  Number.MIN_VALUE  не излиза 1 тест!!!
        currSum = 0;

    for (var i = 0; i < arrayLength; i += 1) {

        currSum += numbers[i];

        if (currSum > maxSum) {
            maxSum = currSum;
        }
        if (currSum < 0) {
            currSum = 0;
        }
    }
    return maxSum;
}
var test = [
    '8',  // това ни е дължината на масива !!!!
    // това са елементите на масива !!!!
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1'
];
console.log(Solve(test));
