(function () {
    "use strict";
    angular
       .module("GloboMartApp")
       .controller("dashboardController",
                    ["$scope", "dataService", "toastr", dashboardController]);

    function dashboardController($scope, dataService, toastr) {
        $scope.data = "test";

        // Products List
        $scope.products = [];

        // List of product types for product filtration
        $scope.productTypes = [];

        // List of prodcut types for Add product form
        $scope.productTypesAdd = [];

        // product object
        $scope.product = {};

        function init() {
            getProducts();
            getProductType();
        };


        init();

        // Click event for save and update a product
        $scope.saveProduct = function () {
            var requestObj = angular.copy($scope.product);
            // Udpate
            if ($scope.product.id > 0) {
                dataService.updateProduct(requestObj).then(function (response) {
                    $scope.product = [];
                    $scope.selectedProductTypeId = 0;
                    getProducts();
                    toastr.clear();
                    toastr.success("Product updated successfully", "Update Product", { timeOut: 2000 });
                }, function (errorReason) {
                    toastr.error("Some error, please try again", "Add Product", { timeOut: 2000 });
                });

            }
            else {
                // Save
                dataService.saveProduct(requestObj).then(function (response) {
                    $scope.product = [];
                    $scope.selectedProductTypeId = 0;
                    getProducts();
                    toastr.clear();
                    toastr.success("Product saved successfully", "Add Product", { timeOut: 2000 });
                }, function (errorReason) {
                    toastr.error("Some error, please try again", "Add Product", { timeOut: 2000 });
                });
            }
        };

        // Edit product event
        $scope.editProduct = function (data) {
            $scope.product = data;
            $scope.selectedProductTypeId = data.productType.id;
        }

        // Delete product event
        $scope.deleteProduct = function (data) {
            var requestObj = angular.copy(data);
            dataService.deleteProduct(requestObj).then(function (response) {
                toastr.success("Product Deleted successfully", "Delete Product", { timeOut: 2000 });
                getProducts();
            }, function (errorReason) {
                toastr.error("Some error, please try again", "Delete Product", { timeOut: 2000 });
            });
        }

        // get all products 
        function getProducts() {
            dataService.getProducts().then(function (response) {
                var storedItem = response.data;
                $scope.products = storedItem;

            }, function (errorReason) {
                toastr.error("Some error, please try again", "Get Products", { timeOut: 2000 });
            });
        };

        // get all product Types
        function getProductType() {
            dataService.getProductType().then(function (response) {
                $scope.productTypes = response.data;
                $scope.productTypesAdd = response.data;
            }, function (errorReason) {
                toastr.error("Some error, please try again", "Get ProductType", { timeOut: 2000 });
            });
        }


    }


}());