function name(args) {

    var width = + args[0];
    var height = + args[1];
    var area = width * height;
    var perimeter = (width + height) * 2;

    console.log(Number(area).toFixed(2) + ' ' + Number(perimeter).toFixed(2)); // za6toto toFixed ni vra6ta string i slagame Number oitpred za da 
    // go konvertirame v 4islo otnovo
}