(function () {
    let injectParams = ['$scope', '$location', 'productService', '$routeParams'];
    let productController = function ($scope, $location, productService, $routeParams) {
        let shopId = $routeParams["shopId"];
        $scope.products;
        getProducts();

        function getProducts() {
            let onFulfilled = function (data) {
                $scope.products = data.data;
                if ($scope.products.length === 0)
                    $location.path('/nodata');
            };
            let onRejected = function (error) {
                console.log("unable to load data: " + error);
            };
            productService.getProducts(shopId).then(onFulfilled, onRejected);
        }
    };
    productController.$inject = injectParams;
    angular.module('appModule').controller('productController', productController);
}());