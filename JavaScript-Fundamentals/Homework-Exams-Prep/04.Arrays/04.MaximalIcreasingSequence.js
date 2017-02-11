function longestSequence(parameter) {

    var array = parameter[0].split('\n'),
        n = +array[0],
        numbers = array.slice(1),

        current = +numbers[0],
        sum = 1,
        best = 0;

    for (var i = 0; i < n; i += 1) {

        if (current < +numbers[i + 1]) {   // сменяме само от current === +numbers[i + 1]  на  current < +numbers[i + 1]  и вече търси нарастващата редица!!!
            sum++;
        }
        else {
            if (sum > best) {
                best = sum;
            }
            sum = 1;
        }
        current = +numbers[i + 1];
    }
    console.log(best);
}