app.controller("homeController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
    $scope.values = [];

    $scope.productData = function () {
        var display = {
            styleName: $scope.styleName,
            colorName: $scope.colorName
        }
        $http.get("/api/product", display);
        $location.path("/home");
            
    }

    //$http.get("/api/product")
    //    .then(function (result) {
    //        $scope.values = result.data;
    //    });
}])