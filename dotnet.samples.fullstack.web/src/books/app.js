angular.module('booksApp', ['ui.router', 'ngResource', 'booksApp.controllers', 'booksApp.services']);

angular.module('booksApp').config(function($stateProvider) {
    $stateProvider.state('books', {
        url: '/books',
        templateUrl: 'books/books.html',
        controller: 'RetrieveAllBooksController'
    }).state('book', {
        url: '/book/:isbn',
        templateUrl: 'books/book.html',
        controller: 'RetrieveBookController'
    });
}).run(function($state) {
    $state.go('books');
});