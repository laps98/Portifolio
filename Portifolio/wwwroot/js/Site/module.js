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
            // Exibe os dados enviados para verificação
            console.log('Dados enviados:', dados);

            // Realiza uma requisição POST usando o serviço $http
            return $http({
                url: '/api/Testes/Save',  // URL do endpoint
                method: 'POST',           // Método HTTP
                data: dados,               // Dados enviados no corpo da requisição
                headers: {
                    'Content-Type': 'application/json'
                }
            }).then(function (response) {
                // Loga a resposta de sucesso no console
                console.log('Resposta do servidor:', response);
                return response.data;     // Retorna apenas os dados da resposta
            }).catch(function (response) {
                // Loga o erro no console para depuração
                console.error('Erro ao salvar dados:', response);

                // Adiciona um tratamento adequado para o erro
                // Aqui você pode manipular o erro e mostrar mensagens para o usuário
                return Promise.reject(response);
            });
        };


    });

    app.controller('SiteController', function ($scope, $dataService) {

        $scope.cliente = {};
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
            $dataService.salvar($scope.cliente).then(function (response) {
                console.log('Cliente salvo com sucesso!', response);
                // Aqui você pode adicionar lógica para lidar com a resposta
            }).catch(function (error) {
                console.error('Falha ao salvar cliente', error);
                // Aqui você pode adicionar lógica para lidar com erros
            });
        }

        $scope.message = "Hello from AngularJS!";

    });

})();