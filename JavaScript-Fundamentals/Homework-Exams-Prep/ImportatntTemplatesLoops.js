//01. Какво е цикъл. Цъклите са почти същите, като при C#

//What is a Loop?
//Loops in JavaScript
//while loop
//do … while loop
//for loops
//break, continue
//Nested loops

// 02. While loop
//let counter = 0;
//while (counter < 10) {
//    console.log('Number : ' + counter);
//    counter += 1;
// }

//Using break Operator
//break operator exits the inner-most loop
// let n = 10,
//    fact = 1,
//    factStr = 'n! = ';

//while (1) { //infinite loop
//  if (n === 1) {
//      break;
//  }

//  factStr += n + '*'
//  fact *= n;
//  n -= 1;
//}    

//factStr += '1 = ' + fact;
//console.log(factStr);

// 03. For Loop The Initialization Expression
//for (initialization; test; update) {
//    statements;
//}

//for (let number = 0; number < 10; number += 1) {    
    // Can use number here
//}

//for loops support multiple update statements, separated by the , (comma) operator
//Complex for Loop – Example
//Complex for loops could have several counter variables:
// for (let i = 1, sum = 1, N = 128; i <= N; i *= 2, sum += i) {
//    console.log('i=' + i + ', sum=' +sum);
//}

// 04. For-in Loop- обикаля пропъртитата на даден обект или масиви. Но 2-та основни проблема с този цикъл са(трябва да знаем че този цикъл
// съществува и никога да не го ползваме!): 1-во защото итерира само в/у енъмеръбъл пропъртитата на даден обект и 2-ро че фор-ина
// не ви гарантира реда по, който тия пропъртита(или масив) ще бъдат обходени!
//for-in loop iterates over the properties of an object
//When the object is array, nodeList or liveNodeList, for-in iterates over their elements
//When the object is not a collection, for-in iterates over its properties
// propName is a string - the name of the property
//for (const propName in document) { 
//    console.log(document[propName]);
//}
//Iterating over the elements of an array
// const arr = [1, 2, 3, 4, 5, 6];
//for (const index in arr) {
//    console.log(arr[index]);
//}

// 05. For-of Loop - използва се само за итериране на мисиви! Той няма недостатъците на фор-ин цикъла!
//for-of loop iterates over the elements in an array
//Can be used only on arrays, or array-like objects
//i.e. the arguments object
// const arr = ['One', 'Two', 'Three', 'Four'];

//for(const n of arr) { 
//  console.log(n); 
//}
//The for-of loop is part of the ECMAScript 6 standard
//Supported in all modern browsers