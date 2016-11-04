'use strict';

angular.module('smartTimeApp.watches', ['ngRoute', 'ngAnimate', 'ui.bootstrap'])

    .config(['$routeProvider', function($routeProvider) {
        $routeProvider.when('/watches', {
            templateUrl: '/routes/watches/watches.html',
            controller: 'WatchesCtrl'
        });
    }])

    .controller('WatchesCtrl', ['$scope', '$http', '$log', function($scope, $http, $log) {
        $http.get('http://localhost:3444/Shop/GetAll').success(function(data) {
            $scope.watches = data;
        });

        $scope.orderField = undefined;
        $scope.orderReverse = false;

        $scope.sort = function(field) {
            $scope.orderReverse = $scope.orderField == field ? !$scope.orderReverse : false;
            $scope.orderField = field;
        }

        $scope.isSortUp = function (field) {
            return $scope.orderField == field && !$scope.orderReverse;
        }

        $scope.isSortDown = function (field) {
            return $scope.orderField == field && $scope.orderReverse;
        }

        $scope.getByName = function (query) {
            var conf = {
                params: {query: query}
            }
            $http.get('http://localhost:3444/Shop/GetByName', conf).success(function(data) {
                $scope.watches = data;
            });
        }

        $scope.getPage = function (page) {
            alert(page);
        }

        $scope.viewby = 5;
        $scope.totalItems = 7;
        $scope.currentPage = 4;
        $scope.itemsPerPage = $scope.viewby;
        $scope.maxSize = 5;

        $scope.setPage = function (pageNo) {
            $scope.currentPage = pageNo;
        };

        $scope.pageChanged = function() {
            console.log('Page changed to: ' + $scope.currentPage);
        };

        $scope.setItemsPerPage = function(num) {
            $scope.itemsPerPage = num;
            $scope.currentPage = 1; //reset to first paghe
        };

        $scope.totalItems = 64;
        $scope.currentPage = 4;

        $scope.setPage = function (pageNo) {
            $scope.currentPage = pageNo;
        };

        $scope.pageChanged = function() {
            $log.log('Page changed to: ' + $scope.currentPage);
        };

        $scope.maxSize = 5;
        $scope.bigTotalItems = 175;
        $scope.bigCurrentPage = 1;
    }]);