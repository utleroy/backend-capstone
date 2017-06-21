app.controller("invoiceController", ["$scope", "$http", "$location", "$routeParams", function ($scope, $http, $location, $routeParams) {

    $scope.order = {};

    $http.get("/api/order/" + $routeParams.orderId)
    .then(function (result) {
        $scope.order = result.data;
        $scope.GetTotal = $scope.order.LineItems.reduce(function (prevTotal, currentItem) {
            return prevTotal + currentItem.lineTotal;
        }, 0);

    });



}])

