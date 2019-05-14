/// <reference path="jquery-1.3.2-vsdoc.js" />

// WCF version
$(function() {

    var service = new InstructorService();
    service.GetInstructorNames(function(result) {
        $(result).each(function() {
            $("<option>").val(this.ID)
                         .text(this.Name)
                         .appendTo("#instructorSelect");
        });
    });

    $("#instructorSelect").change(function() {
        var val = $("#instructorSelect").val()
        if (parseInt(val)) {
            var service = new InstructorService();
            service.GetInstructorDetails(val, function(data) {
                var list = $("<ul></ul>");
                $(data.Facts).each(function() {
                    $("<li>" + this + "</li>").appendTo(list);
                });
                $("#instructorDisplay").html(list);
            });
        }
        else {
            $("#instructorDisplay").html("");
        }
    });

});


// jQuery version
//$(function() {

//    $.getJSON("/Instructor/InstructorNames",
//              "",
//              function(data) {
//                  $(data).each(function() {
//                      $("<option>").val(this.ID)
//                                 .text(this.Name)
//                                 .appendTo("#instructorSelect");
//                  });
//              });

//    $("#instructorSelect").change(function() {
//        var val = $("#instructorSelect").val();
//        if (parseInt(val)) {
//            $.getJSON("/Instructor/InstructorDetails/" + val,
//                       "",
//                       function(data) {
//                           var list = $("<ul></ul>");
//                           $(data.Facts).each(function() {
//                               $("<li>" + this + "</li>").appendTo(list);
//                           });
//                           $("#instructorDisplay").html(list)

//                       });
//        }
//    });

//});