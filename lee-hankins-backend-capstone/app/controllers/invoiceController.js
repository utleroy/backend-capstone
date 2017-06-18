app.controller("invoiceController", ["$scope", "$http", "$location",  function ($scope, $http, $location) {

    $scope.orders = [];
    $scope.fillInvoice = [];
    $scope.invoiceData = [];

   $scope.invoiceData = $http.get("/api/order")
    .then(function (result) {
       $http.get("/api/lineitem")
          .then(function (result) {
              $scope.orders = result.data;
               
           })
    });

    //$scope.createInvoice = function () {
    //   $http.get("/api/lineitem")
    //     .then(function (result) {
    //         $scope.fillInvoice = result.data;
    //});
    //}
}])