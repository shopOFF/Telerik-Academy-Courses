/* globals document, window, console */

function solve() {
    return function (selector, initialSuggestions) {
        var root = document.querySelector(selector);
        element.className += " autocomplete";
        // adding elements
        var addingElementsPart = document.createElement('div');
        addingElementsPart.className += " add-controls";
        var label = document.createElement('label');
        label.setAttribute('for', 'the-input');
        label.innerHTML = 'Enter text';
        var input = document.createElement('input');
        input.className += ' tb-pattern';
        var button = document.createElement('button');
        button.className += ' btn-add';
        button.innerHTML = 'Add';
        // var ul = document.createElement('ul');
        // ul.className += ' suggestions-list';

        addingElementsPart.appendChild(label);
        addingElementsPart.appendChild(input);
        addingElementsPart.appendChild(button);
        addingElementsPart.appendChild(ul);

        root.appendChild(addingElementsPart);

        // results
        var resultsPart = document.createElement('div');
    resultsPart.className += " result-controls";
    
    var itemsList = document.createElement('ul');
    itemsList.className += ' suggestions-list';
    
    resultsPart.appendChild(itemsList);
    element.appendChild(resultsPart);
    //-------------------------
   //var resultsList = document.getElementsByClassName('items-list')[0];
    button.addEventListener('click', function(){
     
      itemsList.appendChild(createNewListItem());
      // input.value = '';
    });
    
    };
}

module.exports = solve;