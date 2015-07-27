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
                $("#DESC").attr("value", result.id);  //将获取到的值赋值给前台的控件，这里的d，如果后台返回的不是json字符串，而仅仅是一个值，那么所返回的值就包括在名为d的属性中

            },
            error: function (err) {
                alert("haha");
            }
        });
    }, 5000);

}) 