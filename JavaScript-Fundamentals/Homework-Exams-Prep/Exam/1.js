function solve(params) {
    var array = params[0].split(' ').map(Number),
        sumOfPockets = 0;

    for (var i = 1; i < array.length - 1; i += 1) {

        if (array[i] > array[i - 1] && array[i] > array[i + 1]) {  // finding peaks

            if (array[i + 2] > array[i + 3] && array[i + 2] > array[i + 1]) {
                sumOfPockets += array[i + 1];
            }
        }
    }
    console.log(sumOfPockets);
}
solve([
    "53 20 1 30 30 2 40 3 10 1"
]);