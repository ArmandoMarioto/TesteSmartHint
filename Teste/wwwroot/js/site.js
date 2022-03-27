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
    if ($('#tipo').val() != "Jurídica") {
        $('#divCpf').show();
        $('#cpf').prop("disabled", false);
        $('#genero').prop("disabled", false);
        $('#divGenero').show();
        $('#nascimento').prop("disabled", false);
        $('#divNascimento').show();

        $('#inputEstadual').prop("disabled", true);
        $('#divEstadual').hide();
        $('#cnpj').prop("disabled", true);
        $('#divCnpj').hide();
    } else {
        $('#inputEstadual').prop("disabled", false);
        $('#divEstadual').show();
        $('#divCnpj').show();
        $('#cnpj').prop("disabled", false);

        $('#cpf').prop("disabled", true);
        $('#divCpf').hide();
        $('#genero').prop("disabled", true);
        $('#divGenero').hide();
        $('#nascimento').prop("disabled", true);
        $('#divNascimento').hide();
    }

})

$('#tipo').change(function () {
    if ($('#tipo').val() != "Jurídica") {
        $('#divCpf').show();
        $('#cpf').prop("disabled", false);
        $('#genero').prop("disabled", false);
        $('#divGenero').show();
        $('#nascimento').prop("disabled", false);
        $('#divNascimento').show();

        $('#inputEstadual').prop("disabled", true);
        $('#divEstadual').hide();
        $('#cnpj').prop("disabled", true);
        $('#divCnpj').hide();
    } else {
        $('#inputEstadual').prop("disabled", false);
        $('#divEstadual').show();
        $('#divCnpj').show();
        $('#cnpj').prop("disabled", false);

        $('#cpf').prop("disabled", true);
        $('#divCpf').hide();
        $('#genero').prop("disabled", true);
        $('#divGenero').hide();
        $('#nascimento').prop("disabled", true);
        $('#divNascimento').hide();
    }
    
})

$('#checkIsento').change(function () {
    if ($('#checkIsento').prop("checked")) {
        $('#estadual').prop("value", "");
        $('#estadual').prop("disabled", true);
    } else {
        $('#estadual').prop("disabled", false);
    }

})


$('#checkIsento').ready(function () {
    if ($('#checkIsento').prop("checked")) {
        $('#estadual').prop("value", "");
        $('#estadual').prop("disabled", true);
    } else {
        $('#estadual').prop("disabled", false);
    }

})

$('#checkboxCol').change(function () {
    if ($('#checkboxCol').prop("checked")) {
        $('.form-check-input').prop("checked", true);
    }
    else {
        $('.form-check-input').prop("checked", false);
    }
})

$('#IdForm').submit(function () {
    var senha = $('#senha').val();
    var confirmacaoSenha = $('#confirmacaoSenha').val();
    var senhaErrada = $('#labelSenhaErrada');

    senhaErrada.prop("hidden", true);

    if (senha == confirmacaoSenha) {
        return true;
    }
    else {
        $('#senha').focus();
        senhaErrada.prop("hidden", false);
        senhaErrada.removeAttr("hidden");
        return false;
    }
})

$('.alert-success').after(function () {
    setTimeout(() => $('.alert-success').hide('hide'), 5000);
})

$('.alert-danger').after(function () {
    setTimeout(() => $('.alert-danger').hide('hide'), 5000);
})
