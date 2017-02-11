// 01. Какво е функция в джаваскрипт:
//What is a Function?
//A function is a kind of building block that solves a small problem
//A piece of code that has a name and can be called from other code
//Can take parameters and return a value
//Functions allow programmers to construct large programs from simple pieces

// 02.Защо да използваме функции- МНОГО ВАЖНО, ДА СИ СТРУКТУРИРАМЕ КОДА Е МНОГО ДОБРЕ, ПОСЛЕ МОЖЕ ДА СЕ ПРЕИЗПОЛЗВАТ ТЕЗИ ФУНКЦИИ МНОГО ПО ЛЕСНО!!!!
// И ОЩЕ МНОГО ДРУГИ ВАЖНИ НЕЩА!!! 
//Why to Use Functions?
//More manageable programming
//Split large problems into small pieces
//Better organization of the program
//Improve code readability and understandability
//Enhance abstraction
//Avoiding repeating code
//Improve code maintainability
//Code reusability
//Using existing functions several times

// 03.Declaring and Creating Functions
//Each function has a name
//It is used to call the function
//Describes its purpose
//Functions in JavaScript do not explicitly define return type
//Each function always returns a value
// function printLogo() {
//    console.log("JavaScript Fundamentals");
//    console.log("Telerik Software Academy");
//}

// 04. Ways of Defining a Function
//By function declaration - ТОВА Е НАЙ-ДОБРИЯТ НАЧИН !!!
//function print() { console.log("Hello") };

//By function expression -  НЕ Е МНОГО ДОБЪР ВАРИАНТ!
//var print = function() { console.log("Hello") };
//var print = function printFunc() { console.log("Hello") 

// 05. Calling Functions
//To call a function, simply use:
//The function's name
//Parentheses
//A semicolon (;)
//Optional, but preferred
//This will execute the code in the function's body and will result in printing the following:
// printLogo(); - ЕТО ТАКА СЕ ИЗВИКВА ФУНКЦИЯ
//JavaScript Fundamentals
//Telerik Software Academy

// друг пример:
//function printLogo() {
//			jsConsole.writeLine('---------------');
//			jsConsole.writeLine('Telerik Corp.');
//			jsConsole.writeLine('www.telerik.com');
//			jsConsole.writeLine('---------------');
//		}														
//		function anotherPrint() {
//			printLogo();
//			anotherPrint();
//		}
//		anotherPrint();	

//друг пример:
//function drinkBeer() {
//    openCap();
//    drink();
//}
//function openCap() {

//}
//function drink() {

//}
//drinkBeer();
// и тн....

// ДРУГ ПРИМЕР: ЗА РЕКУРСИЯ
//Calling Functions
//A function can be called from:
//Any other function
//Itself (process known as recursion)
//function print() {
//    console.log("printed");
//function print(){
//   console.log("printed");
//}
//function anotherPrint(){
//   print();
//   anotherPrint();
//}

// 06. Functions with Parameters
//Passing information to functions
//Function Parameters
//To pass information to a function, you can use parameters(also known as arguments)
//You can pass zero or several input values
//Each parameter has а name
//Parameters are assigned to particular values when the function is called
//Parameters change the function behavior depending on the passed values

//Defining and Using Function Parameters
//Function's behavior depends on its parameters
//Parameters can be of any type. ФУНКЦИИТЕ МОГЪТ ДА ПРИЕМАТ КАТО ПАРАМЕТРИ АБСОЮТНО ВСИЧКО, ДОРИ ДР ФУНКЦИИ!
//Number, String, Object, Array, etc.
//Even Function       // ТОЗИ ПРИМЕР ПРОДЪЛЖАВА И НАДОЛО !
// function printSign(number) {
//    if (number > 0) {
//        console.log("Positive");
//    } else if (number < 0) {
//        console.log("Negative");
//    } else {
//        console.log("Zero");
//    }
//}
//Functions can have as many parameters as needed:
//function printMax(x, y) {
// var max;
// x = +x; y = +y;
//  max = x;
//  if (y > max) {
//   max = y;
//  }
//  console.log(`Maximal number: ${max}`);
//}
//Calling Functions with Parameters
//To call a function and pass values to its parameters:
//Use the function's name, followed by a list of expressions for each parameter
//printSign(-5);
//printSign(balance);
//printSign(2 + 3);
//printMax(100, 200);
//printMax(oldQuantity * 1.5, quantity * 2);

