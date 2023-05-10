document.addEventListener("DOMContentLoaded", () => {
    const xhttp = new XMLHttpRequest();
    const bekezdes = document.getElementById('bekezdes');

    xhttp.onload = function (){
        console.log(xhttp);
        bekezdes.innerHTML = xhttp.responseText;
    }

    xhttp.open('GET', "/ajax01.txt");
    xhttp.send();
})