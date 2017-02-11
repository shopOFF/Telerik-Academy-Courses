function solve(args) {
  var r = +args[0],
    board = args.slice(2, 2 + r),  // взимаме си от масива, дъската с фигурите по този начин(режем от входния масив от 2-ри ред до 4-ти ред(2 + r));
    moves = args.slice(3 + r);  // така си взимаме движенията , режем си масива от това за дъската, до края на масива !!
}

var matrix = new Array(3);  // number of rows = 3  //how to set the number of rows
for (var i = 0; i < 3; i++) {
  matrix[i] = new Array(4);  // number of cols = 4  //how to set the number of cols
}
for (var row = 1; row <= 4; row += 1) {
  for (var col = 1; col <= 3; col += 1) {
    matrix[col - 1][row - 1] = String.fromCharCode(96 + row) + col;
  }
}
console.log(matrix);

// варианти за пълнене на матрицата:

//for (var row = 0; row < 3; row += 1) {
// for (var col = 0; col < 4; col += 1) {
//   matrix[row][col] = row + col;
//  }
//}
//console.log(matrix);

for (var row = 1; row <= 4; row += 1) {
  for (var col = 1; col <= 3; col += 1) {
    matrix[col - 1][row - 1] = String.fromCharCode(96 + row) + col;
  }
}
console.log(matrix);

// reversed loop
for (var i = 5; i >= 0; i -= 1) {
  console.log('this is a reversed loop' + ' ' + i);
}