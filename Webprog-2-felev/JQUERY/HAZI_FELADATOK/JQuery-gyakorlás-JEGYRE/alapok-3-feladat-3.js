$(function () {
    $("#koszontes").click(function (e) { 
        e.preventDefault();
        var datum = new Date;
        var date = datum.getHours();

        if (date >= 6 && date <= 8)
            {
                alert("Jó reggelt!")
            }
            else if (date > 8 && date <= 11 )
            {
                alert("Jó napot!")
            }
            else if (date > 11 && date <= 17) 
            {
                alert("Kellemes délutánt!")
            }
            else if (date > 17 && date <= 22)
            {
                alert("Szép estét!")
            }
    });
});