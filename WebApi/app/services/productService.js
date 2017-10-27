(function () {
    let injectParams = ['$http'];
    let productService = function ($http) {
        let baseURL = "/api/Product";

        this.getProducts = function (shopId) {
            
            return $http({ method: 'GET', url: baseURL, params: { 'shopId': shopId } });
        };
    };
    productService.$inject = injectParams;
    angular.module('appModule').service('productService', productService);
}());