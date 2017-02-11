//Declaring Arrays // Масивите в джаваскрипт нямат определена дължина и можем да блъскаме в тях, колкото си искаме елементи.
//Declaring an array in JavaScript
// Array holding integers
//var numbers = [1, 2, 3, 4, 5];

// Array holding strings
//var weekDays = ['Monday', 'Tuesday', 'Wednesday',
//  'Thursday', 'Friday', 'Saturday', 'Sunday']

// Array of different types   // в джавасрипт масивите могът да съдържат в себе си различни типове данни, числа, стрингове и др в един масив!
//var mixedArr = [1, new Date(), 'hello'];  // понеже в джаваскрипт няма типизация

// Array of arrays (matrix)  // ето така можем да си направим матрица,всъщност е  масив от масив така се прави в джавскрипт, като назъбените в c#, вътрешните масиви могът да имате различна, дължина и типове и тн!!!
//var matrix = [
//  ['0,0', '0,1', '0,2'],
//  ['1,0', '1,1', '1,2'],
//  ['2,0', '2,1', '2,2']];

// 01. Как да декларираме масив: има няколко начин, но препоръчителният е: 
//Using array literal (recommended):
//var arr = [1, 2, 3, 4, 5];  // и си го пълним директно
//или просто 
//var arr = [];  ако искаме да не декларираме нищо в масива просто да си го създадем в началото

// ПРИМЕР ОФ ТОПИК:
var numbers = [1, 2, 3];
numbers[1] = 'two';
console.log(numbers);  // [1, two, 3] 

// 02. Как да  достъпваме елементи от масива.
//How to Access Array Element?
//Array elements are accessed using the indexer operator: [] (square brackets)
//Array indexer takes element’s index as parameter in the range [0; length-1]
//The first element has index 0
//The last element has index length-1
//Array elements can be retrieved and changed by the [] (indexer) operator
// НО МОЖЕМ ДА СИ НАПРАВИМ И ТАКА ДА СЛОЖИМ ЕЛЕМЕНТИ НА [1], [2], [3] ПОЗИЦИИ В МАСИВА  И СЛЕД ТОВА ДИРЕКТНО НА [30]...

// 03. Желателно е винаги да декларираме променливите най-огроре и да има думичката var само 1 път(иначе интерпретатора го прави автоматично), за let вече е, като при c#(нормалния начин си е ок)
// виж долния пример от 04.
//04.Ето така се обръща масив: //Reversing an Array – Example ИЛИ С ВГРАДЕНИЯ МЕТОД array.reverse();  
//Example: Reversing the elements of an array
//always declare var variables on the top of the scope!
//var array,
//    len,
//    reversed,
//    i,
//    j;

//array = [1, 2, 3, 4, 5];
//reversed = [];

//for (i = 0, len = array.length; i < len; i += 1) {
//    j = len - i - 1;
//    reversed.push(array[j]);
//}

// 05. Ако искаме да създадем масив с n- на брои елемента 
// ако n=5;
//arr[n - 1] = undefined; // и това ще ни направи  елементи на 0-лева позиция, 1-ва, 2-ра, 3-та, 4-та позиции...(на позиции до n-1)

// 06. Принтираме масив в обратен ред.
//Example: Printing array of numbers in reversed order:
// var arr, i, len;
//arr = [1, 2, 3, 4, 5];
//for (len = arr.length, i = len - 1; i >= 0; i -= 1) {
////    console.log(arr[i]);
//} // Result: 5 4 3 2 1

// 07. Добавяне и премахване на елементи от масиви 
//Inserting and Removing Elements from Arrays
// push & unshift - ни добавят елементи
// pop & shift - ни премахват елементи

//Inserting and Removing Elements from Arrays
//All arrays in JavaScript are dynamic
//Their size can be changed at runtime
//New elements can be inserted to the array
//Elements can be removed from the array

// ИМА 4 МЕТОДА, С КОИТО МОЖЕМ ДА МАХАМЕ ИЛИ ДОБАВЯМЕ ЕЛЕМЕНТИ В МАСИВИ, ТЯХНАТА УПОТРЕБА Е ПРЕПОРЪЧИТЕЛНА: push, pop, shift, unshift
//Methods for array manipulation:
//Array#push(element) - ДОБАВЯ ЕЛЕМЕНТ В КРАЯ НА МАСИВА !!!
//Inserts a new element at the tail of the array

//Array#unshift(element) - ДОБАВЯ ЕЛЕМЕНТ В НАЧАЛОТО НА МАСИВА !!!
//Inserts a new element at the head of the array

//Array#pop() - МАХА ЕЛЕМЕНТ В КРАЯ НА МАСИВА !!!
//Removes the element at the tail
//Returns the removed element

