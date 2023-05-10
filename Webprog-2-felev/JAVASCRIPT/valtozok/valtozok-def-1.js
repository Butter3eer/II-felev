a = 10; //semmi és var között nincs deklarálás beli külömbség, lehet őket újra deklarálni egsiket a másikra
var b = 5; //globális változó, segít elkülöníteni amikor létrehozunk egy változót attól amikor csak értéket adunk neki, de nem kötelező kiírni
let c = 7; //nem lehet újda deklarálni, létező változót se lehet vele újra deklarálni ha az nem volt eddig LET, csak blokkokban létezik, NEM globális
const d = 15; //értéke nem változhat, constans rövidítése, nem lehet újra deklarálni

console.log("a:", a);
console.log("b:", b);
console.log("c:", c);
console.log("d:", d);

const lista = []; //nem az értékét definiálod constansnak, hanem az elemei lesznek azok
lista.push(3, 5, 7);
console.log(lista);

if (true) {
    var elVar = 5;
    let elLet = 5;
}