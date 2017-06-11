app.controller("homeController", ["$scope", "$http", function ($scope, $http) {
    $scope.addCustomer = function () {
        var newCustomer = {
            FirstName: $scope.FirstName,
            lastName: $scope.LastName,
            Email: $scope.Email
           
        }

        $http.post("/api/account/register", newUser);

        $location.path("/");
    }
}])