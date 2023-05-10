class Bank{
    #szamlak = [];

    ujSzamla = (nev, szamlaszam) => {
        const index = this.#szamlak.findIndex(elem => elem.szamlaszam == szamlaszam)
        if  (index > -1){
            throw new Error();
        }
        
        const szamla = {
            nev: nev,
            szamlaszam: szamlaszam
        }
        this.#szamlak.push(szamla);
    }
}

module.exports = Bank;