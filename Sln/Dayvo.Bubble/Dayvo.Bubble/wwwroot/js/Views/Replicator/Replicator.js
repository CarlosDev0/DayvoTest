$(document).ready(function () {
    
    $('#txtEntrada').val('');
    $('#txtReplicado').val('');
    var text = $('#txtEntrada').val('');
    if (text == "") {
        mensajeInicial("You need to type something", "red");
    } else {
        mensajeInicial("You have typed something", "green");
    }
    $('#txtCantidad').val("The message is " + text.length + " characters longs.");
});

function mensajeInicial(mensaje, color) {
    $('#lblMensaje').html(mensaje);
    document.getElementById("lblMensaje").style["color"] = color;
}

$('#txtEntrada').on('keyup', function () {
    var text = $('#txtEntrada').val();
    if (text == "") {
        mensajeInicial("You need to type something", "red");

    } else {
        mensajeInicial("You have typed something", "green");
    }
    $('#txtReplicado').val(text);
    $('#txtCantidad').val("The message is " + text.length + " characters longs.");
    var porcentaje = 0;
    var consonantes = 0;
    if (text.length > 0) {
        consonantes = ContarConsonantes(text);
        porcentaje = 100*consonantes / text.length;
    }
    $('#txtConsonants').val(consonantes + " out of " + text.length + " are consonants (" + porcentaje.toFixed(2)+" % of the total).");
});

function ContarConsonantes(userData) {
    var consonants = 0;
    for (count = 0; count <= userData.length; count++) {
        if ((userData.charAt(count).match(/[bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]/))) {
            consonants++;
        }
    }

    return consonants;
}
