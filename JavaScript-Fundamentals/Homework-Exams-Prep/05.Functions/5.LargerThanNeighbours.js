function LargerThanNeighbours(args) {
    var arrayLength = +args[0],
        array = args[1].split(' ').map(Number),
        counter = 0;

    for (var i = 0; i < arrayLength; i += 1) {
        if (array[i] > array[i - 1] && array[i] > array[i + 1]) {// може да се налижи да проверяваме дали сме на първия или последния елемент, за да не излизаме от масива, но в случая сме ок,защото това е JAvaScript !!!!Ако правим и другите проверки дали сме в масива дава грешка!
            counter += 1;
        }
    }
    return counter;
}
