app.controller("orderController", ["$scope", "$location", "$http", function ($scope, $location, $http) {

    
    $scope.userValue = "";
    $scope.userValuePrintCharges = "";


    //gets product list from Db to populate
    $scope.populateProductList = function () {
        $http.get("api/product/")
            .then(function (result) {
                $scope.productList = result.data;
            });
    };
    $scope.populateProductList();
    
    $scope.printcharges = function () {
        $http.get("api/productioncharges/")
        .then(function (result) {
            $scope.printPriceList = result.data;
        });
    };
    $scope.printcharges();

}]);