// ето така 
function printLogo(companyName, companyWebsite) {
    console.log('___________');
    console.log(companyName);
    console.log('___________');
    console.log(companyWebsite);
}
printLogo('Telerik', 'www.telerik.com'); // ОТ ТУК СИ ИЗВИКВАМЕ ФУНКЦИЯТА И  ПОДАВАМЕ ПАРАМЕТРИТЕ ЗА ФУНКЦИЯТА, 1-ВИ ПАРАМЕТЪР ЗА ИМЕТО НА КОМПАНИЯТА
// 2-РИ ЗА САЙТА НА КОМПАНИЯТА И ОТИВАТ ГОРЕ В САМАТА ФУНКЦИЯТА!!!!! АК ОЯ ИЗВИКАМЕ НО БЕЗ ДА И СЛОЖИМ ПАРАМЕТРИ, ТЕ ЩЕ БЪДАТ
// UNDEFINED И НЯМА ДА ИЗПРИНТИ  companyName И companyWebsite ПОНЕЖЕ СА UNDEFINED!!!


// ДРУГ ПРИМЕР:
//function printMax(x, y) {  
//  var max = x;
//  if (max < y) {
//   max = y;
//  }
//  console.log(`Maximal number: ${max}`);  // ето така с доларчето и {} можем да си присвояваме на дадено място определена стойност или променлива!
//}


// Example: Printing the Triangle:
// function pringTriangle(n) {
//  var line;
//  n = +n;

//  for (line = 1; line <= n; line += 1) {
//    printLine(1, line);
//  }

//  for (line = n-1; line >= 1; line -= 1) {
//   printLine(1, line);
//  }

//function printLine(start, end) {
//  var line = "",
//      i;
//  start = +start; end = +end;
//  for (i = start; i <= end; i += 1){
//    line += " " + i;
//  }
//  console.log(line);
//}

// 07. The arguments Object- ТОВА Е ОБЕКТ, КОЙТО ВСЯКА ФУНКЦИЯ ИМА! ОБЕКТ КОЙТО СЪДЪРЖА ВСИЧКИ АРГУМЕНТИ(параметри) ПОДАДЕНИ НА ФУНКЦИЯТА!!!
// НЕЗАВИСИМО ДАЛИ ТЕЗИ АРГУМЕНТИ СА БИЛИ ПРИЕТИ. ТАКА МОЖЕМ ДА ВЗЕМЕМ ВСИЧКИ ПАРАМЕТРИ, КОЙТО СА БИЛИ ПОДАДЕНИ НА ФУНКЦИЯТА!!!!!
// ЧРЕЗ ОБЕКТА - arguments (КЛЮЧОВАТА ДУМИЧКА arguments)!!!! ОК Е ДА СЕ ИЗПОЛЗВА, НО САМО ЗА ЧЕТЕНЕ, НЕ Е ДОБРА ИДЕЯ ДА ГО ПРОМЕНЯМЕ
// ПО НЯКАКЪВ НАЧИН!!! АКО ИСКАМЕ ДА ГИ ПОЛЗВАМЕ ПО ДРУГ НАЧИН(ДА ИМ ПРОМЕНЯМЕ СТОЙНОСТИТЕ), ПЪРВО ГИ ПРИСВОЯВАМЕ НА МАСИВ И СЛЕД ТОВА 
// Е ОК МОЖЕМ ДА СИ ПОЛЗВАМЕ ТОЗИ МАСИВ, КАКТО СИ ИСКАМЕ, КАТО ДОЛНИЯ ПРИМЕР СЪС SLICE.APPLY(arguments).... 
// ПОЛЗВА СЕ НАЙ-ВЕЧЕ ЗА ЧЕТЕНЕ НА ДОПЪЛНИТЕЛНИТЕ ПАРАМЕТРИ, КОЙТО НЕ СТЕ ДЕКЛАРИРАЛИ, ЧЕ ФУНКЦИЯТА ТРЯБВА ДА ПРИЕМЕ!
// Access to all function parameters

//Every function in JavaScript has an implicit parameter arguments
//It holds information about the function and all the parameters passed to the function
//No need to be explicitly declared
//It exists in every function

// function printArguments() {
// var i;
//  for(i in arguments) {
//    console.log(arguments[i]);
//  }
//}
//printArguments(1, 2, 3, 4); //1, 2, 3, 4

