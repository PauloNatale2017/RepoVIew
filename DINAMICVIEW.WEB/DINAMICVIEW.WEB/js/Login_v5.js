var app = angular.module('App', ['blockUI']);
var Obj;
var token = "";

app.controller("CtrlLogin_v5", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout',
function ($scope, $http, $location, $window, blockUI, $timeout) {

    Obj = $scope;
    $scope.blockUI = blockUI;
    blockUI.start("Carregando...");
    $scope.Submit = function () {        
        var entity = $scope.Login;   
    }
    $timeout(function () {
        blockUI.stop();
    },5000)
    

}]);







