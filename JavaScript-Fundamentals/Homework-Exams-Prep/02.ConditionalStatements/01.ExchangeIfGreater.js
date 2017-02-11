function name(parameters) {

    var a = +parameters[0];
    var b = +parameters[1];
    var temp = 0;

    if (a > b) {
        temp = b;
        b = a;
        a = temp;
    }

    console.log(a + ' ' + b);
}