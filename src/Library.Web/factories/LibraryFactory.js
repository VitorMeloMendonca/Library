library.factory('LibraryFactory', function ($http) {

    var baseUrl = 'http://localhost:55000/api/Library/';
    var dataFactory = {};

    dataFactory.GetAllLibrary = function () {
        return $http.get(baseUrl + 'GetAllLibrary', function (response) {
            return response.data;
        });
    }

    return dataFactory;
});