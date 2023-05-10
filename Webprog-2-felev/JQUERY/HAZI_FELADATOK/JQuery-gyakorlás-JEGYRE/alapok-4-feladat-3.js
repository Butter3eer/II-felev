$(function () {
    $("#regGomb").click(function (e) { 
        e.preventDefault();

        const adatok = [];
        const varNev = $("#felNev").val();
        const email = $("#email").val();
        const phone = $("#phone").val();
        const age = $("#age").val();
        const haz = $('input[name="hazak"]:checked').val();
        const karakter = $('input[name="szereplok"]:checked').val();

        let oke = true;
        if (varNev.length == 0){
            window.alert("A varázslónév megadása kötelező.")
            oke = false;
        }

        if (email.length == 0){
            window.alert("Az email megadása kötelező.")
            oke = false;
        }

        if (phone.length == 0){
            window.alert("A telefonszám megadása kötelező.")
            oke = false;
        }

        if (age.length == 0){
            window.alert("Az életkor megadása kötelező.")
            oke = false;
        }

        if (haz.length == 0){
            window.alert("A ház megadása kötelező.")
            oke = false;
        }

        if (karakter.length == 0){
            window.alert("A karakter megadása kötelező.")
            oke = false;
        }
        
        if (oke) {
            const regAdat = {
                varNev: varNev,
                email: email,
                phone: phone,
                age: age,
                haz: haz,
                karakter: karakter
            };
            adatok.push(regAdat);
            console.log(adatok);
        }
    });
});