//Array#shift() - МАХА ЕЛЕМЕНТ В НАЧАЛОТО НА МАСИВА !!!
//Removes the element at the head
//Returns the remove element

// ПРИМЕР:
var array = [13, 15, 21];
console.log(array);  // 13, 15, 21

array.push('Tail');   // добая в края новия елемент и това е ! работи бързо!
console.log(array);  // 13, 15, 21, Tail

array.unshift('Head');  //добавя в началото и всички елементи се изместват с един индекс надясно.ХУБАВО Е ДА НЕ ГО ПОЛЗВАМЕ, ОСВЕН АКО НЕ НИ СЕ НАЛАГА ИЗРИЧНО(ЗА ДА НЕ СЕ НАЛАГА ДА ПРОМЕНЯМЕ ИНДЕКСИТЕ НА ВСИЧКИ ЕЛЕМЕНТИ В МАСИВА ) !
console.log(array);  // Head, 13, 15, 21, Tail      // работи бавно!

var tail = array.pop(); // прави 2 неща, първото е да премахне елемента най-отзад! И 2-ро връща, като резултат един обект, който е изтритият елемент от масива!!!
console.log(array);  // Head, 13, 15, 21  // премахнало е Tail което беше в края!    // работи бързо!
console.log(tail);  // Tail // pop е присвойл на var tail- стойността на елемента, който е премахнал!!!

var head = array.shift(); // прави същото като pop, но за първият елемент!!! работи бавно!
console.log(array);     // 13, 15, 21  ПРЕМАХНАЛО Е Head ОТ НАЧЛОТО НА МАСИВА И 
console.log(head);      // Head // Е ПРИСВОЙЛ СТООЙНОСТТА НА ПРЕМАХНАТИЯ ОТ МАСИВА ЕЛЕМЕНТ НА var head !!!


// 08. Array Methods !!!!!!!
//Array#reverse()

//Reverses the elements of the array
//Returns a new arrays
//var items = [1, 2, 3, 4, 5, 6];
//var reversed = items.reverse();
//reversed = [6, 5, 4, 3, 2, 1]

//Array#join(separator)!!!!!!!!!!!!
//Concatenates the elements with a separator
//Returns a string
//var names = ["John", "Jane", "George", "Helen"];
//var namesString = names.join(", ");
//namesString = "John, Jane, George, Helen"


// 09. Concatenating Arrays

//arr1.concat(arr2)
//Inserts the elements of arr2 at the end of arr1
//Returns a new array
//arr1 and arr2 remain unchanged!
//var arr1 = [1, 2, 3];
//var arr2 = ["one", "two", "three"];
//var result = arr1.concat(arr2);
//result = [1, 2, 3, "one", "two", "three"]

//Adding the elements of an array to other array
//var arr1 = [1, 2, 3];
//var arr2 = ["one", "two", "three"];
//[].push.apply(arr1, arr2);
//arr1 = [1, 2, 3, "one", "two", "three"]

// 10. УПОТРЕБА НА SLICE()- МОЖЕ ДА СЕ ПОЛЗВА ПО 2 НАЧИНА ОТ ИНДЕКС ДО КРАЯ НА МАСИВА items.slice(2)- (от 2-ри индекс докрая на масива) И ОТ ИНДЕКС ДО ИНДЕКС items.slice(1, 3)
// ОТ 1-ВИ индекс до 3-ти индекс(но без 3-тия индекс)...
// 10. Getting Parts of Arrays. УПОТРЕБА НА SLICE() С НЕГО МОЖЕМ ДА ВЗЕМЕМ ЧАСТ ОТ МАСИВА(от индекс до индекс(като не включва енд индекса))
// А МОЖЕ ДА МУ ЗАДАДЕМ САМО ОТ ОПРЕДЕЛЕН ИНДЕКС БЕЗ ДА МУ КАЗВАМЕ ДО КЪДЕ: items.slice(1);  И ЩЕ НИ ВЗЕМЕ ЕЛЕМЕНТИТЕ ОТ 1-ВИЯ ИНДЕКС ДО КРАЯ НА МАСИВА !!! 
//Array#slice(fromIndex [, toIndex])
//Returns a new array  // връща ни нов масив
//A shallow copy of a portion of the array  // прави плитко копие на част от массиива
//The new array contains the elements from indices fromIndex to to (excluding toIndex)
//Can be used to clone an array

//var items = [1, 2, 3, 4, 5];
//var part = items.slice(1, 3);   В СЛУЧАЯ ВЗЕМИ МИ ОТ 1 ВИ ИНДЕКС ДО 3-ТИ ИНДЕКС(като не взима енд индекса(3-тия индекс))
//part = [2, 3]  // това е резултата
//var clonedItems = items.slice();   

