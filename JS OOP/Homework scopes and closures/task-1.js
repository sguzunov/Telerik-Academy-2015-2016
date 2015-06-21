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
	var library = (function () {
		var books = [];
		var categories = [];

		function addBook(book) {
			if(arguments.length === 0){
				throw new Error('The object is empty!');
			}

			if(!checkLength(book.title)){ // done
				throw new Error('The title must be between 2 and 100 characters!');
			}

			if(!checkLength(book.category)){ // done
				throw new Error('The category must be between 2 and 100 characters!');
			}

			if(!checkISBNLength(book.isbn)){ // done
				throw new Error('The isbn must be 10 or 13 characters!');
			}

			if(!checkTitle(book.title)){
				throw new Error('Already exists book with the same title!');
			}

			if(!checkISBN(book.isbn)){
				throw new Error('Already exists book with the same ISBN!');
			}			

			book.ID = books.length + 1;
			books.push(book);

			if(categories.indexOf(book.category) === -1){
				categories.push(book.category);
			}
			
			return book;
		}

		function listBooks(param) {
			 var result=[];
			 if(param && param.author){
			 	result = books.filter(function (item) {
			 		return item.author === param.author;
			 	});
			 }else if(param && param.category){
			 	result = books.filter(function (item) {
			 		return item.category === param.category;
			 	});
			 }else{
			 	result = books;
			 }

			 result = result.sort(function (firstItem, secondItem){
			 	return firstItem.ID - secondItem.ID;
			 });

			 return result;
		}

		function listCategories() {
			 categories = categories.sort(function (firstCategory, secondCategory) {
                return firstCategory - secondCategory;
            });
            return categories;
		}

		// making checks	
		function checkISBNLength(isbn){
			if((isbn.length === 10 || isbn.length === 13) && (isNaN(isbn) === false)){
				return true;
			}

			return false;
		}
		
		function checkLength(titleOrCategory){
			if((titleOrCategory.length > 2) || (titleOrCategory.length < 100)){
				return true;
			}

			return false;
		}

		function checkTitle(param){
			var i,
			  len;
		    for(i=0, len = books.length; i < len; i += 1){
			  	if(books[i].title ===  param){
			  		return false;
			    }
			}

		    return true;
		}

		function checkISBN(param){
			var i,
			  len;
		    for(i=0, len = books.length; i < len; i += 1){
			  	if(books[i].isbn === param){
			  		return false;
			    }
			}
		    return true;
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

	} ());

	return library;
}

module.exports = solve;
