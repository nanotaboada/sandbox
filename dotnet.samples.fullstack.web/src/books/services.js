angular.module('booksApp.services', [])
    .factory('Book', function($resource) {
        return $resource('https://node-samples-restful.herokuapp.com/api/v1/book/:isbn', { isbn: '@isbn' }, {
            update: { method: 'PUT' }
        });
    }).factory('Books', function($resource) {
        return $resource('https://node-samples-restful.herokuapp.com/api/v1/books');
    });

angular.module('booksApp.services')
    .service('popupService', ['$window', function($window) {
        this.showPopup = function(message) {
            return $window.confirm(message);
        };
    }]);