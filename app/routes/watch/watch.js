'use strict';

angular.module('smartTimeApp.watch', ['ngRoute'])

    .config(['$routeProvider', function($routeProvider) {
        $routeProvider.when('/watch/:watchId', {
            templateUrl: '/routes/watch/watch.html',
            controller: 'WatchCtrl'
        });
    }])

    .controller('WatchCtrl', ['$scope', '$http', '$routeParams', function($scope, $http, $routeParams) {
        var id = $routeParams.watchId;
        var conf = {
            params: {id: id}
        }
        $http.get('http://localhost:3444/Shop/GetById', conf).success(function(data) {
            // $scope.watch = _.find(data, function(el) {
            //     return el.id == id;
            // });
            $scope.watch = data;
            $scope.mainImgUrl = $scope.watch.PictureUrls[0];
            $scope.selectedColor = $scope.watch.Colors[0];
            $scope.selectedScreenSize = $scope.watch.HasScreen ? $scope.watch.ScreenSizesMm[0] : undefined;
        });

        $scope.setImage = function (imageUrl) {
            $scope.mainImgUrl = imageUrl;
        };

        $scope.setColor = function(color) {
            $scope.selectedColor = color;
        }

        $scope.setScreenSize = function(screenSize) {
            $scope.selectedScreenSize = screenSize;
        }
    }]);