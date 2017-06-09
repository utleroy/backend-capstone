var serv = angular.module("commonService", ["ngResource"])
serv.constant(
    "appSettings", {
    serverPath: "http://localhost:51344/"
}());

