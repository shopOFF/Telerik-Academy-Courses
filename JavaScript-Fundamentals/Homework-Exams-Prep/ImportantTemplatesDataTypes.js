// 01. Как да конвертираме стринг в число при инпут от стринг масив, вместо parseInt-(понеже дава понякога отклонения)
// parseInt е ок да се ползва, ако конвертираме от една бройна система в друг, много лесно конвертира!!! 
function ArrayMembers(parameter) {

    var num = +parameter[0];  // +parameter[0], плюсчето ПРАВИ СТРИНГА В ЧИСЛО!!!!!!!! ПОНЕЖЕ В СЛУЧАЯ НИ Е ПОДАДЕН ПАРАМЕТЪРА, КАТО СТРИНГ
    var array = [];
    for (var index = 0; index < num; index += 1) {

        array[index] = +index * 5;
        console.log(array[index]);
    }
}
typeof('123' | 0 ); // number , пак конвертира стринга в число, НО АКО Е ДРОБНО ЧИСЛО ДИРЕКТНО ОТРЯЗВА ДРОБНАТА ЧАСТ И ГО ПРАВИ ЦЯЛО ЧИСЛО!!!! 123.334 | 0 = 123!!!!
typeof ('123' * 1); // number , пак конвертира стринга в число
typeof (+'123'); // number ето това е най-краткият начин да конвертираме стринг в число, с + отпред пред стринга, и дробните са си дробни!!!!

//02. Как да правим други конверсии и да закръгляваме..
//Numbers Conversion
//Convert floating-point to integer number
// var valueDouble = 8.75;
//var valueInt = valueDouble | 0; // 8

//Convert to integer number with rounding // може и math.round, math.floor, math.celling ...
// var valueDouble = 8.75;
//var roundedInt = (valueDouble + 0.5) | 0; // 9

//Convert string to integer
// var str = '1234';
//var i = str | 0 + 1; // 1235

// 03. Преди да дадем стойност на променлива тя е undefined, ако зададем стойност null тя си е null, а не undefined. 
// undefined e различно от null, двете са рзлични неща.
// var somethig; // undefined- не е зададена стойност
// other = null;  // null-няма нищо

// 04. Типовете в javascript са :
// string - 'sdsad'
// number - 1,2,3, 343.34
// boolean - true, false
// Object - []-масиви, {}-обекти
// undefined - undefined
// null - null

//примитиви типове са първите 3: string, number, boolean