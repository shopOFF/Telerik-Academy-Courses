function numbersFromTo(parameters) {

    var num = +parameters[0];
    var output = '';
    for (var i = 1; i <= num; i++) {
        output += i + ' ';
    }
    console.log(output);
}