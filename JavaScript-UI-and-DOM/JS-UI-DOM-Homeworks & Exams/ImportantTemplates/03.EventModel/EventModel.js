// 01. JavaScript Event Model
//The DOM event model provides a way for the user to interact with the browser environment
//The DOM event model consists of events and event listeners attached to the DOM objects

//  02.Event Types
// DOM provides a set of common event types that are used in 99% of the time
// Mouse events
// Touch events
// Form events
// Keyboard events
// DOM events
// Full list of all DOM event types:
// http://www.w3.org/TR/DOM-Level-3-Events/#event-types-list
// You could also defined Custom Event Types

// 03.Common Event Types

// Mouse Events 	Keyboard Events
// click	        keypress
// hover	        keydown
// mouseup	        keyup
// mousedown
// mouseover
// mouseout

// UI Events	    Focus Events
// load-когато се зареди целият документ тогава изпълни функцията	            blur
// abort	        focus
// select	        focusin
// resize	        focusout
// change
// input

//  Touch Events
// tap
// touchstart
// touchend
// touchmove
// touchcancel
// touchenter
// touchleave

// 04. Event Handlers
// The developer could register an event handler/listener for a specific event type and DOM element
// The registration can be performed with:
// HTML Attributes
// Using DOM element properties
// Using DOM event handler  

// As HTML Attribute
// Event handlers can be attached by simply setting a value to the handler attribute
// This value is pure JavaScript and is not always a function
// НЕ Е ДОБРА ПРАКТИКА!
//  <button onclick="buttonClickFunction()">Click Me</button>
function buttonClickFunction() {
    console.log("You click the Button");
}

// 05. Using DOM Element Properties
// Use standard DOM events on certain DOM element and assign a reference to a function
// Can be anonymous
// HTML
// ПО-ДОБЪР ВАРИАНТ! ДОЛНИЯТ Е ПО-ДОБЪР, А С ДЖЕЙКУЕРИ Е НАЙ-ДОБЪР!
//<button id="click-button">Click me</button>
//JavaScript
var button = document.getElementById("click-button");
button.onclick = function onButtonClick() {
    console.log("You clicked the button");
}

// !!!!!!!! НАЙ-ДОБРИЯТ ВАРИАНТ ЗА ЗАКАЧАНЕ НА event handler/listener, БЕЗ ДЖЕЙКУЕРИ Е ТОЗИ ! 
// 06.Using DOM Event Listeners
// НАЙ-ДОБРИЯТ ВАРИАНТ ЗА ЗАКАЧАНЕ, БЕЗ ДЖЕЙКУЕРИ Е ТОЗИ ! 
// The standard way for attaching event handlers to DOM
// The Basic Syntax is:
domElement.addEventListener(eventType,
    eventHandler,
    isCaptureEvent)
//Example:
var button = document.getElementById("click-button");
button.addEventListener("click", function () {
    console.log("You clicked me");
}, false);

// АКО ИСКАМЕ ДА СИ ПРЕИЗПОЛЗВАМЕ ФУНКЦИИТЕ,става малко мазало така, но..ИЛИ ПРОСТО ДА СИ НАПРАВИМ КОДА ПО ЧЕТИМ!!!!СИ ПРАВИМ ФУНКЦИЯТА, ОТДЕЛНО И САМО Я ПОДАВАМЕ ПОСЛЕ ВЪТРЕ!!
var button = document.getElementById("click-button");
var input = document.getElementById("input-ne6tosi");
button.addEventListener("click", doSomething, false);
input.addEventListener("input", doSomething, false);// второ измислено..

function doSomething(ev) {     // ev ot event, но може да е всичко... бам извиква я първо за пърия после за втория...
    console.log("type: " + ev.type);  // ще ни покаже какъв е типа и какъв точно евента, 
    console.log(ev); // ще ни изпринти самият евент
    //ТОЗИ EV В МОМЕНТА ИМА ВСИЧКИТЕ ПРОПЪТРТИТА НА САМИЯТ ЕЛЕМЕНТ И МОЖЕМ ДА СИ ГО ПОЛЗВАМЕ, КАКТ ИСКАМЕ 
    // долния става за пример и на следващата точкка 07.
    // ако искаме да сетнем или нещо др текста от инпут поле, например, за да не повтаряме document.getElementById... i tn..
    document.getElementById("text").innerText = ev.target.value; // ето така може и мн други варианти...
}

// 07. Event Object
// The event handlers have access to the event object passed as function parameter
// The event object contains information about:
// The type of the event
// The target of the event
// The key that was pressed when a keyboard event was fired
// The mouse button that was pressed when a mouse event was fired
// The position of the mouse on the screen

//The event object is accessible as the only argument of the function handler
function onButtonClick(event) {
    console.log(event.target);
    console.log(event.type);
    console.log(event.clientX, event.clientY);
}
button.addEventListener("click", onButtonClick, false);
// Yet, there is IE - it does not pass event object
// Keeps the event object in window.event
// Fortunately there is a simple fix
function onButtonClick(event) {
    if (!event) event = window.event;
    // Your code…
}

// 08. Cross-browser Compatibility
// addEventListener() is n0t supported everywhere
// Older versions of IE have their own method for registering event handlers
domElement.attachEvent('onclick', eventHander);
// Yet, you can use feature detection
// Up to IE8
//   if (document.attachEvent){ 
//     domElement.attachEvent(…);}
//   // IE 9, IE 10, Firefox, Chrome, Opera, Safari
//   else if (document.addEventListener) {   
//     domElement.addEventListener(…); }
//   // Reeeally old browsers
//   else { domElement["on" + eventType] = handler; }      

// This can be wrapped in a method:
// Create a function with three parameters
// Target element
// Event type
// Event handler
// Use the method your browser supports

// 09.The Event Chain
// When the user clicks on an HTML element, the event is also fired on all of its parents
//  <html>        //Fired
//   <body>         // Fired
//     <div>          // Fired
//       <button>       // Fired
//         Click Me
//       </button> 
//     </div>          // Clicking on the button
//   </body>
// </html>
// The button is still the target, but the click event is fired on all of its parents
// An event is fired on all elements in the chain

// 10.Two Types of Event Chains
// There are two types of event chains
// Capturing and Bubbling
// Bubbling handlers bubble up the chain
// The first executed handler is on the target
// Then its parent's, and its parent's, etc…
// Capturing handlers go down the chain
// The first executed handler is on the parent of all
// The last executed handler is on the target

// 11. Capturing Event Chain
// Capturing goes down the event chain
// The first executed handler is the one of the parent of all
button.addEventListener("click", doSomething, true); // ето така само го слагаме на тру и вече е на обратно
// HTML     //1
// Body     //2
// DIV      //3
// BUTTON   //4

//User clicks the Button

// Bubbling Event Chaing
// Bubbling bubbles up the event chain
// The first executed handler is the one on the target
button.addEventListener("click", doSomething, false); // по дефоут е фолс, а ето така можем и да си го напише за да се знае и да е по ясно или да не го пишем, както искаме ..
// HTML     //4 
// Body     //3
// DIV      //2
// BUTTON   //1

// User clicks the Button

// 12. Custom Events
//To create custom events use the CustomEvent() constructor
var event = new CustomEvent(eventType);
//Create custom event tripleclick
var event = new CustomEvent("tripleClick");
//Get body element to attach the custom event to and use addEventListener
var body = document.getElementsByTagName("body")[0];
body.addEventListener("tripleClick", function () {
    alert("You click three times");
}, false);