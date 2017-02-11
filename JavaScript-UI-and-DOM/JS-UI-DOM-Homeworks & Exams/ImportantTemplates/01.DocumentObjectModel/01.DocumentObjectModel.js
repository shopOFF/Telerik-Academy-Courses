// 01. Document Object Model (DOM)
// The way to access HTML with JavaScript

// 02. The Document Object Model is an API for HTML and XML documents
// Provides a structural representation of the document
// Developers can modify the content and UI of a web page

// 03. The DOM consists of objects to manipulate a web page
//All the properties, methods and events are organized into objects
//Those objects are accessible through programming languages and scripts
//How to use the DOM of an HTML page?
//Write JavaScript to interact with the DOM
//JavaScript uses the DOM API (native implementation for each browser)

// 04. The DOM API consists of objects and methods to interact with the HTML page
// API - Application Programming Interface
//Can add or remove HTML elements
//Can apply styles dynamically
//Can add and remove HTML attributes
//DOM introduces objects that represent HTML elements and their properties
//document.documentElement is <html>
//document.body is the body of the page, where the content of the page is
//Each of the HTML elements has corresponding DOM object type
//HTMLLIElement represents <li>
//HTMLAudioElement represents <audio>
//Each of these objects has the appropriate properties
//HTMLAnchorElement has href property
//HTMLImageElement has src property
//The document object is a special object
//It represents the entry point for the DOM API

// 05.HTML Elements
//HTML elements have properties that match attributes
//id, className, draggable, style, onclick, etc…
//Different HTML elements have their specific attributes
//HTMLImageElement has property src
//HTMLInputElement has property value
//HTMLAnchorElement has property href
//HTML elements have properties for content
//innerHTML
//Returns as a string the content of the element, without the element
//outerHTML
//Returns as a string the content of the element, with the element
//innerText / textContent
//Returns as a string the text content of the element, without the tags

// 06. Selecting HTML Elements
//HTML elements can be found and cached into variables using the DOM API
//Select single element
//var header = document.getElementById('header');
//var nav = document.querySelector('#main-nav');

//Select a collection of elements
//var inputs = document.getElementsByTagName('li');
//var radiosGroup = document.getElementsByName('genders');
//var header = document.querySelectorAll('#main-nav li');

//Using predefined collections of elements
//var links = document.links;
//var forms = document.forms;

// 07. Using getElementsBy
//Methods
//DOM API contains methods for selecting elements based on some characteristic
//getElementById(id):
//Returns a single element or null
//var header = document.getElementById('header');

//getElementsByClassName(className):
//Returns a collection of elements
//var posts = document.getElementsByClassName('post-item');

//getElementsByTagName(tagName);
//Returns a collection of elements
//var sidebars = document.getElementsByTagName('sidebar');

//getElementsByName(name);
//Returns a collection of elements
//var gendersGroup = document.getElementsByName('genders');

// 08. Using querySelector Methods
//The DOM API has methods that use CSS-like selectors to find and select HTML elements
//querySelector(selector) returns the left most element that matches the selector
//querySelectorAll(selector) returns a collection of all elements that match the selector
//Both methods take as a string parameter
//The CSS selector of the element
// АКО ИСКАМЕ ДА ТЪРСИМ В ПО-ГОЛЯМА ДЪЛБОЧИНА, И ТО САМО НА 1 РЕД, ВМЕСТО ДА ВЗЕМЕМ ЕДИН ЕЛЕМЕНТ ПОСЛЕ В ТОЗИ ЕЛЕМЕНТ В НЕГОВИТЕ ДЕЦА ДА ТЪРСИМ.... И ТН ...
//the element with id="header"
//   var header = document.querySelector('#header');

//li elements contained in element with id=main-nav
//   var navItems = document.querySelectorAll('#main-nav li');  // ТУКА МОЖЕ И МН ПО ГОЛЯМА ДЪЛБОЧИНА ДА СИ НАПРАВИМЕ
// НАПРИМЕР ВЗЕМИ МИ ВСИЧКИ ЛИ-ТА В ИД-ТО #main-nav И ТАКА МОЖЕМ ДА ТЪРСИМ НА 1 РЕД МНОГО ЛЕСНО И БЪРЗО!

// 09. Selecting Nested Elements
//The DOM API can be used to select elements that are inside other elements
//Select all divs that are inside an element with id "wrapper"
// var wrapper = document.getElementById('wrapper');
// returns all div elements inside the element with id "wrapper"
//var divsInWrapper = wrapper.getElementsByTagName('div');

//All methods can be used on HTML elements
//Except getElementById

// 10. NodeLists
//A NodeList is a collection returned by the DOM selector methods:
//getElementsByTagName(tagName)
//getElementsByName(name)
//getElementsByClassName(className)
//querySelectorAll(selector)
// var divs = document.getElementsByTagName('div'),
//    queryDivs = document.querySelectorAll('div');
//for(var i = 0, length = divs.length; i < length; i += 1){
// do stuff with divs[i]…
//}

//NodeList looks like an array, but is not
//It's an object with properties similar to array
//Has length and indexer
//Traversing an array with for-in loop works unexpected:
// console.log(Array.isArray(divs)); // false
//for (var i in divs) {
//   console.log('divs[' + i + '] = ' + divs[i]);
//}

// 11. Static NodeList and Live NodeList
//What is that? What is the difference?

// There are two kinds of NodeLists !!!!!!!!!!!!!

