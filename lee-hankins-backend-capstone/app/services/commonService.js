var serv = angular.module("commonService", ["ngResource"]);

serv.constants("appSettings", {
    serverPath: "http://localhost:51344/api/Customer"
})
