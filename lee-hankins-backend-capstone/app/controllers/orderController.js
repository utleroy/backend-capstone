app.controller("orderController", ["$scope", "$location", "$http", function ($scope, $location, $http) {

    //gets customer list from Db to populate dropdown
    $scope.populateCustomerList = function () {
        $http.get("api/customer/")
            .then(function (result) {
                $scope.customerList = result.data;
            });
    };
    $scope.populateCustomerList();

    //gets product list from Db to populate dropdown
    $scope.populateProductList = function () {
        $http.get("api/product/")
            .then(function (result) {
                $scope.productList = result.data;
            });
    };
    $scope.populateProductList();

    $scope.printCharge = function () {
        $http.get("api/productioncharges/")
        .then(function (result) {
            $scope.printChargeList = result.data;
        });
    };
    $scope.printCharge();

    $scope.quantity = "";
    $scope.TotalCharges = function () {
        if ($scope.ProductSelected == null || $scope.PrintChargesSelected == null) {
            return 0;
        }
        return ($scope.ProductSelected.salePrice * $scope.quantity) + ($scope.PrintChargesSelected.NumberPrice * $scope.quantity)
    };
    

    $scope.lineItems = [];

    $http.get("/api/lineitem")
    .then(function (result) {
        $scope.lineItems = result.data;

    });

    $scope.createLineItemData = function () {
        var lineItem = {
            quantity : $scope.quantity,
            product: $scope.ProductSelected.brandName,
            imprintPrice: $scope.PrintChargesSelected.NumberPrice,
            shirtPrice: $scope.ProductSelected.salePrice,
            imprintTotal: $scope.PrintChargesSelected.ColorNumber,
            lineTotal: $scope.TotalCharges()
        }
        $http.post("/api/lineitem", lineItem)
            .then (function () {
            $http.get("/api/lineitem", lineItem)
            .then(function (result) {
                $scope.lineItems = result.data;
            });
        })
        
    }

    $scope.delete = function (lineitem) {
        $http.delete("api/lineitem/" + lineitem.LineItemId);
        $http.get("/api/lineitem")
            .then(function (result) {
                $scope.lineItems = result.data;
            });
    }

    //$scope.orders = [];
    //$scope.fillInvoice = [];
    //$scope.invoiceData = [];

    //$scope.invoiceData = $http.get("/api/order")
    // .then(function (result) {
    //     $http.get("/api/lineitem")
    //        .then(function (result) {
    //            $scope.orders = result.data;

    //        })
    // });

    
    
}]);  