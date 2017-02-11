function name(parameters) {

    var x = +parameters[0];
    var y = +parameters[1];
    var radius = 2;

    var pythagorTheoremPart1 = (x * x) + (y * y);    // izpolzvame Pitagorovata teorema za da namerim razstoqnieto(distanciqta) mejdu dvete to4ki
    var pythagorTheoremPart2 = Math.sqrt(pythagorTheoremPart1);

    if (radius >= pythagorTheoremPart2)     // za da namerim dali to4kata e v okrajnossta ili na liniqta, prosto sravnqvame s radiusa i, ako e radiusa e po golqm ili raven zna4i to4kata e vatre v okrajnossta 
    {                                       //ili na liniqta po obqsnimi pri4ini...(kogato radiusa se zavarti ot na4alnata si to4ka-0, sazdava okrajnostta i tq ima ve4e sredna to4ka-0)   
        console.log("yes", pythagorTheoremPart2.toFixed(2));
    }
    else {
        console.log("no", pythagorTheoremPart2.toFixed(2)); // v slu4ai 4e e izvan okrajnostta
    }
}
// moje i taka s dobavqne na prazni mesta
//function name(parameters) {

//    var x = +parameters[0];
//    var y = +parameters[1];
//    var radius = 2;
//
//   var pythagorTheoremPart1 = (x * x) + (y * y);    // izpolzvame Pitagorovata teorema za da namerim razstoqnieto(distanciqta) mejdu dvete to4ki
//   var pythagorTheoremPart2 = Math.sqrt(pythagorTheoremPart1);

//   if (radius >= pythagorTheoremPart2)     // za da namerim dali to4kata e v okrajnossta ili na liniqta, prosto sravnqvame s radiusa i, ako e radiusa e po golqm ili raven zna4i to4kata e vatre v okrajnossta 
//   {                                       //ili na liniqta po obqsnimi pri4ini...(kogato radiusa se zavarti ot na4alnata si to4ka-0, sazdava okrajnostta i tq ima ve4e sredna to4ka-0)   
//   console.log('yes' + ' ' + pythagorTheoremPart2.toFixed(2));
//   }
//   else {
//    console.log('no' + ' ' + pythagorTheoremPart2.toFixed(2)); // v slu4ai 4e e izvan okrajnostta
//   }
// }