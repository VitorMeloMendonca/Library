library.controller('LibraryController', function ($scope, ListLibraries) {
    $scope.Library = {
        Title: 'Library Controller'
    };

    $scope.ListLibraries = ListLibraries.data;
});