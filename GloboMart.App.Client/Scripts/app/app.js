(function () {

    "use strict";

    var app = angular.module("GloboMartApp", ["ui.router", "ui.bootstrap"]);

    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": true,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": true,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn", 
        "hideMethod": "fadeOut",
        "textAlign": "center"
    }

    app.value('toastr', toastr);

    app.config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/dashboard");

        $stateProvider
            .state("dashboard", {
                url: "/dashboard",
                controller: "dashboardController",
                templateUrl: "Scripts/app/templateUrls/dashboard.html"
            });
    }]);
}());


