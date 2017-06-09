app.controller("homeController", ["$scope", "$http", "$resource", function ($scope, $http, $resource) {
    $scope.products = [];

   
        $http.get("/api/product", products)
        .then(function (result) {
            $scope.products = result.data;
        })
            
    

    //$http.get("/api/product")
    //    .then(function (result) {
    //        $scope.values = result.data;
    //    });
}])