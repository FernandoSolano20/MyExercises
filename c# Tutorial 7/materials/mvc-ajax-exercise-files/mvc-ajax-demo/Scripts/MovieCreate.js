/// <reference path="jquery-1.3.2-vsdoc.js" />
/// <reference path="jquery.validate.js" />

$(function() {

    $(".create #ReleaseDate").datepicker();

    $(".create form").validate({
        rules: {
            Title: {
                required: true,
                minlength: 3,
                maxlength: 50
            },

            ReleaseDate: {
                required: true,
                date: true
            }
        }
    });
});
