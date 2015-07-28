$(function () {
    setInterval(
    function () {
        $.ajax({
            type: "Post",
            url: "/DongTan/GetNewItems", //页面名(不带controller)/要调用的后台方法名
            data: "{}", //json格式的字符串将参数传入后台，参数名必须一致
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                var obj = JSON.parse(result);
                $("#newitemlist").empty();
                var _class = new Array('one', 'two', 'three', 'four', 'five');
                for (var i = 0; i < obj.newItems.length; i++) {
                    $("#newitemlist").append("<li class=\""+_class[i]+"\"><h5>" + obj.newItems[i].userId + "</h5>" + obj.newItems[i].message + "</li>");
                }
            },
            error: function (err) {
                alert(err.toString());
            }
        });
    }, 5000);

})


