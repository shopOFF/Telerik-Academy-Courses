function name(parameter) {

    var num = +[parameter];
    
    if (num < 2) {
        return false; // vmesto da pi6em console.log- moje i s return!
    }
    for (var i = 2; i < num; i++) {
        if (num % i == 0) {
            return false;
        }
    }
    return true;
}
//for(var i = 0; i < 100; i++){  // ako iskame da ni izpi6e i koi sa tezio 4isla
//    if(num(i)) console.log(i);
//}