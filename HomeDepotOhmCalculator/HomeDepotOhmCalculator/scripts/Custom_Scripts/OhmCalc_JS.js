$(document).ready(function () {


    $("select").change(function () {
        

        var data = JSON.stringify({
            '_bandAColor': $('#drpFirstBand').val(),
            '_bandBColor': $('#drpSecondBand').val(),
            '_bandCColor': $('#drpThirdBand').val(),
            '_bandDColor': $('#drpFourthBand').val()
        });

        $.ajax({
            type: "POST",
            url: "/OhmCalculator/CalculateResistenceValue",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: data,
            success: function (result) {
                //if error
                if (result.error != undefined) {
                    $("#divError").html(result.error);
                }
                else {
                    $("#divError").empty();
                    $("#txtMinimumResistance").val(result.minimumValue);
                    $("#txtMaximumResistance").val(result.maximumValue);
                }
            }
        });
    });

})