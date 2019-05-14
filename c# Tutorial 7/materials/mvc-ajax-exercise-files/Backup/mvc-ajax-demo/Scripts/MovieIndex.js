/// <reference path="jquery-1.3.2-vsdoc.js" />
/// <reference path="jquery.autocomplete.js" />

$(function() {

    $("#searchBox").autocomplete("/Movie/SearchCandidates",
                                { minChars: 3 });

});

function searchFailed(ajaxContext) {
    var response = ajaxContext.get_response();
    var element = ajaxContext.get_updateTarget();
    element.innerHTML = "Error: server returned a " + response.get_statusCode();
}