//ПРИМЕР : !!!!!!!!!!!!!
function printLogo(companyName, companyWebsite) {
    console.log(arguments[0]);  // взима първият параметър - 'Telerik'
    console.log(arguments[1]);  // взима втория параметър - 'www.telerik.com'
    console.log(arguments[2]);  // взима третия параметър - 23
    console.log(arguments[3]);  // взима четвъртия параметър - 1334
    console.log(arguments[4]);  // взима петия параметър - 'ГРЕДА'

    console.log('___________');
    console.log(companyName);  // тук си взимаме от функцията параметъра чрез неговото име 
    console.log('___________');
    console.log(companyWebsite);  // тук също
}
printLogo('Telerik', 'www.telerik.com', 23, 1334, 'ГРЕДА');  // ВЪПРЕКИ ЧЕ ПОДАВАМЕ ПОВЕЧЕ ПАРАМЕТЪРА ОТКОЛКОТО ФУНКЦИЯТА ПРИЕМА, ТЕ НЕ СЕ ГУБЯТ 
                                                    // И МОГЪТ ДА БЪДАТ ИЗВИКАНИ С ОБЕКТА arguments И СЪОТВЕТНИЯ ИНДЕКС ИЛИ ВСИЧКИ СЪС ФОР ИН КАТО ГОРНИЯ ПРИМЕР!!!

//ДОЛЕН ПРИМЕР:
//The arguments Object
//The arguments object is not an array- НЕ Е МАСИВ! ЛИПСВА МУ ГОЛЯМА ЧСТ ОТ ФУНКЦИОНАЛНОСТТА НА МАСИВИТЕ!!
//It just has some of the array functionality - ИМА ПОДОБНА ФУНКЦИОНАЛСНОТС
//If in need to iterate it, better parse it to an array: НЕ Е ДОБРА ИДЕЯ ДА СЕ ПРОМЕНЯТ СТОЙНОСТИТЕ НА ОБЕКТА, ЗАТОВА ГИ ПРИСВОЯВАМЕ НА МАСИВ И ВЕЧЕ Е ОК ДА СИ ПОЛЗВАМЕ ТОЗИ МАССИВ!!!!
// function printArguments() {
//  var i,
//      args;

//  args = [].slice.apply(arguments);  // ЕТО ТАКА СИ ГИ КОПИРАМЕ И ПРИСВОЯВАМЕ НА МАСИВ
//  for(i in args) {
//    console.log(args[i]);
//  }
//}

//printArguments(1, 2, 3, 4); //1, 2, 3, 4


// 08. ВРЪЩАНЕ НА СТОЙНОСТ ЧРЕЗ КЛЮЧВОАТА ДУМИЧКА RETURN.
//Defining Functions That Return a Value
//Functions can return any type of data:
//Number, String, Object, etc...
//Use return keyword to return a result

//function multiply (firstNum, secondNum) {
//    return firstNum * secondNum;
//}


//function sum (numbers) {
//  var sum = 0, number;
//  for(number of numbers){
//    sum += number;
//  }
//  return sum;
//}

//The return statement:
//Immediately terminates function's execution
//Returns specified expression to the caller
//To terminate function execution, use just: // ЗА ДА ПРЕКРАТИМ ФУНКЦИЯТА МОЖЕ И С РЕТЪРН, СЛЕД ИЗПЪЛНЕНИЕТО НА РЕТЪРН-А, АКО ИМА ДРУГ КОД ПОД НЕГО ПРОСТО НЯМА ДА СЕ ИЗПЪЛНИ ПОНЕЖЕ СМЕ ВЪРНАЛИ РЕЗУЛТАТ И СМЕ ПРЕКРАТИЛИ ФУНКЦИЯТА!
// return;
//Return can be used several times in a function body
//To return a different value in different cases// ВЪВ ИФ ЕЛСЕ КОНСТРУЪКЦИИ НАПРИМЕР , МОЖЕМ ДА СЛОЖИМ  НЯКОЛКО РЕТЪРНА КОИТО ВРЪЩАТ РАЗЛИЧНИ НЕЩА РАЗБИРА СЕ !

//ПРИМЕРЧЕ:
//Calculate the sum of all even numbers in an array
// function sum(numbers) {
//  var number,
//    sum = 0;

//  for (number of numbers) {
//    if (0 === number % 2) {
//      sum += number;
//    }
//  }
//  return sum;
//}


