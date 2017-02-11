function name(parameters) {

    var a = +parameters[0];
    var b = +parameters[1];
    var c = +parameters[2];

    if (a === 0) {
        console.log("no real roots");
    }
    else {
        var discriminant = (b * b) - (4 * a * c);
        if (discriminant > 0) {
            var x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
            var x2 = (-b - Math.sqrt(discriminant)) / (2 * a);
            if (x1 < x2) {
                console.log('x1=' + x1.toFixed(2) + '; ' + 'x2=' + x2.toFixed(2));
            }
            else {
                console.log('x1=' + x2.toFixed(2) + '; ' + 'x2=' + x1.toFixed(2));
            }
        }
        else if (discriminant === 0) {
            var x = -b / (2 * a);
            console.log('x1=x2=' + x.toFixed(2));
        }
        else if (discriminant < 0) {
            console.log("no real roots");
        }
    }
}