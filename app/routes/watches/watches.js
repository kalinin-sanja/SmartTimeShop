'use strict';

angular.module('smartTimeApp.watches', ['ngRoute', 'ngAnimate', 'ui.bootstrap'])

    .config(['$routeProvider', function($routeProvider) {
        $routeProvider.when('/watches', {
            templateUrl: '/routes/watches/watches.html',
            controller: 'WatchesCtrl'
        });
    }])

    .controller('WatchesCtrl', ['$scope', '$http', function($scope, $http) {
        $scope.host = 'http://localhost:3444';
        $scope.getWatchCount = function () {
            var conf = {
                params: {
                    query: $scope.searchText
                }
            };
            $http.get($scope.host + '/Shop/GetWatchCount', conf).success(function(data) {
                $scope.itemsCount = data;
            })
        };
        $scope.getWatchCount();

        $scope.orderField = undefined;
        $scope.orderReverse = false;

        $scope.sort = function(field) {
            $scope.orderReverse = $scope.orderField == field ? !$scope.orderReverse : false;
            $scope.orderField = field;
            $scope.pageChanged();
        };

        $scope.isSortUp = function (field) {
            return $scope.orderField == field && !$scope.orderReverse;
        };

        $scope.isSortDown = function (field) {
            return $scope.orderField == field && $scope.orderReverse;
        };

        $scope.setSearchQuery = function (query) {
            $scope.searchText = query;
            $scope.currentPage = 1;
            $scope.getWatchCount();
            $scope.getWatches();
        };

        $scope.getWatches = function () {
            var offset = ($scope.currentPage - 1)*$scope.itemsPerPage;
            var conf = {
                params: {
                    query: $scope.searchText,
                    field: $scope.orderField,
                    offset: offset,
                    limit: $scope.itemsPerPage,
                    desc: $scope.orderReverse
                }
            };
            $http.get($scope.host + '/Shop/GetByQuery', conf).success(function(data) {
                $scope.watches = data;
            });
        };

        $scope.currentPage = 1;
        $scope.itemsPerPage = 5;
        $scope.maxSize = 5;
        $scope.getWatches();

        $scope.pageChanged = function() {
            $scope.getWatches();
        };
    }]);