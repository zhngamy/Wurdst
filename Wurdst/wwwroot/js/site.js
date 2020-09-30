// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#wordtable_id').DataTable({
        paging: false,
        info: false
    });






    //detect click on form
    //jquery change input into text input
    // ajax call to send data to server
    // server responds with updated data & ajax success fcn updates table w data from DB 


    $('#wordtable_id').on('click', '.editbtn', function (e) {

        
    });


    //$('').on('click', 'tbody', function (e) {

        
    //    //editor.inline(this);

    //});

});