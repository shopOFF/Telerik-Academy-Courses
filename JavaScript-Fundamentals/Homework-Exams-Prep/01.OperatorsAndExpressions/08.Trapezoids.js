function name(parameters) {

    var sideA = +parameters[0];
    var sideB = +parameters[1];
    var height = +parameters[2];

    var trapezoidArea = ((sideA + sideB) / 2) * height;

    console.log(trapezoidArea.toFixed(7));  // ili  return trapezoidArea.toFixed(7);
}