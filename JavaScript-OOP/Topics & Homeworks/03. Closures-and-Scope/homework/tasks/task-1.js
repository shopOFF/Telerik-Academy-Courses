/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function() {
        var books = [];
        var categories = [];

        function listBooks(categotyToList) {
            if (!categotyToList) {
                return books;
            } else {
                var mathedBooks = [];
                books.map(function(b) {
                    if (b.category === categotyToList.category) {
                        mathedBooks.push(Object.create(b));
                    }
                });

                return mathedBooks;
            }
        }

        function addBook(book) {
            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('Invalid Book Title!');
            }
            if (book.category.length < 2 || book.category.length > 100) {
                throw new Error('Invalid Book Category!');
            }
            if (book.isbn.length < 10 || book.isbn.length > 13) {
                throw new Error('Invalid ISKB length!');
            }

            books.map(function(b) {
                if (b.title === book.title || b.isbn === book.isbn) {
                    throw new Error('This book is already exist!');
                }
            });

            book.ID = books.length + 1;
            books.push(book);

            var existCategory = false;
            categories.map(function(c) {
                if (c === book.category) {
                    existCategory = true;
                }
            });

            if (!existCategory) {
                categories.push(book.category);
            }

            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

module.exports = solve;

// vtoro re6enie 
// function solve() {
//     var library = (function() {
//         var bookID = 0,
//             categoryID = 0,
//             categories = [],
//             books = [];

//         function listBooks(property) {
//             var booksTemp = books.slice();
//             if (property) {
//                 var prop;
//                 for (prop in property) {
//                     if (property.hasOwnProperty(prop)) {
//                         booksTemp = booksTemp.filter(function(item) {
//                             return item[prop] === property[prop];
//                         });
//                     }
//                 }
//             }

//             return booksTemp.sort(function(a, b) {
//                 return a.id - b.id;
//             });
//         }

//         function addBook(book) {
//             var newBook,
//                 newCategory,
//                 categoryIndex;
//             if (books.every(function(item) {
//                     return (item.title !== book.title &&
//                         item.isbn !== book.isbn);
//                 })) {
//                 newBook = new Book(book);
//                 books.push(newBook);
//             } else {
//                 throw 'Book titles must be unique';
//             }

//             if (!categories.some(function(item, index) {
//                     categoryIndex = index;
//                     return item.name === book.category;
//                 })) {
//                 newCategory = new Category(book.category);
//                 newCategory.books.push(newBook);
//                 categories.push(newCategory);
//             } else {
//                 categories[categoryIndex].books.push(newBook);
//             }

//             return newBook;
//         }

//         function listCategories() {
//             return categories.sort(function(a, b) {
//                 return a.id - b.id;
//             }).map(function(item) {
//                 item = item.name;
//                 return item;
//             });
//         }

//         function Book(book) {
//             if (typeof book.title !== 'string' ||
//                 book.title.length < 2 ||
//                 book.title.length > 100) {
//                 throw 'Title must be 2-100 characters long string';
//             }
//             if (typeof book.author !== 'string' || book.author === '') {
//                 throw 'Author must be a non-empty string';
//             }
//             if (typeof book.isbn !== 'string' ||
//                 (book.isbn.length !== 10 &&
//                     book.isbn.length !== 13) ||
//                 book.isbn.split('').every(function(item) {
//                     return isNaN(item);
//                 })) {
//                 throw 'ISBN must be a string, containing 10 or 13 digits';
//             }
//             this.ID = ++bookID;
//             this.title = book.title;
//             this.author = book.author;
//             this.isbn = book.isbn;
//             this.category = book.category;
//         }

//         function Category(name) {
//             if (typeof name !== 'string' || name.length < 2 || name.length > 100) {
//                 throw 'Category name must be 2-100 characters long string';
//             }
//             this.ID = ++categoryID;
//             this.name = name;
//             this.books = [];
//         }

//         return {
//             books: {
//                 list: listBooks,
//                 add: addBook
//             },
//             categories: {
//                 list: listCategories
//             }
//         };
//     }());
//     return library;
// }
// module
//     .exports = solve;




// TRETO RE6ENIE MN DOBRO!!!!

// function solve() {
// 	var library = (function () {
// 		var books = [];
// 		var categories = [];
// 		function listBooks(param) {
// 			if (param) {
// 				if (books.find(x => x.author === param)) {
// 					return books.filter(x => x.author === param);
// 				}
// 				else if (books.filter(x => x.category === param)) {
// 					return books.filter(x => x.category === param.category);
// 				}
// 				else {
// 					return [];
// 				}
// 			}

// 			return books.sort(x => x.ID);
// 		}

// 		function addBook(book) {

// 			if (book.title.length < 2 || book.title.length > 100) {
// 				throw Error();
// 			}

// 			if (book.category.length < 2 || book.category.length > 100) {
// 				throw Error();
// 			}

// 			if(book.isbn.length !== 10 && book.isbn.length !== 13){
// 				throw Error();
// 			}

// 			if (book.author === '') {
// 				throw Error();
// 			}

// 			if (books.find(x => x.title === book.title)) {
// 				throw Error();
// 			}

// 			if(books.find(x => x.isbn === book.isbn)){ //Attention
// 				throw Error();
// 			}

// 			book.ID = books.length + 1;
// 			books.push(book);

// 			if (categories.indexOf(book.category) < 0) {
// 				categories.push(book.category);
// 			}

// 			return book;
// 		}

// 		function listCategories() {
// 			return categories;
// 		}

// 		return {
// 			books: {
// 				list: listBooks,
// 				add: addBook
// 			},
// 			categories: {
// 				list: listCategories
// 			}
// 		};
// 	} ());
// 	return library;
// }
// module.exports = solve;