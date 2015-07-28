$(document).ready(
        function () {
            $("#btnClick").bind("click", function () {
                $.ajax({
                    type: "post",
                    url: "/DongTan/CreateItem",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: "{'dongtan':'" + $('#result').val() + "','name':'whl'}",
                    success: function (data) {
                        $("#result").attr("value", "");
                    },
                    error: function (err) {
                        alert(err.toString());
                    }
                });
                return false;
            });

        });