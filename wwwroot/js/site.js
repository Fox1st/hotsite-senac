// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#formInteresse').submit(function(e) {
    e.preventDefault();

    $.ajax({
        url: '/Home/Cadastrar',
        data: $('#formInteresse').serialize(),
        type: 'POST',
        success: function (e) {
            $('#modalCadastroSucesso').modal('show');
        },
        error: function (e) {
            $('#modalCadastroFalha').modal('show');
        }
    });
})

$('#eventos').on('click', function (e) {
    $('#modalEventos').modal('show');
    e.preventDefault();
});

$('#dicas').on('click', function (e) {
    $('#modalDicas').modal('show');
    e.preventDefault();
});

$('#apoiadores').on('click', function (e) {
    $('#modalApoiadores').modal('show');
    e.preventDefault();
});