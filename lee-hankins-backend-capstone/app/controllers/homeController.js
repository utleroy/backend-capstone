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
}])