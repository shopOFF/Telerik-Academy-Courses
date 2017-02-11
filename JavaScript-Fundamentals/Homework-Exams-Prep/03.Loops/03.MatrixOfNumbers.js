function printMatrix(parameters) {

    var input = +parameters[0];
    var output = '';
    for (var row = 1; row <= input; row++) {

        for (var col = 0; col < input; col++) {
            output += row + col + ' ';
        }
        console.log(output);
        output = '';
    }
}