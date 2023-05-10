const Szamologep = require('./szamologep');

console.log("Hello world!");

const a = 10;
const b = 23;
const szamologep = new Szamologep();
const osszeg = szamologep.osszeg(a, b);
console.log(osszeg);