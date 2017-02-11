function MostFrequentNum(parameter) {

    var input = parameter[0].split('\n'),
        n = +input[0],
        numbers = input.slice(1),
        min = numbers[0];

    var frequency = {};  // array of frequency.
    var max = 0;  // holds the max frequency.
    var result;   // holds the max frequency element.
    for (var v in numbers) {
        frequency[numbers[v]] = (frequency[numbers[v]] || 0) + 1; // increment frequency.
        if (frequency[numbers[v]] > max) { // is this frequency > max so far ?
            max = frequency[numbers[v]];  // update max.
            result = numbers[v];          // update result.
        }
    }
    console.log(result + ' ' + '(' + max + ' ' + 'times)');
}
// vtori na4in 
function mostfrequent(args) {

    var input = args[0].split('\n'),
        n = input[0],
        numbers = input.slice(1),
        current = numbers[0],
        counter = 1,
        bestNum = 0;
    bestCounter = 0;

    numbers.sort();

    for (var i = 0; i < n; i += 1) {

        if (current === numbers[i + 1]) {
            counter++;
        }
        else {
            if (counter > +bestCounter) {
                bestCounter = counter;
                bestNum = numbers[i];
            }
            counter = 1;
        }
        current = numbers[i + 1];
    }
    console.log(bestNum + " (" + bestCounter + " times)");
}