//getElementsBy methods return a LiveNodeList !!!!!!!!!!!!!!!!!!!!!!!
//Live lists keep track of the selected elements
//Even when changes are made to the DOM
// ЪПДЕЙТВА СЕ LiveNodeList-А АВТОМАТИЧНО, АКО СТАНЕ НЯКАКВА ПРОМЯНА!!!!СЛЕДИ ЗА ПРОМЕНИ!И АКО ПРОМЕНИМ НЕЩО ПО 
//ТЕЗИ ЕЛЕМЕНТИ ОТ LiveNodeList-А ЩЕ СЕ ОТРАЗИ И В САМИЯ LiveNodeList!!!

//querySelectorAll returns a StaticNodeList !!!!!!!!!!!!!!!!!!!!!!!!!!!
//While static list contain the elements as they were at the execution of the method
//НЕ ЪПДЕЙТВА StaticNodeList-А ВЗИМА ЕЛЕМЕНТИТЕ ТАКИВА КАКВИТО СА БИЛИ В МОМЕНТА НА ИЗВИКВАНЕ НА МЕТОДА И,
//АКО ПРОМЕНИМ НЕЩО ПО ЕЛЕМЕНТИ ОТ StaticNodeList-А  ТО НЯМА ДА СЕ ОТРАЗИ В StaticNodeList-А!!

//Keep in mind that a LiveNodeList is slower than a regular array
//Need to cache its length for better performance
//Best converted to an array when iterated over multiple times

// ДА ИНСТАНЦИРАТЕ LiveNodeList Е ПО БЪРЗО ОТКОЛКОТО ДА ИНСТАНЦИРАТЕ StaticNodeList! КАТО ИНСТАНЦИРАТЕ LiveNodeList , ТОЙ НЕ ВИ
// ЗАРЕЖДА ЕЛЕМЕНТИТЕ ВЕДНАГА, А КОГАТО ГИ ПОИСКАТЕ! ТОВА СЕ НАРИЧА LAZY LOADING  В ПРОГРАМИРАНЕТО И Е МНОГО МОЩТНА ТЕХНИКА
// В ПОГРАМИРАНЕТО ЗА НЯКОИ НЕЩА, ЗАТОВА ВИ ДАВА ПО-БЪРЗО ИНСТАНЦИРАТЕ, ЗАЩОТО НЕ ВИ ЗАРЕЖДА ВСИЧКО НАПРАВО В КОЛЕКЦИЯТА
// А ЧАКА ДА ГО ПОИСКАТЕ!!!
// StaticNodeList ОТ СВОЯ СТРАНА, МИНАВАТ ЗАРЕЖДАТ ВИ ВСИЧКИТЕ ОБЕКТИ В КОЛЕКЦИЯТА И ВИ ГИ ВРЪЩАТ, ЗАТОВА Е ПО-БАВНО.
// ОТ ДРУГА СТРАНА АКО ЩЕ ПРАВИТЕ САМО 1 ИТЕРАЦИЯ ВИ Е ПО-БЪРОЗ ДА ИЗПОЛЗВАТЕ StaticNodeList.ЗАЩОТО ВС Е ВЕЧЕ ЗАРЕДЕНО.
// АКО ЩЕ ЩИ ОБХОЖДАТЕ МНОГО ПЪТИ  Е ДОБРЕ ДА СИ КЕШИРАМЕ ДЪЛЖИНАТА
// ИЛИ НАЙ-ДОБРЕ ДА СИ ГИ КОНВЕРТИРАМЕ В МАСИВ!!! ЗАЩОТО МАСИВИТЕ СЕ ОБИКАЛЯТ ПО-БЪРЗО(РАБОТИ СЕ ПО-БЪРЗО С ТЯХ)!!!!

//inputs.length // 12 примерно
//for (var i = 0; length = inputs.length; i += 1) {  // ето така си кешираме дължината( length = inputs.length), за да си я 
    // достъпваме само веднъж а не при всяко завъртане, но ако правим промени по DOM това не е добре защото дължината ще се промени и тн.. трябва дасе внимава!!

//}


// 12. !!!!!!!!!!!!!! КАК ДА КОНВЕРТИРАМЕ NodeList В МАСИВ, ЗА ДА ИЗПОЛЗВАМЕ ПЪЛНАТА ФУНЦКИОНАЛСНОТ НА МАСИВИТЕ(ТЕХНИТЕ МЕТОДИ)
// (ПОНЕЖЕ ТЕЗИ NodeList ИМАТ САМО БАЗОВИТЕ НЕЩА(ДЪЛЖИНА И ИНДЕКСАТОР))
let divs = document.getElementsByTagName('div'); // взима ни всички див тагове(div-ове) и ги слага в колекция (NodeList)
// но ние искаме дълната функционалснот на масивите, зтова ще си конвертираме NodeList-а в масивите..
[].forEach.call(divs, el => console.log(el));  // ето така прилагаме forEach метода на divs
// празен масив, точка и си избираме метода, който искаме да използваме(в случая forEach) и сега на forEach точка call 
// (всяка функция си има .call), като  call е също функция, на която подаваме в/у какво да се извика(NodeList-а ни divs 
// и на forEach-а му подаваме и още една функция, която да се изпълни в/у всеки елемент(el => console.log(el))).

// втори пример-как да си го направим на масив, просто да си го конвертираме...и после да си ползваме директно масива, за каквото ни трябва 
let divsArray = [].slice.call(divs); // ето така !!!!!!!!
//!!!!!!!!!!!!!!!!!!!!!!

// трери пример... просто пример 
//[].map.call(divs, el => и тука да му кажем какво да се случи примерно...);
//[].map.call(divs);// май може и само така нз...