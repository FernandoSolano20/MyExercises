//window.onload = function() {
//    var link = document.getElementById("timeLink");
//    link.onclick = getServerTime;
//}

//function getServerTime() {
//    var xhr = new XMLHttpRequest();
//    xhr.open("GET", "/Home/GetServerTime");

//    xhr.onreadystatechange = function() {
//        if (xhr.readyState == 4) {
//            if (xhr.status == 200) {
//                var timeDiv = document.getElementById("timeDisplay");
//                timeDiv.innerHTML = xhr.responseText;
//            }
//        }
//    }
//    xhr.send();
//}