function name(parameters) {

    var a = +parameters[0];
    var b = +parameters[1];
    var c = +parameters[2];

    if (a > b && a > c) {
        console.log(a);
    }
    else if (b > a && b > c) {
        console.log(b);
    }
    else {
        console.log(c);
    }
}