(function () {
    var app = angular.module('app');

    app.service('$dataService', function ($http) {
        this.getData = function (cep) {
            return $http.get(`https://viacep.com.br/ws/${cep}/json/`);
        };
    });

    app.controller('SiteController', function ($scope, $dataService) {

        $scope.endereco = [];

        $scope.buscarCep = () => {
            if ($scope.endereco.Cep == null || $scope.endereco.Cep.length != 8)
                return;
            $dataService.getData($scope.endereco.Cep).then(function (response) {
                let data = response.data;
                $scope.endereco.Bairro = data.bairro;
                $scope.endereco.Localidade = data.localidade;
                $scope.endereco.Logradouro = data.logradouro;
                $scope.endereco.Uf = data.uf;

            });
        }

        $scope.message = "Hello from AngularJS!";

    });

})();