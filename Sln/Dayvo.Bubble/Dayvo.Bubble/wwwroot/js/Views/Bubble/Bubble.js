////$(document).ready(function () {

////});

$('#btnBubble').on('click', function () {
    ConsultarBubble();
});

function ConsultarBubble() {
    var asc = true;
    if( $('input[name=Criterio]:checked').val() == "Descendente") {
        asc = false;
    }
    var text = $('#txtInput').val();
    $.ajax({
        url: '/Bubble/OrderBurbuja',
        dataType: "json",
        data: { Asc: asc, Texto: text },
        success: function (result) {
            if (result != null) {
                $('#txtResultado').val(result);
            }
        }
    });
}
