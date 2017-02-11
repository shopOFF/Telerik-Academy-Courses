function BinarySearch(parameter) {

    var input = parameter[0].split('\n'),
        n = +input[0],
        numbers = input.slice(1),
        min = numbers[0];

    var xNum = numbers[numbers.length - 1];
    var xIndex=numbers.indexOf(xNum);
    console.log(xIndex);
}
// vtori na4in:
function search(args) {

    var arr = (args + '').split('\n').map(Number),
        n = +arr[0],
        x = +arr[arr.length - 1],
        min = 0,
        max = n - 1,
        mid = 0;

    arr.shift();
    arr.pop();
    while (min <= max) {

        mid = ((min + max) / 2) | 0;

        if (x === +arr[mid]) {
            return mid;
        }
        else if (x < +arr[mid]) {
            max = mid - 1;
        }
        else {
            min = mid + 1;
        }
    }
    console.log('-1');
}