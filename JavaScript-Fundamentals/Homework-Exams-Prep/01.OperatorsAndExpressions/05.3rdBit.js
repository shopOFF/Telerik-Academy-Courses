function name(parameter) {

    var n = +[parameter];
    var decToBinary = n.toString(2);   // konvertira deseti4no 4islo v dvoi4no(v binarna)
    var thirdBit = decToBinary[decToBinary.length - 4];

    console.log(thirdBit);
}
// vtori na4in :
//function bit(dec) {
    
//   var a = +dec[0];

//var b = (a >>> 3).toString(2) + ""; // konvertira deseti4no 4islo v dvoi4no(v binarna) 
//console.log(b[b.length - 1]);
//}