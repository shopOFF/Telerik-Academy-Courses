function name(parameter) {

    var n = +[parameter];                                              // ili var n = +[parameter] + '';    // sabirame go sas string i stava cqloto na string
    var thirdDigit = (n.toString()).charAt(n.toString().length - 3);   // var thirdDigit = n[n.length-3]    // i gotovo direktno 

    if (thirdDigit === '7') {
        console.log('true');
    }
    else {
        if (thirdDigit) {
            console.log('false', thirdDigit);
        }
        else {
            console.log('false', 0);
        }
    }
}