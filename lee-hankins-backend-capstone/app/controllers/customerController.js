app.controller("customerController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
    $scope.customers = [];
    $scope.addNewCustomer;

    $http.get("/api/customer")
    .then(function (result) {
        $scope.customers = result.data;
    });

    $scope.delete = function (customer) {
        $http.delete("api/customer/" + customer.CustomerId);
        $http.get("/api/customer")
            .then(function (result) {
                $scope.customers = result.data;
            });
    }

    $scope.newCustomer = {
        FirstName: "",
        LastName : "",
        Email: ""
    }

    $scope.addCustomer = function () {
        console.log("test click", $scope.newCustomer);
        $http.post("/api/customer", $scope.newCustomer)
        .then(function (result) {
            $location.path("customers");
        });
       
       
    }

}])