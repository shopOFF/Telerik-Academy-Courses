function LargerThanNeighboursIndex(args) {
    var arrayLength = +args[0],
        array = args[1].split(' ').map(Number),
        counter = 0;

    for (var i = 1; i <= arrayLength; i += 1) {
        if (array[i] > array[i - 1] && array[i] > array[i + 1]) {// може да се налижи да проверяваме дали сме на първия или последния елемент, за да не излизаме от масива, но в случая сме ок,защото това е JAvaScript !!!!Ако правим и другите проверки дали сме в масива дава грешка!
            counter += 1;
        }
        if (counter > 0) {
            return i;
        }
    }
    return -1;
}
// vtori na4in 
function largerThanNeightbours(input) {
    var arr = input[0].split('\n'),
    n = +arr[0],
    number = arr[1].split(' ').map(Number),
    count = -1;

    for(var i = 1; i < n - 1; i += 1) {
        if (number[i] > number[i - 1] && number[i] > number[i + 1]) {
            count = i;
            return count;
        }
    }
}