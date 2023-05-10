const url = "https://retoolapi.dev/LDwrUw/people";

document.addEventListener("DOMContentLoaded", () => {
    emberek_listazasa();
    const uj_ember_urlap = document.getElementById("uj_ember_urlap");
    uj_ember_urlap.addEventListener("submit", (event) => {
        event.preventDefault();
        uj_ember_felvetele();
    });
});

function uj_ember_felvetele(){
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const birth_date = document.getElementById('birth_date').value;
    const person = {
        name: name,
        email: email,
        birth_date: birth_date
    };
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function(){
        emberek_listazasa();
    };
    xhttp.open("POST", url);
    xhttp.setRequestHeader("Content-Type", "application/json");
    xhttp.send(JSON.stringify(person));
}

function emberek_listazasa() {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        const {responseText} = xhttp;
        const peopleList = JSON.parse(responseText);
        console.log(peopleList);
        let html = "";
        for (let index = 0; index < peopleList.length; index++) {
            const element = peopleList[index];
            html += `<tr>
            <td>${element.id}</td>
            <td>${element.name}</td>
            <td>${element.email}</td>
            <td>${element.birth_date}</td>
            <td><button onclick="Ember_torles(${element.id});">X</button></td>
            </tr>`;
        }
        const tablazat = document.getElementById('tablazat');
        tablazat.innerHTML = html;
    };
    xhttp.open("GET", url);
    xhttp.send();
}

function Ember_torles(id) {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        emberek_listazasa();
    };
    xhttp.open("DELETE", `${url}/${id}`);
    xhttp.send();
}