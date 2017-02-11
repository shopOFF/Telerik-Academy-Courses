function LexCompare(parameters) {

    var arr = parameters[0].split('\n');
    var a = String(arr[0]);
    var b = String(arr[1]);

    if (a > b) {
        console.log('>');
    }
    else if (a < b) {
        console.log('<');
    }
    else if (a === b) {
        console.log('=');
    }
}