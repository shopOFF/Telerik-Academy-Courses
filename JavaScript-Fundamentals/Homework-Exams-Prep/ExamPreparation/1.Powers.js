// мое решение за 100/100
function solve(params) {
    var nk = params[0].split(' '),  // взимаме си първия ред от инпута и 
        n = +nk[0],                 // си взимаме двете числа от него в (колко числа ще има инпута с числата(дължината му))
        k = +nk[1],                 // различни променливи (колко трансофмации ще има на числата)
        s = params[1].split(' ').map(Number), // взимаме си(втория ред от инпута)числата от масива и пак си ги вкарваме в нов масив, като си ги правим на числа
        result = 0,
        arrayCopy = s.slice();

    for (var j = 0; j < k; j += 1) {

        for (var i = 0; i < n; i += 1) {

            if (i === 0) {  // first elements
                if (s[i] === 0) {
                    arrayCopy[i] = Math.abs(s[i + 1] - s[n - 1]);      // Math.abs(num1 - num2)  - ето така се използва първото число МИНУС второто число, за да им намерим абсолютната им разлика(по голямото -(минус) по малкото) !!!!!!!!!!!!!!
                }                                                               // иначе бъгва , може и плусове и с запетайки, зависи,какво ни трябва точно, а може и без вградена функционалснот да си го изчислим, но е повече играчка(да проверим кое е по-голямо след това да извадим от  по-голямото, 
                else if (s[i] % 2 === 0 && s[i] !== 0) {                    //по-малкото, и тогава намираме абсолютната им разлика)
                    arrayCopy[i] = Math.max(s[i + 1], s[n - 1]);
                }
                else if (s[i] === 1) {
                    arrayCopy[i] = s[i + 1] + s[n - 1];
                }
                else if (s[i] % 2 !== 0 && s[i] !== 1) {

                    arrayCopy[i] = Math.min(s[i + 1], s[n - 1]);
                }
            }

            else if (i === n - 1) {  // last elements
                if (s[i] === 0) {
                    arrayCopy[i] = Math.abs(s[i - 1] - s[0]);
                }
                else if (s[i] % 2 === 0 && s[i] !== 0) {
                    arrayCopy[i] = Math.max(s[i - 1], s[0]);
                }
                else if (s[i] === 1) {
                    arrayCopy[i] = s[i - 1] + s[0];
                }
                else if (s[i] % 2 !== 0 && s[i] !== 1) {
                    arrayCopy[i] = Math.min(s[i - 1], s[0]);
                }
            }
            else {                                      // middle elements
                if (s[i] === 0) {
                    arrayCopy[i] = Math.abs(s[i - 1] - s[i + 1]);
                }
                else if (s[i] % 2 === 0 && s[i] !== 0) {
                    arrayCopy[i] = Math.max(s[i - 1], s[i + 1]);
                }
                else if (s[i] === 1) {
                    arrayCopy[i] = s[i + 1] + s[i - 1];
                }
                else if (s[i] % 2 !== 0 && s[i] !== 1) {
                    arrayCopy[i] = Math.min(s[i - 1], s[i + 1]);
                }
            }
        }
        s.length = 0;  // clear the array
        s = arrayCopy.slice();
    }
    for (var e = 0; e < s.length; e += 1) {
        result += s[e];
    }
    //result = s.reduce(function (a, b) { return a + b; }, 0);  // или това или горното 1 и също правят!
    console.log(result);
}

//Examples
//Input	Output      	Explanation
//5 1
//9 0 2 4 1	26      	9 0 2 4 1

//becomes
//0 7 4 2 13


