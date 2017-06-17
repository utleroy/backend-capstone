app.controller("orderController", ["$scope", "$location", "$http", function ($scope, $location, $http) {

    //gets customer list from Db to populate dropdown
    $scope.populateCustomerList = function () {
        $http.get("api/customer/")
            .then(function (result) {
                $scope.customerList = result.data;
            });
    };
    $scope.populateCustomerList();

    //gets product list from Db to populate dropdown
    $scope.populateProductList = function () {
        $http.get("api/product/")
            .then(function (result) {
                $scope.productList = result.data;
            });
    };
    $scope.populateProductList();

    $scope.printCharge = function () {
        $http.get("api/productioncharges/")
        .then(function (result) {
            $scope.printChargeList = result.data;
        });
    };
    $scope.printCharge();

    $scope.quantity = "";
    

    $scope.lineItems = [];
    $scope.createLineItemData = function () {
        var lineItem = {
            quantity : $scope.quantity,
            ProductSelected: $scope.ProductSelected,
            NumberPrice: $scope.NumberPrice
        }
        $http.post("api/lineitem", lineItem);
        //post to the line item api
        //get line items and stuff them into the scopew variables
    }
    $scope.createLineItemData();
    
}]);