// ВТОРИ ПРИМЕР :
//var items = [1, 2, 3, 4, 5];
//var part = items.slice(1);   В СЛУЧАЯ ВЗЕМИ МИ ОТ 1 ВИ ИНДЕКС ДО КРАЯ НА МАСИВА !!!!
//part = [2, 3, 4, 5]  // това е резултата


// 11. УПОТРЕБА НА SPLICE()  - ТОЙ Е НАЙ ИНТЕРЕСНИЯТ МЕТОД, КОЙТО ИМАМЕ ВЪРХУ МАСИВИТЕ!!!!!!!!!!!!!
// ТОЙ ЕДНОВРЕМЕННО ДОБАВЯ И ИЗТРИВА ЕЛЕМЕНТИ. И Е ЕДИНСТВЕНИЯТ МЕТОД, С КОЙТО МОЖЕМ ДА ДОБАВЯМЕ И ИЗТРИВАМЕ ЕЛЕМЕНТИ 
// ПОСРЕДАТА НА МАСИВА!!!!!

//Splicing Arrays
//Array#splice(index, count, elements)
//Removes count elements, starting from index position
//Adds elements at position index
//Returns a new array, containing the removed elements
//var numbers = [1, 2, 3, 4, 5, 6, 7];
//var result = numbers.splice(3, 2, "four", "five", "five.five");
//result = [4, 5]
//numbers = [1, 2, 3, "four", "five", "five.five", 6, 7];

//Splicing Arrays
//Array#splice(index, count, elements)
//Example uses:
//Remove elements from any index of the array:

//removes a single element at position index
//items.splice(index, 1);
//removes count elements starting from position index
//items.splice(index, count);
//Insert elements at any index of the array:

//Inserts a single element at position index
//items.splice(index, 0, element);
//Inserts many elements starting from position index
//items.splice(index, 0, item1, item2, item3);

//ПРИМЕР:  splice()-метода взима поне 2 параметъра, който са му важни(ПЪРВИЯ Е ИНДЕКС(НА ТОЗИ ИНДЕКСА ИСКАМ ДА ПРАВИШ МАГИИТЕ), ВТОРИЯ Е
// DELETECOUNT(КОЙТО КАЗВА, ИСКАМ ОТ ОНЗИ ИНДЕКС НА ДЯСНО ДА ИЗТРИЕШ ТОЛКОВА НА БРОЙ ЕЛЕМЕНТА(DELETECOUNT))).  И ВЕЧЕ 3-ТИ , 4-ТИ, 5-ТИ И ТН..
// ВСИЧКИ ОСТАНАЛИ ПАРАМЕТРИ СА ЕЛЕМЕНТИТЕ ПЪК, КОИТО ИСКАМЕ ДА ДОБАВИМ НА МЯСТОТО НА ТЕЗИ ИЗТРИТИТЕ!!!!!!!!!
var x = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
    index = 6,   // искам от 6-ти индекс надясно да
    deleteCount = 2; // да изтриеш два елемента

console.log(x);  // [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] преди splice метода
x.splice(index, deleteCount, 'Seven', 'Eight', 'Eight.half');
console.log(x);  // [1, 2, 3, 4, 5, 6, "Seven", "Eight", "Eight.half", 9, 10] това е след метода, след като сме изтрили от 6-ти индекс на дясно
// следващите 2 елемента и сме ги заместили със 'Seven', 'Eight', 'Eight.half', след тях си следват другите елементи от масива, които не сме пипали- 9, 10

// REMOVE FROM THE ARRAY 
// ПРИМЕР, АКО ИСКАМЕ ДА ИЗТРИЕМ САМО 1 ЕЛЕМЕНТ НА ТОЧНО ОПРЕДЕЛЕН ИНДЕКС, МОЖЕ И ПОВЕЧЕ ОТ 1 ЕЛЕМЕНТ ДА ИЗТРИИЕМ АКО ИСАКМЕ !!!
//var x = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
//x.splice(7, 1); например от 7-ми индекс ми изтрии 1 на брой елементи- ето така !! и премахва на 7ми индекс-осмицата
//console.log(x);  // [1, 2, 3, 4, 5, 6, 7, 9, 10] това е резултата

