(function () {
    angular.module('helper', [])
        .service('$mensagem', function () {
            // Array para armazenar as mensagens
            var alerts = [];

            // Método para adicionar uma nova mensagem
            this.addAlert = function (type, message) {
                alerts.push({
                    type: type,
                    message: message
                });
            };

            // Método para obter todas as mensagens
            this.getAlerts = function () {
                return alerts;
            };

            // Método para remover uma mensagem específica
            this.removeAlert = function (index) {
                if (index > -1 && index < alerts.length) {
                    alerts.splice(index, 1);
                }
            };

            // Método para limpar todas as mensagens
            this.clearAlerts = function () {
                alerts = [];
            };
        });
})();