app.controller("homeController", ["$scope", "$http", function ($scope, $http) {
    $scope.products = [];

   
    $http.get("/api/product")
    .then(function (result) {
        $scope.products = result.data;
    });

            
    

    //$http.get("/api/product")
    //    .then(function (result) {
    //        $scope.values = result.data;
    //    });
}])