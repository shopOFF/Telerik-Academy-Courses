function SelectionSort(parameter) {

    var input = parameter[0].split('\n'),
        n = +input[0],
        numbers = input.slice(1),
        min = numbers[0];

    for (var i = 0; i < n; i += 1) {
        min = numbers[i];
        
        for (var j = i; j < n; j += 1) {

            if (+numbers[j] < min) {
                min = +numbers[j];
                numbers[j] = +numbers[i];
                numbers[i] = min;
            }
        }
    }
    console.log(numbers.join('\n'));
}
// vtori na4in!!!
function SelectionSort(parameter) {

    var input = parameter[0].split('\n'),
        n = +input[0],
        numbers = input.slice(1),
        min = numbers[0];

    
    numbers.sort(function(a, b){return a-b;});
    console.log(numbers.join('\n'));
}