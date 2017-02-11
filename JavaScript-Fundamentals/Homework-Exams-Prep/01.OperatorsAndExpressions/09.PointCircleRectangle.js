function name(parameters) {

    var x = +parameters[0];
    var y = +parameters[1];

    var inCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5); // 1.5 tova e radiusa//proverqva dali to4kata e v kraga i dava true ako radiusa (1.5*1.5) e po golqm ili false ako ne e
    var inRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1); //proverqva dali to4kata e v pravoagalnika

    if (inCircle === true && inRectangle === true) {
        console.log("inside circle inside rectangle");
    }
    else if (inCircle === false && inRectangle === false) {
        console.log("outside circle outside rectangle");
    }
    else if (inCircle === true && inRectangle === false) {
        console.log("inside circle outside rectangle");
    }
    else {
        console.log("outside circle inside rectangle");
    }
}