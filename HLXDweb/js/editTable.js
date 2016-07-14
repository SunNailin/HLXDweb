/*
 说明：可编辑的表格
*/

$(function () {
    $("table tr td").each(function () {
        $(this).find("[type=TextBox]").click(function () {
            alert($(this).parent().parent().find("[type=TextBox]").val());
        });
    });
});  