function solve(args) {;
    let input = args.map(Number);
    let n = input.shift();
    let currentResult = 1;

    for (var i = 0; i < n; i += 1) {
        if (input[i] % 2 != 0) {
            if (currentResult < 1024) {
                currentResult *= input[i];
                if (currentResult >= 1024) {
                    currentResult %= 1024;
                }
            } else {
                currentResult *= input[i];
                currentResult %= 1024;
            }
        } else {
            if (i == 0) {
                currentResult = 0;
            }
            if (currentResult < 1024) {
                currentResult += input[i];
                i += 1;
                if (currentResult >= 1024) {
                    currentResult %= 1024;
                }
            } else {
                currentResult %= 1024;
                i += 1;
            }
        }
    }

    console.log(currentResult);
}

// solve([
//     '10',
//     '1',
//     '2',
//     '3',
//     '4',
//     '5',
//     '6',
//     '7',
//     '8',
//     '9',
//     '0'
// ]);

solve([
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9'
]);