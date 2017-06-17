app.controller("customerController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.customers = [];
    $scope.newCustomer = {
        FirstName: "",
        LastName: "",
        Email: ""
    }


    $http.get("/api/customer")
    .then(function (result) {
        $scope.customers = result.data;
    });
    

    $scope.addCustomer = function () {
        $http.post("/api/customer", $scope.newCustomer)
        .then(function (result) {
            $location.path("new-order");
        });
    }

    $scope.delete = function (customer) {
        $http.delete("api/customer/" + customer.CustomerId);
        $http.get("/api/customer")
            .then(function (result) {
                $scope.customers = result.data;
            });
    }
}])