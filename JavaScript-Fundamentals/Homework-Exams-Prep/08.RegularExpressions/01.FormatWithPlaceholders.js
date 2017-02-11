function solve(args) {
String.prototype.format = function(options) {
    var prop,
        result = this;
    for (prop in options) {
        result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop]);
    }
    return result;
};

var options = JSON.parse(args[0]);
    result = args[1].format(options);

console.log(result);
}

// втори начин
function solve(args) {
    var str = JSON.parse(args[0]);
    var result = args[1];
    
		for (var property in str) {
var regex = new RegExp("#\{"+property+"\}", "g");result = result.replace(regex, str[property]);
}
return result;}