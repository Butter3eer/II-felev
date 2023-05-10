class Etel {
    constructor (nev, ar){
        this.nev = nev;
        this.ar = ar;
        this.kategoria = "";
        this.osszetevok = [];
    }

    setKategoria (kateg) {
        this.kategoria = kateg;
        return this;
    }

    setOsszetevok (lista) {
        this.osszetevok = lista;
        return this;
    }
}