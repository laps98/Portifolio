$.validator.setDefaults({
    highlight: function (element) {
        $(element).addClass('is-invalid');
    },
    unhighlight: function (element) {
        $(element).removeClass('is-invalid');
    },
    ignore: ":hidden:not(.boolean-validation)",
    errorElement: 'span',
    errorClass: 'invalid-tooltip',
    errorPlacement: function (error, element) {
        element.parent().addClass('position-relative');

        if (element.parent('.input-group').length) {
            error.insertAfter(element.parent());
        } else {
            error.insertAfter(element);
        }
    }
});