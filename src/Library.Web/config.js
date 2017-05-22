var library = angular.module('library', ['ngRoute']);

library.config(function ($routeProvider) {
    $routeProvider.when('/',
    {
        templateUrl: 'templates/home.html',
        controller: 'HomeController',
        tab: 'home'
    })
    .when('/Library',
    {
        templateUrl: 'templates/library.html',
        controller: 'LibraryController',
        tab: 'library',
        resolve: {
            ListLibraries: function (LibraryFactory) {
                return LibraryFactory.GetAllLibrary();
            }
        }
    })
    .when('/Book',
    {
        templateUrl: 'templates/book.html',
        controller: 'BookController',
        tab: 'book'
    })
    .when('/Author',
    {
        templateUrl: 'templates/author.html',
        controller: 'AuthorController',
        tab: 'author'
    })
    .otherwise('/');;
});