app.controller("orderController", ["$scope", "$location", "$http", function ($scope, $location, $http) {

    //gets customer list from Db to populate
    $scope.populateCustomerList = function () {
        $http.get("api/customer/")
            .then(function (result) {
                $scope.customerList = result.data;
            });
    };

    $scope.populateCustomerList();

    //gets product list from Db to populate
    $scope.populateProductList = function () {
        $http.get("api/product/")
            .then(function (result) {
                $scope.productList = result.data;
            });
    };
    $scope.populateProductList();

    $scope.sizes = ["S,M,L,XL,XXL"];

    $scope.userValue = "";
    $scope.userValuePrintCharges = "";

    $scope.printCharges = {
        1: 1.10,
        2: 1.90,
        3: 2.20
    };

    
}]);