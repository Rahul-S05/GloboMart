(function () {
    "use strict";
    angular
        .module("GloboMartApp")
        .factory("dataService",
                  ["$http", "$q", "appSettingsService", configService]);

    function configService($http, $q, appSettingsService) {

        var serviceUri = "";
        var fragmentUrl = "api/Product";
        var appConfig = null;

        function init() {

            serviceUri = appSettingsService.serverPath + fragmentUrl;
        };

        var getCapabilities = function (kanbanSetting) {
            return $http.get(serviceUri + "/getCapabilities", {
                params: kanbanSetting,

            });
        };
        var getCapabilityDetails = function (elementId) {
            return $http.get(serviceUri + "/GetCapabilityDetails", {
                params: { "elementId": elementId },


            });
        };
        var saveProduct = function (data) {
            var url = serviceUri + "/Create";
            return $http({
                url: url,
                method: "POST",
                data: $.param(data),
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });
        };
        var getProducts = function () {
            return $http({
                url: serviceUri + "/select",
                method: "GET",
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });

        };

        var getProductType = function () {
            return $http({
                url: appSettingsService.serverPath + "api/ProductType/select",
                method: "GET",
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });

        };
        var updateProduct = function (data) {

            var url = serviceUri + "/Update";
            return $http({
                url: url,
                method: "POST",
                data: $.param(data),
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });
        };

        var deleteProduct = function (data) {

            var url = serviceUri + "/Delete";
            return $http({
                url: url,
                method: "POST",
                data: $.param(data),
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });
        };


        init();

        return {
            saveProduct: saveProduct,
            getProducts: getProducts,
            getProductType: getProductType,
            updateProduct: updateProduct,
            deleteProduct: deleteProduct
        };
    };

}());