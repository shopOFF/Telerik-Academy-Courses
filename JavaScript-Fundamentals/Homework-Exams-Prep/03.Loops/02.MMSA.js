function MMSA(parameters) {
    var firtsNum = +parameters[0];
    var secondNum = +parameters[1];
    var thirdNum = +parameters[2];

    var array = [];

    array[0] = firtsNum;
    array[1] = secondNum;
    array[2] = thirdNum;

    var sumTotatl = 0;
    var min = Math.min.apply(Math, array);
    var max = Math.max.apply(Math, array);

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    for (var i = 0; i < array.length; i++) {
        sumTotatl += array[i];
    }
    console.log('sum=' + sumTotatl.toFixed(2));
    console.log('avg=' + (sumTotatl / 3).toFixed(2));
}