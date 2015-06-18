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
 *	Each book/category has a unique identifier (ID) that is a number greater than 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [],
            categories = [],
            bookId = 1;

        function listBooks(property) {

            var tempBook = books.slice(),
                prop;
            if (property) {
                for (prop in property) {
                    tempBook = books.filter(function (book) {
                        return book[prop] === property[prop];
                    });
                }
            }

            return tempBook.sort(function (a, b) {
                return a.ID - b.ID;
            });
        }


        function addBook(newBook) {
            var book;

            if (!newBook.category) {
                newBook.category = 'NoCategory';
            }
            if (newBook.title.length < 2 || newBook.title.length > 100) {
                throw Error('Must be between 2-100 chars');
            }
            if (newBook.category.length < 2 || newBook.category.length > 100) {
                throw Error('Must be between 2-100 chars');
            }
            if (newBook.author.length < 1 || newBook.author === undefined) {
                throw Error('Must be non-empty');
            }
            if (!(newBook.isbn.length === 10 || newBook.isbn.length === 13)) {
                throw Error('Must be 10 or 13 digits');
            }

            if (books.some(function (item) {
                    return item.title === newBook.title
                })) {
                throw Error('The book exist')
            }

            if (books.some(function (item) {
                    return item.isbn === newBook.isbn
                })) {
                throw Error('The book isbn exist')
            }
            bookId += 1;


            book = {
                title: newBook.title,
                isbn: newBook.isbn,
                author: newBook.author,
                category: newBook.category,
                ID: bookId
            };

            if (categories.indexOf(book.category) < 0) {
                categories.push(book.category);
            }

            books.push(book);
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

