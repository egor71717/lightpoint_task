(function () {

    var app = angular.module('appModule', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {

        $routeProvider
            .when('/shops', {
                controller: 'shopController',
                templateUrl: '/app/views/shops.html'
            })
            .when('/nodata', {
                //controller: 'productController',
                templateUrl: '/app/views/nodata.html'
            })
            .when('/products/:shopId', {
                controller: 'productController',
                templateUrl: '/app/views/products.html'
            })
            .otherwise({ redirectTo: '/shops' });
    }]);

}());