app.controller("homeController", ["$scope", "$location", "$http", function ($scope, $location, $http) {

    //button click redirects to add-customer route
    $scope.addNewCustomer = function () {
        console.log("add customer button click");
        $location.path("add-customer");
    }

    //button click redirectrs to new-order route
    $scope.addNewOrder = function () {
        console.log("add new order button clicked");
        $location.path("new-order");
    }
}]);