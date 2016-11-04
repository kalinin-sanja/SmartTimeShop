'use strict';

var smartTimeApp =  angular.module('smartTimeApp', [
    'ngRoute',
    'ngAnimate', 'ui.bootstrap',
    'smartTimeApp.watches',
    'smartTimeApp.watch'
]).
config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
    $routeProvider.otherwise({redirectTo: '/watches'});
}]);

smartTimeApp.controller('SmartTimeAppCtrl', [ '$scope', function($scope) {
    $scope.name = 'default';
}]);