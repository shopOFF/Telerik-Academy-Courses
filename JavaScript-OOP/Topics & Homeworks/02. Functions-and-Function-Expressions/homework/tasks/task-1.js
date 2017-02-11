/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

// function sum(arr) {
// 	var sum = 0,
// 		i;

// 	if (arr === undefined) {
// 		throw 'Error! Pass a array of numbers';
// 	}

// 	for (i = 0; i < arr.length; i += 1) {
// 		sum += arr[i];
// 	}

// 	return sum;
// }
//  module.exports = sum;
//sum(([1, 2, 3]));


//re6enie
// function sum(arr) {
//     if (arr === undefined) {
//         throw 'Error! Pass an array!';
//     } else if (!arr.length) {
//         return null;
//     } else {
//         if (!arr.every(function(item) {
//                 return !isNaN(item);
//             })) {
//             throw 'Error! All array elements must be convertible to numbers.';
//         }
//     }

//     return arr.reduce(function(result, item) {
//         return result += item * 1;
//     }, 0);
// }

// module.exports = sum;

// o6te 1 moe re6enie MN DOBRO!!!
// function solve() {
// return 
function sum(arr) {
    if (arr === undefined) {
        throw new Error("Array is undefined!");
    }
    if (arr.length == 0) {
        return null;
    }

    let sumOfNumbers = 0;
    arr.forEach(function(element) {
        let num = +element;
        if (!isNaN(num)) {
            sumOfNumbers += num;
        } else {
            throw new Error("Array element is not a number!");
        }
    }, this);
    return sumOfNumbers;
}
// }

module.exports = sum;