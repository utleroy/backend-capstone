app.controller("orderController", ["$scope", "$location", "$http", function ($scope, $location, $http) {

    //gets customer list from Db to populate dropdown
    $scope.populateCustomerList = function () {
        $http.get("api/customer/")
            .then(function (result) {
                $scope.customerList = result.data;
            });
    };
    $scope.populateCustomerList();

    //_________________________________________________________________
    //GENERATE ORDER
    //_________________________________________________________________

   

    $scope.generateOrder = function () {
        var customerId = $scope.CustomerSelected.CustomerId;
        console.log("cust", customerId);
        $http.post("api/order/", customerId)
        .then(function (result) {
            var orderId = result.data.OrderId;

            for (var i = 0; i < $scope.lineItems.length; i++) {
                var lineitem = $scope.lineItems[i];
                lineitem.orderId = orderId;
                $http.post("/api/lineitem", lineitem);
                console.log(lineitem.orderId)
            }
            $location.path(`/order/${orderId}`)
        })
        
    }
    //_________________________________________________________________
    //GENERATE ORDER
    //_________________________________________________________________


    //_________________________________________________________________
    //POPULATE SHIRTS DROPDOWN
    //_________________________________________________________________
    $scope.populateProductList = function () {
        $http.get("api/product/")
            .then(function (result) {
                $scope.productList = result.data;
            });
    };
    $scope.populateProductList();
    //_________________________________________________________________
    //POPULATE SHIRTS DROPDOWN
    //_________________________________________________________________


    //_________________________________________________________________
    //POPULATE PRINTPRICING DROPDOWN
    //_________________________________________________________________

    $scope.printCharge = function () {
        $http.get("api/productioncharges/")
        .then(function (result) {
            $scope.printChargeList = result.data;
        });
    };
    $scope.printCharge();
    //_________________________________________________________________
    //POPULATE PRINTPRICING DROPDOWN
    //_________________________________________________________________



    //_________________________________________________________________
    //STORES LINE ITEM VALUES FROM USER
    //_________________________________________________________________

    $scope.quantity = "";
    $scope.TotalCharges = function () {
        if ($scope.ProductSelected == null || $scope.PrintChargesSelected == null) {
            return 0;
        }
        return ($scope.ProductSelected.salePrice * $scope.quantity) + ($scope.PrintChargesSelected.NumberPrice * $scope.quantity)
    };


    $scope.lineItems = [];


    $scope.createLineItemData = function () {
        var lineItem = {
            quantity: $scope.quantity,
            product: $scope.ProductSelected.brandName,
            imprintPrice: $scope.PrintChargesSelected.NumberPrice,
            shirtPrice: $scope.ProductSelected.salePrice,
            imprintTotal: $scope.PrintChargesSelected.ColorNumber,
            lineTotal: $scope.TotalCharges()
        }

        $scope.lineItems.push(lineItem);

        //$scope.quantity = undefined;
        //$scope.ProductSelected = undefined;
        //$scope.PrintChargesSelected.NumberPrice = undefined;
        //$scope.ProductSelected.salePrice = undefined;
        //$scope.PrintChargesSelected = undefined;
    }

    //_________________________________________________________________
    //STORES LINE ITEM VALUES FROM USER
    //_________________________________________________________________

    //_________________________________________________________________
    //DELETE LINE ITEM
    //_________________________________________________________________

    $scope.delete = function (lineitem) {
        $http.delete("api/lineitem/" + lineitem.LineItemId);
        $http.get("/api/lineitem")
            .then(function (result) {
                $scope.lineItems = result.data;
            });
    }

    //_________________________________________________________________
    //DELETE LINE ITEM
    //_________________________________________________________________

}]);