function name(parameters) {

    var numA = +parameters[0];
    var numB = +parameters[1];
    var numC = +parameters[2];

    if ((numA === 0) || (numB === 0) || (numC === 0))
        {
            console.log("0");
        }
        else if ((numA > 0) && (numB > 0) && (numC > 0))
        {
            console.log("+");
        }
        else if ((numA < 0) && (numB < 0) && (numC < 0))
        {
            console.log("-");
        }
        else if ((numA > 0 && numB > 0) || (numA > 0 && numC > 0) || (numB > 0 && numC > 0))
        {
            console.log("-");
        }
        else if ((numA < 0 && numB < 0) || (numA < 0 && numC < 0) || (numB < 0 && numC < 0))
        {
            console.log("+");
        }
}