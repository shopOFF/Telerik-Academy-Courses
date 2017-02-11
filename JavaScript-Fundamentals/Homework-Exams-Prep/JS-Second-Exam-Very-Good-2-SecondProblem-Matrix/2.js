// function solve(args) { //мое решение за 90 точки

//     const arr = args[0].split(' ').map(Number);
//     const rows = arr[0];
//     const cols = arr[1];

//     const row = rows;
//     const col = cols;

//     let rowStartPos = Math.floor(rows / 2);
//     let colStartPos = Math.floor(cols / 2);

//     function dec2bin(dec) {
//         return (dec >>> 0).toString(2);
//     }

//     function padToFour(number) {
//         if (number <= 9999) { number = ("000" + number).slice(-4); }
//         return number;
//     }

//     let field = new Array(rows);
//     field.fill(0);
//     for (var i = 0; i < rows; i += 1) {
//         let rowNums = args[i + 1].split(' ').map(Number);
//         field[i] = [];
//         for (var j = 0; j < cols; j += 1) {
//             field[i][j] = padToFour(dec2bin(rowNums[j]));
//         }
//     }

//     let cellIsVisited = field;
//     let currentPos = field[rowStartPos][colStartPos];

//     while (true) {

//         for (var i = 0; i < 1; i += 1) {
//             if (currentPos.charAt(3) == "1" && cellIsVisited[rowStartPos != 0 ? (rowStartPos - 1) : (0)][colStartPos] != true) { // going up
//                 if (rowStartPos == 0) {
//                     return console.log(`No rakiya, only JavaScript ${rowStartPos} ${colStartPos}`);
//                 } else if (cellIsVisited[rowStartPos - 1][colStartPos] != true) {
//                     cellIsVisited[rowStartPos][colStartPos] = true;
//                     rowStartPos -= 1;
//                     currentPos = field[rowStartPos][colStartPos];
//                     break;
//                 }
//             } else if (currentPos.charAt(2) == "1" && cellIsVisited[rowStartPos][colStartPos + 1] != true) { //  right
//                 if (colStartPos == cols - 1) {
//                     return (`No rakiya, only JavaScript ${rowStartPos} ${colStartPos}`);
//                 } else if (cellIsVisited[rowStartPos][colStartPos + 1] != true) {
//                     cellIsVisited[rowStartPos][colStartPos] = true;
//                     colStartPos += 1;
//                     currentPos = field[rowStartPos][colStartPos];
//                     break;
//                 }
//             } else if (currentPos.charAt(1) == "1" && cellIsVisited[rowStartPos + 1][colStartPos] != true) { //  down
//                 if (rowStartPos == rows - 1) {
//                     return (`No rakiya, only JavaScript ${rowStartPos} ${colStartPos}`);
//                 } else if (cellIsVisited[rowStartPos + 1][colStartPos] != true) {
//                     cellIsVisited[rowStartPos][colStartPos] = true;
//                     rowStartPos += 1;
//                     currentPos = field[rowStartPos][colStartPos];
//                     break;
//                 }
//             } else if (currentPos.charAt(0) == "1" && cellIsVisited[rowStartPos][colStartPos - 1] != true) { //  left
//                 if (colStartPos == 0) {
//                     return (`No rakiya, only JavaScript ${rowStartPos} ${colStartPos}`);
//                 } else if (cellIsVisited[rowStartPos][colStartPos - 1] != true) {
//                     cellIsVisited[rowStartPos][colStartPos] = true;
//                     colStartPos -= 1;
//                     currentPos = field[rowStartPos][colStartPos];
//                     break;
//                 }
//             } else {
//                 return (`No JavaScript, only rakiya ${rowStartPos} ${colStartPos}`);
//             }
//         }
//     }
// }

solve([
    '5 7',
    '9 5 3 11 9 5 3',
    '10 11 10 12 4 3 10',
    '10 10 12 7 13 6 10',
    '12 4 3 9 5 5 2',
    '13 5 4 6 13 5 6'
]);

// solve([
//     '7 5',
//     '9 3 11 9 3',
//     '10 12 4 6 10',
//     '12 3 13 1 6',
//     '9 6 11 12 3',
//     '10 9 6 13 6',
//     '10 12 5 5 3',
//     '12 5 5 5 6'
// ]);

////
function solve(args) { // много добро решение за 100 точки
    var dimensions = args[0].split(' ').map(Number);

    var matrix = new Array(dimensions[0]);
    for (var i = 0; i < dimensions[0]; i += 1) {
        matrix[i] = args[i + 1].split(' ').map(Number);

        for (var j = 0; j < dimensions[1]; j += 1) {
            matrix[i][j] = getBin(matrix[i][j]);
        }
    }

    var startRow = dimensions[0] / 2 | 0,
        startCol = dimensions[1] / 2 | 0;

    while (true) {
        var storedRow = startRow,
            storedCol = startCol;

        if (matrix[startRow][startCol][3] === '1' && matrix[startRow - 1][startCol] !== '0') {
            startRow -= 1;
        } else if (matrix[startRow][startCol][2] === '1' && matrix[startRow][startCol + 1] !== '0') {
            startCol += 1
        } else if (matrix[startRow][startCol][1] === '1' && matrix[startRow + 1][startCol] !== '0') {
            startRow += 1;
        } else if (matrix[startRow][startCol][0] === '1' && matrix[startRow][startCol - 1] !== '0') {
            startCol -= 1
        } else {
            console.log('No JavaScript, only rakiya ' + storedRow + ' ' + storedCol)
            break;
        }

        if (startCol === 0 || startCol === dimensions[1] - 1 || startRow === 0 || startRow === dimensions[0] - 1) {
            console.log('No rakiya, only JavaScript ' + startRow + ' ' + startCol);
            break;
        }
        matrix[storedRow][storedCol] = '0'; // маркираме си с нула клетките, в който вече сме били!!!
    }

    function getBin(number) {
        var bin = '000' + number.toString(2);
        return bin.substr(bin.length - 4, 4)
    }
}