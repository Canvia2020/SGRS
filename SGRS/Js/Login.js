//window.onload = function () {
//    var url = "Login/Inicio";
//    $.get(url, mostrar);
//};

//var $ = {
//    get: function(url, metodo) {
//        requestServer(url, 'get', "text", metodo);
//    }
//}

//function requestServer(url,tipoMetodo,tipoRpta,metodo) {
//    var xhr = new XMLHttpRequest();
//    xhr.open(tipoMetodo, url, true);
//    xhr.responseType = tipoRpta;
//    xhr.onreadystatechange = function() {
//        if (xhr.status == 200 && xhr.readyState == 4) {
//            if (tipoRpta == "" || tipoRpta=="text") {
//                metodo(xhr.responseText, true);
//            }
//            else {
//                metodo(xhr.response);
//            }
//        };

//    };
//    xhr.send();
//};

//function mostrar(rpta) {
//    document.getElementById("contenido").innerHTML = rpta;
//};