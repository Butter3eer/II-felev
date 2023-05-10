class Szamologep {
    osszeg = (a, b) => {
        return parseFloat(a) + parseFloat(b);
    }
    kulombseg = (a, b) => {
        return parseFloat(a) - parseFloat(b);
    }
    szorzat = (a, b) => {
        return parseFloat(a) * parseFloat(b);
    }
    hanyados = (a, b) => {
        return parseFloat(a) / parseFloat(b);
    }
}

module.exports = Szamologep;