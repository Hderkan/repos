﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




$(document).ready(function() {

    $("li a").each(function () {
        console.log()

        if ($(this).attr("href") == window.location.pathname) {
            console.log($(this).attr("href"))
        $(this).addClass("active")
            }
    })

})


