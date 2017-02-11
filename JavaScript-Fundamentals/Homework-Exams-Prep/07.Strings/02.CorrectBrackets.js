function solve(params) {
    var text = params[0],
        openingBracketsCounter = 0,
        closingBractetsCounter = 0;
    for (var i = 0; i < text.length; i += 1) {
        if (text[i] === '(') {
            openingBracketsCounter += 1;
        }
        if (text[i] === ')') {
            closingBractetsCounter += 1;
        }
    }
    if (openingBracketsCounter === closingBractetsCounter) {
        console.log('Correct');
    }
    else {
        console.log('Incorrect');
    }
}
solve([ ')(a+b))' ]);