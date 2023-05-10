const url = "https://retoolapi.dev/FF5oPF/WizardsAndWitches";

document.addEventListener("DOMContentLoaded", () => {
    WizardsAndWitchesListing();
    const newWizardsAndWitchesForm = document.getElementById("newWizardsAndWitchesForm");
    newWizardsAndWitchesForm.addEventListener("submit", (event) => {
        event.preventDefault();
        AddNewWizardsAndWitches();
    });
});

function AddNewWizardsAndWitches(){
    const name = document.getElementById('name').value;
    const house = document.getElementById('house').value;
    const patronus = document.getElementById('patronus').value;
    const wandCore = document.getElementById('wandCore').value;
    const profession = document.getElementById('profession').value;
    const WizardsAndWitches = {
        name: name,
        house: house,
        patronus: patronus,
        "wand core": wandCore,
        Profession: profession
    };
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function(){
        WizardsAndWitchesListing();
    };
    xhttp.open("POST", url);
    xhttp.setRequestHeader("Content-Type", "application/json");
    xhttp.send(JSON.stringify(WizardsAndWitches));
}

function WizardsAndWitchesListing() {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        const {responseText} = xhttp;
        const WizardsAndWitchesList = JSON.parse(responseText);
        console.log(WizardsAndWitchesList);
        let html = "";
        for (let index = 0; index < WizardsAndWitchesList.length; index++) {
            const WizAndWitch = WizardsAndWitchesList[index];
            html += `<tr>
            <td class="text-center">${WizAndWitch.id}</td>
            <td class="text-center">${WizAndWitch.name}</td>
            <td class="text-center">${WizAndWitch.house}</td>
            <td class="text-center">${WizAndWitch.patronus}</td>
            <td class="text-center">${WizAndWitch["wand core"]}</td>
            <td class="text-center">${WizAndWitch.Profession}</td>
            <td class="text-center"><button class="btn btn-success" onclick="WizardAndWitchesDelete(${WizAndWitch.id});">X</button></td>
            </tr>`;
        }
        const tablazat = document.getElementById('tablazat');
        tablazat.innerHTML = html;
    };
    xhttp.open("GET", url);
    xhttp.send();
}

function WizardAndWitchesDelete(id) {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        WizardsAndWitchesListing();
    };
    xhttp.open("DELETE", `${url}/${id}`);
    xhttp.send();
}