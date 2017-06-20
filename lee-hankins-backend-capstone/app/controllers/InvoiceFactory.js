app.factory("InvoiceFactory", function ($http, $location) {

    //$scope.invoiceData = $http.get("/api/order")
    // .then(function (result) {
    //     $http.get("/api/lineitem")
    //        .then(function (result) {
    //            $scope.orders = result.data;

    //        })
    // });
    var getLineItems = $http.get("/api/lineitem").then(function (result) {
        return result.data;
    });

    return{getLineItems:getLineItems}

});