// 09. Function Scope- ЖИВОТЪТ, КОЙТО ИМАТ ДАДЕНИ ПРОМЕНЛИВИ И ФУНКЦИИ ВЪВ ВАШАТА ПРОГРАМА! ОТ КЪДЕ ИМАМЕ ДОСТЪП ДО НАШИТЕ ПРОМЕНЛИВИ
// И ФУНКЦИИ!
// АКО ПРОМЕНЛИВА Е ДЕКЛАРИРАНА БЕЗ ключвоата думичка var ТЯ ВЛИЗА В global scope, ТОВА НЕ ВАЖИ ЗА ТЕЗИ, КОГАТО ИЗБРОЯВАМЕ СЪС ЗАПЕТАЙКИ
// ПОНЕЖЕ ПРЕДИ ТОВА СМЕ СИ НАПИСАЛИ ОБИКНОВЕННО ПРИ ПЪРВАТА ДЕКЛАРИРАНА ПРОМЕНЛИВА VAR и надоло СЪС ЗАПЕТАЙКИ, САМО СИ ИЗБРОЯВАМЕ СЛЕДВАЩИТЕ ПРОМЕНЛИВИ,
// КОИТО ЩЕ НИ ТРЯБВА: ТЕ ВЕЧЕ СА ВАРОСАНИ !
//Scope of variables and functions
//Every variable has its scope of usage
//A scope defines where the variable is accessible
//Generally there are local and global scope !!!!


//var arr = [1, 2, 3, 4, 5, 6, 7];  - arr is in the global scope (it is accessible from anywhere). В ГЛОБАЛЯНИ СКОУП Е МОЖЕ ОТ ВСЯКЪДЕ ДА СЕ ПОЛЗВА
                                    //- МОЖЕ ДА СЕ ПОЛЗВА И ЗА ДРУГИ ФУНКЦИИ!
//function countOccurences (value) {
//  var item,
//    count = 0;                        count is declared inside countOccurences and it can be used only inside it, local scope(function scope). ДОКАТО ТАЗИ ПРОМЕНЛИВА Е 
//  for (item of arr) {                     //ДЕКЛАРИРАНА ВЪВ ФУНКЦИЯТА countOccurences И ЗАТОВА МОЖЕ ДА СЕ ПОЛЗВА САМО В РАМКИТЕ НА ТАЗИ ФУНКЦИЯ!
//    if (item === value) {
//      count++;
//   }
//  }
//  return count;
//}

// 10. Function Overloading-ВЪЗМОЖНОСТТА ДА ИМАМЕ МНОГО ФУНКЦИИ С 1 И СЪЩО ИМЕ!
//Many functions with the same name
//Function Overloading
//JavaScript does not support function overloading !
//i.e. functions with the same name hide each other !
// function print(number) {
//  console.log(`Number: ${number}`);
//}

//function print(number, text) {
//  console.log(`Number: ${number}\nText: ${text}`);
//}

//print(2);
//prints:
//Number: 2
//Text: undefined`
// ПРИЕМА СЕ ПОСЛЕДНАТА ФУНКЦИЯ, КОЯТО СМЕ ДЕФИНИРАЛИ!


//Function overloading in JavaScript must be faked
//i.e. make it look like overloading
//Many ways of fake function overloading exist
//Different number of parameters
//Different type of parameters
//Options parameter (preferred)

//Function Overloading: Different Number of Parameters // АКО ВИ СЕ НАЛОЖИ, БЪРКАТЕ СЕРИОЗНО НЯКЪДЕ!!!
//Different number of parameters:
//A simple switch by the length of the arguments
// function printText (number, text) {
//  switch (arguments.length) {
//   case 1 : console.log (`Number: ${number}`);
//      break;
//    case 2 :
//      console.log (`Number: ${number}`);
//      console.log (`Text: ${text}`);
//      break;            
//  }
//}

//printText (5); //logs 5
//printText (5, "Lorem Ipsum"); //logs 5 and Lorem Ipsum

//Function Overloading with Default Parameters // АКО ВИ СЕ НАЛОЖИ, БЪРКАТЕ СЕРИОЗНО НЯКЪДЕ!!!
//Default parameters are checked in the function body
//If the parameter is not present - assign a value
 //only the str parameter is required
//function getRandomValue(str, start, end){
//  start = start || 0;
//  end = end || str.length;
  //function code


//  Function Overloading: Options parameter // АКО ВИ СЕ НАЛОЖИ, БЪРКАТЕ СЕРИОЗНО НЯКЪДЕ!!!
//To create functions with options parameter
//Create the function take a single parameter
//Each parameter is a property of the options parameter
//Example:
// function getRandomValue(opt) {
//  var min = +opt.min || Number.MIN_VALUE;
//  var max = +opt.max || Number.MAX_VALUE;

//  return (Math.random() * (max - min + 1) + min) | 0;
//}

//console.log(getRandomValue({min:0, max: 15}));