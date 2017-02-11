function solve(params) {
    var searchFor = (params[0] + '').toLowerCase(),
        text = (params[1] + '').toLowerCase(),
        position = 0,
        occurrencesCounter = 0;

     position = text.indexOf(searchFor);
    while (position >= 0) {
        occurrencesCounter += 1;
        position = text.indexOf(searchFor, position + 1);
    }
    console.log(occurrencesCounter);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);