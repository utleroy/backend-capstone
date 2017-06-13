app.controller("homeController", ["$scope", "$location", "$http", function ($scope, $location, $http) {
    $scope.addCustomer;

    $scope.addCustomer = function () {
        var newCustomer = {
            FirstName: $scope.FirstName,
            lastName: $scope.LastName,
            Email: $scope.Email
           
        }

        $http.post("/api/account/register", newUser);

        $location.path("/");
    }

    $scope.addNewCustomer = function () {
        console.log("add customer button click");
        $location.path("add-customer");
    }

    $scope.addNewOrder = function () {
        console.log("add new order button clicked");
        $location.path("new-order");
    }

    $scope.customertList = [];
    $scope.populateCustomerList = function () {
        $http.get("api/customer/")
            .then(function (result) {
                $scope.customerList = result.data;
            });
    };
    $scope.populateCustomerList();

    $scope.productList = [];
    $scope.populateProductList = function () {
        $http.get("api/product/")
            .then(function (result) {
                $scope.productList = result.data;
            });
    };
    $scope.populateProductList();
}])