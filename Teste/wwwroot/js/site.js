// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('.alert-success').after(function () {
    setTimeout(() => $('.alert-success').hide('hide'), 5000);
})

$('.alert-danger').after(function () {
    setTimeout(() => $('.alert-danger').hide('hide'), 5000);
})
