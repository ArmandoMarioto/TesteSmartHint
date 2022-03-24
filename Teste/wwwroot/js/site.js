// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#tableClientes').DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 até 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
});
$('#tipo').ready(function () {
    if ($('#tipo').val() == 1) {
        $('#divCpf').show();
        $('#divCnpj').hide();
    } else {
        $('#divCpf').hide();
        $('#divCnpj').show();
    }

})

$('#tipo').change(function () {
    if ($('#tipo').val() == 1) {
        $('#divCpf').show();
        $('#divCnpj').hide();
    } else {
        $('#divCpf').hide();
        $('#divCnpj').show();
    }
    
})

$('.alert-success').after(function () {
    setTimeout(() => $('.alert-success').hide('hide'), 5000);
})

$('.alert-danger').after(function () {
    setTimeout(() => $('.alert-danger').hide('hide'), 5000);
})
