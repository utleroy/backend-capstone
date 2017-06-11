app.controller("customerController", ["$scope", "$http", function ($scope, $http,) {
    $scope.customers = [];

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

    $scope.addCustomer = function (newCustomer) {
        var newCustomer = {
            FirstName: $scope.FirstName,
            LastName :$scope.LastName,
            Email: $scope.Email
        }

        $http.post("/api/customer" + newCustomer.CustomerId)
        .then(function (result) {
            $scope.customers = result.data;
        });
        $location.path("/customer");
       
    }

}])