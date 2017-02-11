function solve(args) {
    var rowsCols = args[0].split(' ').map(Number),
        rows = +rowsCols[0],
        cols = +rowsCols[1],
        startingCordinates = args[1].split(';'),
        moves = args.slice(2),
        trollWboupPosition = startingCordinates[0].split(' ').map(Number),
        trollNbslbubPosition = startingCordinates[1].split(' ').map(Number),
        LsjtujzboPosition = startingCordinates[2].split(' ').map(Number),
        matrix = new Array(rows);

    for (var i = 0; i < rows; i++) {
        matrix[i] = new Array(cols);  // number of cols = 4  //how to set the number of cols
    }
    // matrix and first positions
    for (var row = 0; row < rows; row += 1) {
        for (var col = 0; col < cols; col += 1) {
            if (row === trollWboupPosition[0] && col === trollWboupPosition[1]) {
                matrix[row][col] = 'trollWboup';
            }
            else if (row === trollNbslbubPosition[0] && col === trollNbslbubPosition[1]) {
                matrix[row][col] = 'trollNbslbub';
            }
            else if (row === LsjtujzboPosition[0] && col === LsjtujzboPosition[1]) {
                matrix[row][col] = 'princes';
            }
            else {
                matrix[row][col] = '';
            }
        }
    }
    for(var j = 0; j < moves.length; j += 1) {
        if (moves[j]==='mv Lsjtujzbo d') {
            var a = matrix.indexOf('princes');
        }
        else if (moves[j]=== 'lay trap') {
            
        }
    }

    console.log('The trolls caught Lsjtujzbo at 1 1');

}

solve([
    '5 5',
    '1 1;0 1;2 3',
    'mv Lsjtujzbo d',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Wboup r',
    'mv Wboup r',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d'
]);



// trimeing white space /[ \t]+/g