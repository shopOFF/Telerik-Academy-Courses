function AppearanceCount(args) {
    var input = args[0].split('\n'), // сплитва целият инпут, по нови редове и ги слага в масив, всеки ред е елемент от масива!!!
        arrayLength = input[0], // взима първият елемент от масива, той ще е броят на елементите(дължината му) в масива с числа, който ще изполваме !!!
        array = input[1].split(' ').map(Number), // взима втория ред(който е самият масив, с числа), сплитва ги по празно място и ги прави на числа!!!
        numberToCheckFor = input[2],  // взимаме си вече числото, което ще проверявме, колко пъти се съдържа в масива!!!
        counter = 0;

    for (var i = 0; i < arrayLength; i += 1) {
        if (array[i] == numberToCheckFor) {
            counter += 1;
        }
    }
    return counter;
}
// vtori na4in pak ne dava to4ki:
function appearanceCount(args) {
    var input = args[0].split('\n'),
        arrayLength = input[0],
        array = input[1].split(' ').map(Number),
        x = input[2];

    return countAppearance(array, arrayLength, x);

    function countAppearance(array, arrLength, x) {
        var counter = 0,
            i;

        for (i = 0; i < arrLength; i += 1) {
            if (array[i] == x) {
                counter += 1;
            }
        }

        return counter;
    }
}
// tova e re6enieto za 100 to4ki direktno vzimame inputa i go razpredelqme po promenlivite
function AppearanceCount(args) {
    
        arrayLength = args[0], // взима първият елемент от масива, той ще е броят на елементите(дължината му) в масива с числа, който ще изполваме !!!
        array = args[1].split(' ').map(Number), // взима втория ред(който е самият масив, с числа), сплитва ги по празно място и ги прави на числа!!!
        numberToCheckFor = args[2],  // взимаме си вече числото, което ще проверявме, колко пъти се съдържа в масива!!!
        counter = 0;

    for (var i = 0; i < arrayLength; i += 1) {
        if (array[i] == numberToCheckFor) {
            counter += 1;
        }
    }
    return counter;
}