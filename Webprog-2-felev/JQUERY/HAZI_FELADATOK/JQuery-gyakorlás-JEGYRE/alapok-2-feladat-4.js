$(function () {
    $("#bevitel").change(function (e) { 
        e.preventDefault();
        $("#bekezdes").html($("#bevitel").val());
    });
});