/* globals module */
function solve() {

  function clear(node) {
    while (node.firstChild) {
      node.removeChild(node.firstChild);
    }
  }

  return function (selector, items) {
    // TODO: check selector, check items, check items length
    var root = document.querySelector(selector);
    var fragment = document.createDocumentFragment();

    var imagePreviewer = document.createElement('div');
    imagePreviewer.style.display = 'inline-block';
    imagePreviewer.style.width = '60%';
    imagePreviewer.style.float = 'left';
    imagePreviewer.style.textAlign = 'center';
    var aside = document.createElement('div');
    aside.style.display = 'inline-block';
    aside.style.width = '20%';
    aside.style.textAlign = 'center';

    var selectedParent = document.createElement('div');
    selectedParent.classList.add('image-preview');
    var selectedImageHeader = document.createElement('h3');
    selectedImageHeader.innerText = items[0].title;
    var selectedImage = document.createElement('img');
    selectedImage.src = items[0].url;
    selectedImage.style.width = '70%';

    selectedParent.appendChild(selectedImageHeader);
    selectedParent.appendChild(selectedImage);
    imagePreviewer.appendChild(selectedParent);

    // right side things
    var input = document.createElement('input');
    var inputHeader = document.createElement('h3');
    inputHeader.innerText = 'Filter';
    input.addEventListener('keyup', function (ev) {
      var text = ev.target.value;
      var liChildren = listOfItems.getElementsByTagName('li');
      for (var i = 0, len = liChildren.length; i < len; i += 1) {
        var currentLi = liChildren[i];
        var header = currentLi.firstElementChild.innerText;
        if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
          currentLi.style.display = 'block';
        }
        else {
          currentLi.style.display = 'none';
        }
      }
    }, false);

    var listOfItems = document.createElement('ul');
    listOfItems.style.listStyleType = 'none';
    listOfItems.style.height = '400px';
    listOfItems.style.overflowY = 'scroll';
    listOfItems.addEventListener('click', function (ev) {
      var target = ev.target;
      if (target.tagName === 'IMG') {
        var header = target.previousElementSibling.innerText;
        var src = target.src;
        selectedImageHeader.innerText = header;
        selectedImage.src = src;
      }
    }, false);

    listOfItems.addEventListener('mouseover', function (ev) {
      var target = ev.target;
      if (target.tagName === 'IMG') {
        target.parentElement.style.backgroundColor = 'gray';
        target.parentElement.style.cursor = 'pointer';  // за да окажем на юзъра, че това нещо е кликабъл
      }
    }, false);

    listOfItems.addEventListener('mouseout', function (ev) {
      var target = ev.target;
      if (target.tagName === 'IMG') {
        target.parentElement.style.backgroundColor = '';
      }
    }, false);

    var li = document.createElement('li');
    li.classList.add('image-container');
    var imageHeader = document.createElement('h3');
    var image = document.createElement('img');
    image.style.width = '90%';
    for (var i = 0, len = items.length; i < len; i += 1) {
      var currentItem = items[i];
      var currentLi = li.cloneNode(true);
      var currentImageHeader = imageHeader.cloneNode(true);
      currentImageHeader.innerText = currentItem.title;
      var currentImage = image.cloneNode(true);
      currentImage.src = currentItem.url;

      currentLi.appendChild(currentImageHeader);
      currentLi.appendChild(currentImage);

      listOfItems.appendChild(currentLi);
    }


    aside.appendChild(inputHeader);
    aside.appendChild(input);
    aside.appendChild(listOfItems);

    fragment.appendChild(imagePreviewer);
    fragment.appendChild(aside);

    root.appendChild(fragment);

  };
}

module.exports = solve;