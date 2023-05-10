const baseUrl = "https://cataas.com"
const apiUrl = "https://cataas.com/cat?json=true";

function macska_betolt(){
    const kep = document.getElementById('kep');

    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        const {responseText} = xhttp;
        console.log('responseText: ', responseText);
        const responseObject = JSON.parse(responseText);
        console.log('responseObject: ', responseObject);
        const imgUrl = responseObject.url;
        const imgSrc = baseUrl + imgUrl;
        kep.setAttribute("src", imgSrc);
    };
    xhttp.open('GET', apiUrl);
    xhttp.send();
}

document.addEventListener('DOMContentLoaded', () => {
    macska_betolt();
    const gomb = document.getElementById('gomb');
    gomb.addEventListener("click", macska_betolt);
});