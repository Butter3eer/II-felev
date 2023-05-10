const Szamologep = require('./szamologep')
document.addEventListener("DOMContentLoaded", () =>{
    const a_input = document.getElementById('a_input');
    const b_input = document.getElementById('b_input');
    const btnPlusz = document.getElementById('btn_plusz');
    const btnMinusz = document.getElementById('btn_minusz');
    const btnSzoroz = document.getElementById('btn_szoroz');
    const btnOszt = document.getElementById('btn_oszt');
    const eredmeny = document.getElementById('eredmeny');
    const szamolo = new Szamologep();
    btnPlusz.addEventListener("click", () => {eredmeny.innerHTML = szamolo.osszeg(a_input.value, b_input.value)});
    btnMinusz.addEventListener("click", () => {eredmeny.innerHTML = szamolo.kulombseg(a_input.value, b_input.value)});
    btnSzoroz.addEventListener("click", () => {eredmeny.innerHTML = szamolo.szorzat(a_input.value, b_input.value)});
    btnOszt.addEventListener("click", () => {eredmeny.innerHTML = szamolo.hanyados(a_input.value, b_input.value)});
})