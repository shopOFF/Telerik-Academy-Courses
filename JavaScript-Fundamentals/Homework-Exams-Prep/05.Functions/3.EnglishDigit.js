    function EnglishDigit(input) {
        var num = input[0];
        var numToString = input.toString();  // pravim si 4isloto v string, za da si vzemem posledniq mu element, po-lesno
        var lastDigit = +numToString.slice(-1);  // vzimame posledniq element of stringa- v slu4aq poslednata cifra ot 4islo vzima//
        if (lastDigit === 0) {
            console.log('zero');
        }
        else if (lastDigit === 1) {
            console.log('one');
        }
        else if (lastDigit === 2) {
            console.log('two');
        }
        else if (lastDigit === 3) {
            console.log('three');
        }
        else if (lastDigit === 4) {
            console.log('four');
        }
        else if (lastDigit === 5) {
            console.log('five');
        }
        else if (lastDigit === 6) {
            console.log('six');
        }
        else if (lastDigit === 7) {
            console.log('seven');
        }
        else if (lastDigit === 8) {
            console.log('eight');
        }
        else {
            console.log('nine');
        }
    }
    // vtori na4in:
    function digit(number) {
    var num = String(number),
    digit = num[num.length - 1];

    switch (digit) {
        case '0': return 'zero';
    case '1': return 'one';
    case '2': return 'two';
    case '3': return 'three';
    case '4': return 'four';
    case '5': return 'five';
    case '6': return 'six';
    case '7': return 'seven';
    case '8': return 'eight';
    case '9': return 'nine';
        default:
            break;
    }
}