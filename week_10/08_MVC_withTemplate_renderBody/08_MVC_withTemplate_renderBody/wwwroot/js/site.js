// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {                       //run when the DOM is ready
    $("a").mouseenter(function () {  //use a class, since your ID gets mangled
        event.preventDefault();
        $(this).addClass("active");      //add the class to the clicked element
    });
});

 
