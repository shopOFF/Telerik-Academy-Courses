function ArrayMembers(parameter) {

    var num = +parameter[0];  // +parameter[0], плюсчето ПРАВИ СТРИНГА В ЧИСЛО!!!!!!!! ПОНЕЖЕ В СЛУЧАЯ НИ Е ПОДАДЕН ПАРАМЕТЪРА, КАТО СТРИНГ
    var array = [];
    for (var index = 0; index < num; index += 1) {

        array[index] = +index * 5;
        console.log(array[index]);
    }
}

// vtori na4in bez masiva
//function ArrayMembers(parameter) {

//    var num = +parameter[0];

//    for (var index = 0; index < num; index += 1) {

//        var el = +index * 5;
//        console.log(el);
//    }
//}