const szavak = ["Grogu", "Chewbacca", "Yoda", "Princess Leia", "Han Solo", "Anakin Skywalker", "Darth Vader", "Luke Skywalker", "Ahsoka Tano", "Obi-Wan Kenobi"];

let rndIndex;
let rndSzo;
let vonal;
let kepSrc;
var proba;
var marProbalt;
var osszesMarProbalt;
var bevitel;

const tippGomb = document.getElementById("tipp");
start();
tippGomb.addEventListener("click", jatek);

function start(){
    rndIndex = Math.floor(Math.random() * szavak.length);
    rndSzo = szavak[rndIndex];
    marProbalt = [];
    osszesMarProbalt = [];
    proba = 0;
    
    vonal = "";
    for (let i = 0; i < rndSzo.length; i++) {
        if (rndSzo[i] == "-"){
            vonal += "-";
        }
        else if (rndSzo[i] == " "){
            vonal += " ";
        }
        else 
        {
            vonal += "_";
        }
    }

    document.getElementById("marProbalt").innerHTML = "";
    document.getElementById("szo").innerHTML = vonal;
    kep();
}

function jatek() {
    bevitel = document.getElementById("bevitel").value;

    if (bevitel.length == 0){
        window.alert("Kérem adjon meg egy Tippet!");
        return;
    }

    if (bevitel.length != 1){
        window.alert("Csak egyetlen betűt tippelhet egyszerre!");
        document.getElementById("bevitel").value = "";
        return;
    }

    const regex = /[^a-zA-ZáéíóöőúüűÁÉÍÓÖŐÚÜŰ]/;
    if (regex.test(bevitel)){
        window.alert("Csak betűket adhat meg!");
        document.getElementById("bevitel").value = "";
        return;
    }

    if (osszesMarProbalt.includes(bevitel)){
        window.alert("Próbálkozz egy még nem használt betűvel!");
        document.getElementById("bevitel").value = "";
        return;
    }

    if (rndSzo.includes(bevitel) && !marProbalt.includes(bevitel)){
        const indexek = [];
        let index = rndSzo.indexOf(bevitel);
        while (index !== -1){
            indexek.push(index);
            index = rndSzo.indexOf(bevitel, index + 1);
        }

        let betuk = vonal.split("");
        for (let i = 0; i < indexek.length; i++) {
            betuk[indexek[i]] = bevitel;
        }

        vonal = betuk.join("");

        document.getElementById("szo").innerHTML = vonal;
        document.getElementById("bevitel").value = "";
        osszesMarProbalt.push(bevitel);
        if (!vonal.includes("_")){
            window.alert("GRATULÁLOK!")
            if (confirm("Szeretnél újra játszani?")){
                start();
            }
        }
    }
    else 
    {
        proba += 1;
        marProbalt.push(bevitel);
        osszesMarProbalt.push(bevitel);
        kep();
        document.getElementById("bevitel").value = "";
        document.getElementById("marProbalt").innerHTML = marProbalt.join(', ');
    }
    
}

function kep() {
    switch (proba) {
        case 0:
            kepSrc = "forras/akasztofa00.png";
            break;
        case 1:
            kepSrc = "forras/akasztofa01.png";
            break;
        case 2:
            kepSrc = "forras/akasztofa02.png";
            break;
        case 3:
            kepSrc = "forras/akasztofa03.png";
            break;
        case 4:
            kepSrc = "forras/akasztofa04.png";
            break;
        case 5:
            kepSrc = "forras/akasztofa05.png";
            break;
        case 6:
            kepSrc = "forras/akasztofa06.png";
            break;
        case 7:
            kepSrc = "forras/akasztofa07.png";
            break;
        case 8:
            kepSrc = "forras/akasztofa08.png";
            break;
        case 9:
            kepSrc = "forras/akasztofa09.png";
            break;
        case 10:
            kepSrc = "forras/akasztofa10.png";
            break;
        case 11:
            kepSrc = "forras/akasztofa11.png";
            break;
        case 12:
            kepSrc = "forras/akasztofa12.png";
            break;
        case 13:
            document.getElementById("akasztofaKep").src = "forras/akasztofa00.png";
            if (confirm("Sajnos ez nem sikerült!\nA helyes válasz " + rndSzo + " volt." + "\nSzeretnél újra játszani?")) {
                start();
            }
            break;
        default:
            break;
    }
    document.getElementById("akasztofaKep").src = kepSrc;
}