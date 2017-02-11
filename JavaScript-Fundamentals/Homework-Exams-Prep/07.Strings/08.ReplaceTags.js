function solve(args) {
    var regExTag = new RegExp('<a href="(.*?)">(.*?)</a>', "g");
   
    var newText = args[0].replace(regExTag, function (none, href, content) {
        
            return '[' + content + '](' + href + ')';      
    });

    console.log(newText);
}

// втори начин за 40/100
function solve(args) {
    let matchAnchorTags = /<a href=".*?">.*?<\/a>/ig,
        matchExtractLable = /<a href="(.*?)">(.*?)<\/a>/,
        matches = [],
        replacementStrings = [];

    matches =
        args[0]
            .match(matchAnchorTags);

    replacementStrings =
        matches
            .map(m => {
                var match = m.match(matchExtractLable);
                return '[' + match[2] + '](' + match[1] + ')';
            });

    let len = matches.length;
    for (let i = 0; i < len; i += 1) {
        args[0] = args[0].replace(matches[i], replacementStrings[i]);
    }

    console.log(args[0]);
}

let test1 = [
    '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>'
];

solve(test1);

// трети начин 
function solve8_2(args) {
    var text = args[0],
        result = "", i, tag, endTag, endUrl, tagDesc;

    while (text.length > 0) {
        i = text.indexOf('<a href="');
        if (i > -1) {
            result += text.substring(0, i);
            endTag = text.indexOf('">', i);
            tag = text.substring(i + 9, endTag);
            endUrl = text.indexOf('</a>', endTag + 1);
            tagDesc = text.substring(endTag + 2, endUrl);

            result += '[' + tagDesc + '](' + tag + ')';

            text = text.substring(endUrl + 4);
        }
        else {
            result += text;
            text = "";
        }
    }
	console.log(result);
}