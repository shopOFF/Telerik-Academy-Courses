function GetMax(nums) {
    var numbers = nums[0].split(' '),  // взимаме стринга с числата сплитваме ги в масив, по празен спейс
        firstNum = +numbers[0],         // и си взимаме една по една стойностите, правим ги на числа от масива и ги бухаме в нови променливи
        secondNum = +numbers[1],
        thirdNum = +numbers[2];

    if (firstNum > secondNum && firstNum > thirdNum) {
        console.log(firstNum);
    }
    else if (secondNum > firstNum && secondNum > thirdNum) {
        console.log(secondNum);
    }
    else {
        console.log(thirdNum);
    }
}
// vtori na4in :
function getLargestNumber(args) {
    var input = args[0].split(' ').map(Number), // взимаме стринга с числата сплитваме ги в масив, по празен спейс
        firstNumber = input[0],                 // и веднага ги мапваме и правим целият масив на числа
        secondNumber = input[1],
        thirdNumber = input[2];

    if (getMax(firstNumber, secondNumber) > thirdNumber) {
        return getMax(firstNumber, secondNumber);
    } else {
        return thirdNumber;
    }

    function getMax(first, second) {
        return first > second ? first : second;
    }
}