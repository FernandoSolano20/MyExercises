/// <reference path="jquery-1.3.2-vsdoc.js" />
/// <reference path="jquery.autocomplete.js" />

//en el controlador movie hay que hacer una action que sea search candidates 
//ahi eso es va hacer un entity framework para conectarse a la base y hace lo de where y todo lo demas
$(function() {

    $("#searchBox").autocomplete("/Movie/SearchCandidates",
                                { minChars: 3 });

});

function searchFailed(ajaxContext) {
    var response = ajaxContext.get_response();
    var element = ajaxContext.get_updateTarget();
    element.innerHTML = "Error: server returned a " + response.get_statusCode();
}