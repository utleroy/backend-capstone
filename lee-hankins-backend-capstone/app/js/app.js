﻿var app = angular.module("RepAssist", ["ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "app/html/login.html",
            controller: "loginController"
        })
        .when("/signup", {
            templateUrl: "app/html/signup.html",
            controller: "signupController"
        })
        .when("/dashboard", {
            templateUrl: "app/html/dashboard.html"
        })
        .when("/home", {
            templateUrl: "app/html/home.html",
            controller: "homeController"
        })
        .when("/customers", {
            templateUrl: "app/html/customerView.html",
            controller: "customerController"
        })
        .when("/add-customer",{
            templateUrl: "app/html/newCustomer.html",
            controller: "customerController"
        })
        .when("/new-order", {
            templateUrl: "app/html/addNewOrder.html",
            controller: "orderController"
        })
        .when("/order/:orderId", {
            templateUrl: "app/html/invoice.html",
            controller: "invoiceController"
        })
}
])
app.run(["$http", function ($http) {

    var token = sessionStorage.getItem("token");

    if (token)

        $http.defaults.headers.common["Authorization"] = `bearer ${token}`;
}
]);