// втори начин за 100/100
function solve(args) {
	var nk = args[0].split(' ').map(Number);
	var n = nk[0];
	var k = nk[1]; // number of transitions
	var numbers = args[1].split(' ').map(Number);

	var len = numbers.length;
	var i;
	var resultSum = 0; // use for final sum

	resultArr = makeTransctions(numbers, k);

	for (i = resultArr.length - 1; i >= 0; i-=1) {
		resultSum += resultArr[i];
	}
	return resultSum;

	function makeTransctions(arr , k) {
		while (k > 0) {
			arr = forEachKTransaction(arr);
			k -=1;
		}
		return arr;
	}
	function forEachKTransaction(numbers) {
		var resultArr = [];
		for (var i = 0; i < len; i+=1) {
			if (i === 0) {
				if (numbers[i] === 0) {
					resultArr[i] = Math.abs(numbers[len-1] - numbers[i+1]);
				}
				else if (numbers[i] === 1) {
					resultArr[i] = numbers[len-1] + numbers[i+1];
				}
				else if (numbers[i] % 2 === 0 && numbers[i] !== 0) {
					resultArr[i] = Math.max(numbers[len-1], numbers[i+1]);
				}
				else if (numbers[i] % 2 !== 0 && numbers[i] !== 1) {
					resultArr[i] = Math.min(numbers[len-1], numbers[i+1]);
				}
			}
			else if (i === len - 1) {
				if (numbers[i] === 0) {
					resultArr[i] = Math.abs(numbers[i-1] - numbers[0]);
				}
				else if (numbers[i] === 1) {
					resultArr[i] = numbers[i-1] + numbers[0];
				}
				else if (numbers[i] % 2 === 0 && numbers[i] !== 0) {
					resultArr[i] = Math.max(numbers[i-1], numbers[0]);
				}
				else if (numbers[i] % 2 !== 0 && numbers[i] !== 1) {
					resultArr[i] = Math.min(numbers[i-1], numbers[0]);
				}
			}
			else {
				if (numbers[i] === 0) {
					resultArr[i] = Math.abs(numbers[i-1] - numbers[i+1]);
				}
				else if (numbers[i] === 1) {
					resultArr[i] = numbers[i-1] + numbers[i+1];
				}
				else if (numbers[i] % 2 === 0 && numbers[i] !== 0) {
					resultArr[i] = Math.max(numbers[i-1], numbers[i+1]);
				}
				else if (numbers[i] % 2 !== 0 && numbers[i] !== 1) {
					resultArr[i] = Math.min(numbers[i-1], numbers[i+1]);
				}
			}
		}
		return resultArr;
	}
}



var test = ['5 1', '9 0 2 4 1'];
var test2 = ['10 3','1 9 1 9 1 9 1 9 1 9'];
var test3 = ['10 10','0 1 2 3 4 5 6 7 8 9'];

var test4 = ['3 1','1 0 1'];

console.log(solve(test));
console.log(solve(test2));
console.log(solve(test3));
console.log(solve(test4));


// 3-ти начин за 100/100
function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        k = nk[1],
        copy = [],  // new array(with no elements for now)
        result = 0;
    copy = s.slice();

    for (var j = 0; j < k; j += 1) {
       
        for (var i = 0; i < s.length; i += 1) {
            if (s[i] === 0) {
                if (i === 0) {
                    copy[i] = Math.abs(s[s.length - 1] - s[i + 1]);
                }
                else if (i === s.length - 1) {
                    copy[i] = Math.abs(s[0] - s[i - 1]);
                }
                else {
                    copy[i] = Math.abs(s[i - 1] - s[i + 1]);
                }
            }

            if (s[i] % 2 === 0 && s[i] !== 0) {

                if (i === 0) {
                    copy[i] = Math.max(s[s.length - 1], s[i + 1]);
                }
                else if (i === s.length - 1) {
                    copy[i] = Math.max(s[0], s[i - 1]);
                }
                else {
                    copy[i] = Math.max(s[i - 1], s[i + 1]);
                }
            }

            if (s[i] === 1) {
                if (i === 0) {
                    copy[i] = s[s.length - 1] + s[i + 1];
                }
                else if (i === s.length - 1) {
                    copy[i] = s[0] + s[i - 1];
                }
                else {
                    copy[i] = s[i - 1] + s[i + 1];
                }
            }

            if (s[i] % 2 !== 0 && s[i] !== 1) {
                if (i === 0) {
                    copy[i] = Math.min(s[s.length - 1], s[i + 1]);
                }
                else if (i === s.length - 1) {
                    copy[i] = Math.min(s[0], s[i - 1]);
                }
                else {
                    copy[i] = Math.min(s[i - 1], s[i + 1]);
                }
            }
        }
        s = copy.slice();
    }
    for (var k = 0; k < s.length; k += 1) {
        result = result + s[k];
    }
    return result;
}

console.log(solve(['10 3', '1 9 1 9 1 9 1 9 1 9']));