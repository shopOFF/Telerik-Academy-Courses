function solve() {
    return function (element, contents) {
        var id = element;
        var len = contents.length;
        if (element instanceof HTMLElement) {
            id = element.id;
        }
        if (!(typeof(element) === 'string' || (element instanceof HTMLElement))) {
            throw new Error('The first parameter must be string or object');
        }
        var domElement = document.getElementById(id);
        if (domElement === null) {
            throw new Error('Element with that id doesn\'t exist');
        }
        if (element === null || contents === null) {
            throw Error('You must pass two parameters');
        }
        if (!Array.isArray(contents)) {
            throw Error('The contents must be array');
        }
        for (var i = 0; i < contents.length; i += 1) {
            if (!(typeof contents[i] === 'string' || typeof contents[i] === 'number')) {
                throw Error('All the contents must be either number of string');
            }
        }

        domElement = document.getElementById(id);
        domElement.innerHTML = "";
        var div = document.createElement('div');
        var fragment = document.createDocumentFragment();
        var selectedElement = document.getElementById(id);
        for (var i = 0; i < len; i += 1) {
            var divToAdd = div.cloneNode(true);
            divToAdd.innerHTML = contents[i];
            fragment.appendChild(divToAdd);
        }
        domElement.appendChild(fragment);

    }
}

// vtori variant :
// function solve() {
//   return function(element, contents) {
//       var i,
//           domElement,
//           content,
//           div,
//           currentDiv,
//           len = contents.length;
//           docFragment = document.createDocumentFragment();

//       if (typeof element  !== 'string' && !(element instanceof HTMLElement)) {  //element.nodeType != 1
//         throw new Error();
//       }

//       if (typeof element === 'string') {
//         domElement = document.getElementById(element);
//         if (!domElement) {
//           throw new Error();
//         }
//       } else {
//         domElement = element;
//       }

//       for (i = 0; i < len; i += 1) {
//         content = contents[i];

//         if (typeof content  !== 'string' && typeof content !== 'number') {
//           throw new Error();
//         }
//       }

//       domElement.innerHTML = '';
//       div = document.createElement('div');

//       for (i = 0; i < len; i += 1) {
//           currentDiv = div.cloneNode(true);
//           currentDiv.innerHTML = contents[i];
//           docFragment.appendChild(currentDiv);
//       }

//       domElement.appendChild(docFragment);

//     };
//  }
 
// module.exports = solve();

// // treti na4in :
// function solve() {

//     return function (element, contents) {

//         var after,
//             toAppend = '',
//             len = contents.length,
//             div = document.createElement('div'),
//             divElement,
//             docFragment = document.createDocumentFragment();

//         if (typeof element === 'string') {
//             after = document.getElementById(element);
//         }
//         else if (element instanceof HTMLElement) {
//             after = element;
//         }
//         else {
//             throw Error('no');
//         }

//         if(!contents || contents.some(function (contElement) {
//             return typeof contElement !== 'string' && typeof contElement !== 'number';
//         })){
//             throw Error('no');
//         }

//         after.innerHTML = '';

//         for (var i = 0; i < contents.length; i += 1) {
            
//             divElement = div.cloneNode(true);
//             divElement.innerHTML = contents[i];
//             docFragment.appendChild(divElement);
//         }
//         after.appendChild(docFragment);
//     };
// }