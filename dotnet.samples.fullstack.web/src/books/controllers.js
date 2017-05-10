angular.module('booksApp.controllers', [])
    .controller('RetrieveAllBooksController', function($scope, $state, popupService, $window, Books) {
        $scope.books = Books.query();
        $scope.selectedIsbn = null;
        $scope.setSelectedIsbn = function(isbn) {
            $scope.selectedIsbn = isbn;
        };
        $scope.retrieveBook = function(stateParams) {
            $state.go('book', stateParams);
        };
    })
    .controller('RetrieveBookController', function($scope, $state, $stateParams, popupService, $window, Book) {
        $scope.book = Book.get({ isbn: $stateParams.isbn });
    });