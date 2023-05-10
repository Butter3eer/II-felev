
document.getElementById("start").addEventListener("click", start);

function start(){
    const a = document.getElementById("a").value;
    const b = document.getElementById("b").value;

    function nagyobb(a, b){
        if (a > b){
            return a;
        }
        if (b > a){
            return b;
        }
    }
    document.getElementById("megoldas").innerHTML = "A nagyobb szám: " + nagyobb(a, b);
}

document.getElementById("startC").addEventListener("click", startC);
document.getElementById("add").addEventListener("click", listaAdd);

const lista = [];

function startC(){

    function listaMax(lista){
        a = Math.max(...lista);
        return a;
    }

    function listaMin(lista){
        b = Math.min(...lista);
        return b;
    }

    document.getElementById("listaMax").innerHTML = "A lista legnagyobb eleme: " + listaMax(lista);
    document.getElementById("listaMin").innerHTML = "A lista legkisebb eleme: " + listaMin(lista);
}

function listaAdd(){
    const element = document.getElementById("item").value;
    const item = parseInt(element);

    lista.push(item);
    document.getElementById("item").value = "";
}
