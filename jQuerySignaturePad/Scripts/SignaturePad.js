var SignPad = (function () {
    $(document).ready(function () {
        $("#btnSave").click(function () {
            html2canvas($("#SignPad"), {
                onrendered: function (canvas) {
                    theCanvas = canvas;
                    var imgageData = canvas.toDataURL("image/png");
                    var newData = imgageData.replace(/^data:image\/png/, "data:application/octet-stream");
                    $("#DownloadImage").attr("download", "E-Signature.bmp").attr("href", newData);
                    SaveImage(newData)
                }
            });

        });

        $('#smoothed').signaturePad({
            drawOnly: true,
            drawBezierCurves: true,
            lineTop: 230,
        });

        function SaveImage(strimgByte) {
            $.ajax({
                type: "POST",/*method type*/
                contentType: "application/json; charset=utf-8",
                url: "Home/SaveImage",/*Target function that will be return result*/
                data: '{"strImage":"' + strimgByte + '"}',/*parameter pass data is parameter name param is value */
                dataType: "json",
                success: function (data) {
                    alert("Success");
                }

            });
        }

    });

    var SaveESign = function () {
        alert("Invoked");

    }
    return {
        SaveESign: function () {
            SaveESign();
        }
    };
})();