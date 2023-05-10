window.addEventListener("load", start);

function start() {
    let kisskati = new szemely("Kiss","Katalin",28,"");
    kisskati.setHobby("futás");
    document.getElementById("teljesnev").innerHTML = "Teljes neve: " + kisskati.teljesnev();
    document.getElementById("eletkor").innerHTML = "Életkora: " + kisskati.eletkor();
    document.getElementById("hobby").innerHTML = "Kedvenc elfoglaltsága: " + kisskati.getHobby();
}

class szemely {
    constructor(keresztnev, vezeteknev, kor, hobby) {
        this.keresztnev = keresztnev;
        this.vezeteknev = vezeteknev;
        this.kor = kor;
        this.hobby = hobby;
    }
    setHobby(hobby) {
        this.hobby = hobby;
    }
    teljesnev() {
        let teljesnev = this.keresztnev + " " + this.vezeteknev;
        return teljesnev;
    }
    eletkor() {
        let elet = this.kor;
        return elet;
    }
    getHobby() {
        let hobby = this.hobby;
        return hobby;
    }
}