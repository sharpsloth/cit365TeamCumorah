// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function printIt(printArea) {
    var printTitle = document.getElementById("pageTitle").innerHTML;
    console.log(printTitle);
    var printContents = document.getElementById("printArea").innerHTML;
    console.log(printContents);
    var printPage = document.body.innerHTML;

    document.body.innerHTML = printTitle + printContents;
    //document.body.innerHTML = printContents;

    window.print();

    document.body.innerHTML = printPage;
}
