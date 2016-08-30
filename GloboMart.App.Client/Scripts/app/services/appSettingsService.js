(function () {
    "use strict";
    angular
        .module("GloboMartApp")
        .constant("appSettingsService", {
            serverPath: "http://localhost:55189/"
        });
}());