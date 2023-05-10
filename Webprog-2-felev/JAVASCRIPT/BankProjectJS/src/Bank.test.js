const Bank = require('./Bank');
let b;

beforeEach(() => {
    b = new Bank();
    b.ujSzamla("Gipsz Jakab", "1234");
});

test('ujSzamla - Létező számlaszámmal hiba', () => {
    expect(() => {
        b.ujSzamla("Teszt Elek", "1234");
    }).toThrow();
})

test('ujSzamla - Létező névvel nincs hiba', () => {
    expect(() => {
        b.ujSzamla("Gipsz Jakab", "5678")
    }).not.toThrow();
});