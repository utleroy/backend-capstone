(function () {
    angular
        .module("common.service")
        .factory("productResource",
        ["$resource",
          "appSettings",
            productResource])

    function productResourse($resourse, appSettings) {
        return $resourse(appSettings.serverPath + "/api/product/:id");

    }
}());