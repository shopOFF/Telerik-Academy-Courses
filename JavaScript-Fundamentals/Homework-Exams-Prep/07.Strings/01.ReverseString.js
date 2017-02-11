function solve(params) {
    var reversedString = '',
        text = params[0],
        length = params[0].length;
    for (var i = length - 1; i >= 0; i -= 1) {
        reversedString += text[i];
    }
    console.log(reversedString);
}
solve(['sample']);