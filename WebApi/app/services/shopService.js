(function () {
    let injectParams = ['$http'];
    let shopService = function ($http) {
        let baseURL = "/api/Shops";

        this.getShops = function () {
            return $http.get(baseURL);
        };
    };
    shopService.$inject = injectParams;
    angular.module('appModule').service('shopService', shopService);
}());