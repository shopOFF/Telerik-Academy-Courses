/* globals $ */

/* 

Create a function that takes an id or DOM element and:

If an id is provided, select the element
Finds all elements with class button or content within the provided element
Change the content of all .button elements with "hide"
When a .button is clicked:
Find the topmost .content element, that is before another .button and:
If the .content is visible:
Hide the .content
Change the content of the .button to "show"
If the .content is hidden:
Show the .content
Change the content of the .button to "hide"
If there isn't a .content element after the clicked .button and before other .button, do nothing
Throws if:
The provided DOM element is non-existant
The id is neither a string nor a DOM element
  

*/

function solve() {
  return function (selector) {

    if (typeof (selector) !== 'string' && !(selector instanceof HTMLElement)) {   // проверяваме дали е различно от id or DOM element, ако е разлино да хвърли грешка
      throw 'Neither a string nor an element';
    }
    if (document.getElementById(selector) === null) {
      throw 'selects nothing';
    }

    var buttons = document.getElementsByClassName('button'),
      content = document.getElementsByClassName('content'),
      i, len;

    for (i = 0, len = buttons.length; i < len; i += 1) {
      buttons[i].innerHTML = 'hide';
      buttons[i].addEventListener('click', function (ev) {
        var clickedButton = ev.target;
        var nextSibling = clickedButton.nextElementSibling;
        var firstContent,
          validFirstContent = false;

        while (nextSibling) {
          if (nextSibling.className === 'content') {
            firstContent = nextSibling;
            nextSibling = nextSibling.nextSibling;
            while (nextSibling) {
              if (nextSibling.className === 'button') {
                validFirstContent = true;
                break;
              }
              nextSibling = nextSibling.nextElementSibling;
            }
            break;
          } else {
            nextSibling = nextSibling.nextElementSibling;
          }
        }

        if (validFirstContent) {
          if (firstContent.style.display === 'none') {
            firstContent.style.display = '';
            clickedButton.innerHTML = 'hide';
          } else {
            firstContent.style.display = 'none';
            clickedButton.innerHTML = 'show';
          }
        }

      });
    }
  };
}

module.exports = solve;

// // втори начин 
// function solve() {
//     return function (selector) {

//         var root,
//             elements,
//             targetButton,
//             content,
//             next,
//             len, i;

//         if (typeof selector !== 'string' && !(selector instanceof HTMLElement)) {
//             throw Error();
//         }
//         root = document.getElementById(selector);

//         if (root === null) {
//             throw Error();
//         }
//         elements = root.childNodes;
//         len = elements.length;

//         for (i = 0; i < len; i += 1) {

//             if (elements[i].className === 'button') {
//                 elements[i].innerHTML = 'hide';
//             }
//         }

//         root.addEventListener('click', function (ev) {

//             targetButton = ev.target;
//             next = targetButton.nextElementSibling;

//             // If something different from a button is clicked
//             if (targetButton.className !== 'button') {
//                 return;
//             }

//             if (next.className === 'content') {
//                 content = next;

//                 // Cycle until next content is with class button
//                 while (next) {
//                     if (next.className === 'button') {

//                         if (content.style.display === 'none') {
//                             content.style.display = '';
//                             targetButton.innerHTML = 'hide';
//                         }
//                         else {
//                             content.style.display = 'none';
//                             targetButton.innerHTML = 'show';
//                         }
//                         break;
//                     }
//                     next = next.nextElementSibling;
//                 }
//             }

//         }, false);
//     };
// }

// // трети начин 
// function solve() {
//     return function (selector) {


//         if (selector === undefined) {
//             throw Error();
//         }

//         if (typeof selector !== 'string') {
//             throw Error();
//         }

//         var elementId = selector;
//         var len;
//         if (selector instanceof HTMLElement) {
//             elementId = selector.id;
//         }
//         var domElement = document.getElementById(elementId);
//         if (domElement === null) {
//             throw Error();
//         }
//         var i = 0;
//         var allWithClassButton = domElement.querySelectorAll('.button');
//         var allWithClassContent = domElement.querySelectorAll('.content');

//         for (var i = 0, len = allWithClassButton.length; i < len; i += 1) {
//             var buttonElement = allWithClassButton[i];
//             buttonElement.innerHTML = "hide";
//         }
//         var lastButton = allWithClassButton[allWithClassButton.length - 1];
//         domElement.addEventListener('click', function (ev) {

//             var contentElement;
//             var next = ev.target.nextElementSibling;

//             while (next) {

//                 if (next.className === 'content') {
//                     break;
//                 }
//                 if (next.className === 'button') {
//                     break;
//                 }
//                 next = next.nextElementSibling;

//             }

//             if (!Object.is(lastButton, ev.target)) {

//                 if (next.className === 'content') {
//                     if (next.style.display == 'none') {
//                         // console.log('tukaaaaa');
//                         ev.target.innerHTML = 'hide';
//                         next.style.display = '';
//                     }
//                     else {
//                         ev.target.innerHTML = "show";
//                         next.style.display = 'none';
//                     }
//                 }
//             }

//         }, false);

//     };
// }