// INSERT IN THE ARRAY AT INDEX
// ПРИМЕР, АКО ИСКАМЕ ДА ИНСЪРТНЕМ ЕЛЕМЕНТ НА КОНКРЕТЕН ИНДЕКС, БЕЗ ДА ТРИЕМ, МОЖЕ И ДА ТРИЕМ АКО ИСКАМЕ !!!
//var x = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
//x.splice(7, 0, 'John'); например НА 7-ми индекс,ДА НЕ ИЗТРИВАМЕ НИЩО(ЗАТОВА Е 0) И да инсъртнем 1 на брой елемент(John)- ето така !! и добавя на 7ми индекс John, КАТО НЕ ТРИЕ НИЩО!!!
//console.log(x);  // [1, 2, 3, 4, 5, 6, 7, 'John', 8, 9, 10] това е резултата

// SPLICE  СЪЩО ТАКА НИ ВРЪЩА И РЕЗУЛТАТ ПРИ REMOVE FROM THE ARRAY 
//var x = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
//var result = x.splice(7, 3);  
//console.log(x);  // [1, 2, 3, 4, 5, 6, 7] това е резултата na X
//console.log(result);  // [8, 9, 10] това е резултата на result

// SPLICE МАЛКО ОБЕСМИСЛЯ push, pop, shift, unshift ПОНЕЖЕ Е ПО ФЛЕКСИБЪЛ(ПО-ДОБЪР Е ПОВЕЧЕ НЕЩА МОЖЕ ДА ПРАВИ). НО КОТ ТАКОА
// МНОГО Е ПОЛЕЗЕН, МНОГО НЕЩА МОГЪТ ДА СЕ ПРАВЯТ С НЕГО !!!!!
// МОЖЕ В НЕГО ДА ПОЛЗВАМЕ И ОТРИЦАТЕЛНИ ИНДЕКСИ!НЕ Е ПРЕПОРЪЧИТЕЛНО ОБАЧЕ!!! ОТРИЦАТЕЛЕН ОЗНАЧАВА ОТ ЗАД НАПРЕД!!!

//var x = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
//var result = x.splice(-5, 1);   // КАЗВАМЕ МУ ОТ -5 ТИ ИНДЕКС ДА ИЗТРИЕШ 1 ЕЛЕМЕНТ(ОТ ЗАДА НАПРЕД) Е ШЕСТИЦАТА НА ТОЗИ ИНДЕКС, 10 Е 1 ИНДЕКС И ТН...
//console.log(x);  // [1, 2, 3, 4, 5, 7, 8, 9, 10] това е резултата na X-ИЗТРИВА 6-ТИЦАТА, ТЯ Е ОТ ЗАД НАПРЕД НА 5-ТИ ИНДЕКС
//console.log(result);  // [6] това е резултата на result 


// 12.Searching in Arrays
//Array#indexOf(element [, rightOf]) - ВРЪЩА НИ ИНДЕКСА НА ПЪРВОТО СЪВПАДЕНИЕ НА ТЪРСЕНОТО НИ НЕЩО ИЛИ -1 АКО НЯМА СЪВПАДЕНИЯ. ИЛИ МОЖЕ ДА ТЪРСИ СЪВПАДЕНИЕ СЛЕД ОПРЕДЕЛЕН ИНДЕКС!!!
//Returns the index of the first match in the array
//Returns -1 is the element is not found

//Array#lastIndexOf(element, [leftOf])  - ВРЪЩА НИ ИНДЕКСА  НА ПОСЛЕДНОТО СЪВПАДЕНИЕ(НАЙ-ДЯСНОТО) НА ТЪРСЕНОТО НИ НЕЩО ИЛИ -1 АКО НЯМА СЪВПАДЕНИЯ
//Returns the index of the first match in the array
//Returns -1 is the element is not found

//Array#indexOf() and Array#lastIndexOf() do not work in all browsers!!!!!
//Need to be shimmed

// ПРИМЕР: КАК ДА НАМЕРИМ (КОЛКО ПЪТИ СЕ ПОВТАРЯ ДАДЕН ЕЛЕМЕНТ) ИЛИ ВСИЧКИ ИНДЕКСИ НА ОПРЕДЕЛЕН ЕЛЕМЕНТ КОЙТО СЕ ПОВТАРЯ В МАСИВ НЕОГРАНИЧЕН БРОЙ С indexOf :
//var array = [1, 2, 3, 45, 2, 1, 1, 2, 3, 4, 5, 6, 78, 8, 56, 2, 1, 2, 3, 4, 45, 56, 7, 2, 3, 3, 34, 5, 1];
//var index = array.indexOf(1); // ще търсим единицата на кои индекси е !!!
//while (index >= 0) {
//    console.log(index);   // изписва ни на конзолата всеки индекс на който е 1
//    index = array.indexOf(1, index + 1);   // последния намерен индекс + 1 ще започне да търси следващата 1-ца на кой индекс е 
//}     
//   резултата е 0, 5, 6, 16, 28, -1
