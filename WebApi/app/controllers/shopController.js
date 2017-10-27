(function () {
    let injectParams = ['$scope', '$location', 'shopService'];
    let shopController = function ($scope, $location, shopService) {
        $scope.shops;
        $scope.toProducts = function (shopId){
            $location.path ('/products/' + shopId);
        };
        getShops();

        function getShops() {
            let onFulfilled = function (data) {
                $scope.shops = data.data;
                if ($scope.shops.length === 0)
                    $location.path('/nodata');
            };
            let onRejected = function (error) {
                console.log("unable to load data: " + error);
            };
            shopService.getShops().then(onFulfilled, onRejected);
        }
    };
    shopController.$inject = injectParams;
    angular.module('appModule').controller('shopController', shopController);
}());