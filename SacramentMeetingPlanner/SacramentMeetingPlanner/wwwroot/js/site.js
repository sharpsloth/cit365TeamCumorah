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

function addSpeaker() {
    var nSpeakers = document.querySelectorAll('.speaker')
    if (nSpeakers == null) {
        nSpeakers = 0
    } else {
        nSpeakers = nSpeakers.length
    }

    var template = ''
    template += '<div class="speaker" >'
    template += '<div class="form-group">'
    template += '<label class="control-label">Speaker Name</label>'
    template += '<input class="form-control" name="Speakers[' + nSpeakers+'].Name" />'
    template += '</div >'
    template += '<div class="form-group">'
    template += '<label class="control-label">Speaker Subject</label>'
    template += '<input class="form-control" name="Speakers[' + nSpeakers +'].Subject" />'
    template += '</div>'
    template += '</div>'

    //document.getElementById('addSpeakerTarget').innerHTML = template
    $('#addSpeakerTarget').append(template)
}