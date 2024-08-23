(function () {
    var app = angular.module('app');

    app.service('$dataService', function ($http) {
        this.getData = function (cep) {
            return $http.get(`https://viacep.com.br/ws/${cep}/json/`);
        };

        this.teste = function () {
            return $http.get('/api/Testes/GetData');
        };

        this.salvar = function (dados) {
            console.log('Dados enviados:', dados);
            return $http({
                url: '/api/Testes/Save',
                method: "POST",
                data: dados
            })
                .then(function (response) {
                    console.log('Resposta do servidor:', response);
                    return response; // success
                }, function (response) { // optional
                    console.error('Erro ao salvar dados:', response);
                    // Adicione um tratamento adequado para o erro
                });
        };

    });

    app.controller('SiteController', function ($scope, $dataService) {

        $scope.cliente = [];
        $scope.teste = [];

        $scope.buscarCep = () => {
            if ($scope.cliente.Cep == null || $scope.cliente.Cep.length != 8)
                return;
            $dataService.getData($scope.cliente.Cep).then(function (response) {
                let data = response.data;
                $scope.cliente.Bairro = data.bairro;
                $scope.cliente.Localidade = data.localidade;
                $scope.cliente.Logradouro = data.logradouro;
                $scope.cliente.Uf = data.uf;

            });
        }
        $scope.salvar = () => {
            $dataService.salvar($scope.cliente).then((r) => {
                $scope.teste = r;
            })
        }

        $scope.message = "Hello from AngularJS!";

    });

})();