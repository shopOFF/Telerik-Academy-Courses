function solve(params) {
    var text = params[0],
        replaceInText = ' ',
        replaceWith = '&nbsp;',
        occurrencesCounter = 0;

    replacedText = text.split(replaceInText).join(replaceWith);  // ТАКА ЗАМЕНЯМЕ В ТЕКСТА ВСИЧКИ ПРАЗНИ СПЕЙСОВЕ С ИСКАНОТО ОТ НАС  МОЖЕ И С РЕГЕКС!!!
    //The general pattern is
    //str.split(search).join(replacement)
    console.log(replacedText);
}
solve(['This text contains 4 spaces!!']);

//  РЕШЕНИЕ С РЕГЕКС
function solve(args) {
  var output = (args + '').replace(/ /g, '&nbsp;');
  console.log(output);
}