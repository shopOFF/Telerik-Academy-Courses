function name(parameters) {

    var numA = +parameters[0];
    var numB = +parameters[1];
    var numC = +parameters[2];
    var numD = +parameters[3];
    var numE = +parameters[4];

    if (numA > numB && numA > numC && numA > numD && numA > numE) {
        console.log(numA);
    }
    else if (numB > numA && numB > numC && numB > numD && numB > numE) {
        console.log(numB);
    }
    else if (numC > numA && numC > numB && numC > numD && numC > numE) {
        console.log(numC);
    }
    else if (numD > numA && numD > numB && numD > numC && numD > numE) {
        console.log(numD);
    }
    else {
        console.log(numE);
    }
}