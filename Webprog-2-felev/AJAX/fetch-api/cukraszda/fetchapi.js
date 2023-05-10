const companyInput = document.getElementById("companyName");
const productInput = document.getElementById("productName");
const darabInput = document.getElementById("darab");
const fizetendoInput = document.getElementById("fizetendo");
const idHidden = document.getElementById("id");
const kartyakDiv = document.getElementById("kartyak");
var maxRendelesSzam = 0;
var actPageNum = 1;

const createButton = document.getElementById("create");
createButton.addEventListener("click", createRendeles);
const readButton = document.getElementById("read");
readButton.addEventListener("click", readAllRendeles);
const updateButton = document.getElementById("update");
updateButton.addEventListener("click", updateRendeles);

function createRendeles() {
  let url = "https://retoolapi.dev/tFpb3p/data";
  const data = getDataJSON();

  fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  })
    .then((response) => response.json())
    .then((data) => {
      console.log("Success:", data);
    })
    .catch((error) => {
      console.error("Error:", error);
    });
}

function getDataJSON() {
  let company = companyInput.value;
  let product = productInput.value;
  let darab = darabInput.value;
  let fizetendo = fizetendoInput.value;
  let rendeles = `{"name":"${company}","product":"${product}","darab":"${darab}","fizetendo": "${fizetendo}"}`;
  return JSON.parse(rendeles);
}

function getDataJSON_to_modify() {
  let company = companyInput.value;
  let product = productInput.value;
  let darab = darabInput.value;
  let fizetendo = fizetendoInput.value;
  let id = idHidden.value;
  let rendeles = `{"id":"${id}","name":"${company}","product":"${product}","darab":"${darab}","fizetendo": "${fizetendo}"}`;
  return JSON.parse(rendeles);
}

function readAllRendeles() {
  removeAllChild(kartyakDiv);
  let url = "https://retoolapi.dev/tFpb3p/data";
  fetch(url)
    .then((response) => response.json())
    .then((data) => {
      maxRendelesSzam = data.length;
      showPageRendeles(data);
    });
}

function showPageRendeles(data) {
  let tol = 10 * actPageNum - 10;
  let ig = actPageNum * 10;
  if (ig > data.length) {
    ig = data.length;
  }
  for (let index = tol + 1; index <= ig; index++) {
    const element = data[index];
    let rendeles = document.createElement("div");
    rendeles.innerHTML = rendelesToHTML(element);
    kartyakDiv.appendChild(rendeles);
  }
}

function rendelesToHTML(element) {
  let text = `<div class="card m-2">
              <div class="card-header">
                  <h5>${element.name}</h5>
              </div>
              <div class="card-body">
                  <h5 class="card-title">${element.product} (${element.darab})</h5>
                  <h5>${element.fizetendo} HUF</h5>
              </div>
                <button class="btn btn-secondary" name="kivalaszt" id="${element.id}" onclick="betolt(this)">Kijelölés</button>
              </div>`;
  return text;
}

function betolt(params) {
  beviteli_mezok_torlese();
  let url = "https://retoolapi.dev/tFpb3p/data/" + params.id;
  fetch(url)
    .then((response) => response.json())
    .then((data) => inputMezokFeltoltese(data));
}

function inputMezokFeltoltese(data) {
  companyInput.value = data["name"];
  darabInput.value = data["darab"];
  productInput.value = data["product"];
  fizetendoInput.value = data["fizetendo"];
  idHidden.value = data["id"];
  removeAllChild(kartyakDiv);
}

function beviteli_mezok_torlese() {
  companyInput.value = "";
  darabInput.value = "";
  fizetendoInput.value = "";
}

function removeAllChild(parent) {
  while (parent.firstChild) {
    parent.removeChild(parent.lastChild);
  }
}

function updateRendeles() {
  let data = getDataJSON_to_modify();
  console.log(data);
  let url = "https://retoolapi.dev/tFpb3p/data/" + data.id;
  putData(url, data).then((data) => {
    console.log(data);
  });
}

async function putData(url = "", data = {}) {
  console.log(data);

  const response = await fetch(url, {
    method: "PUT",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  })
  .then((response) => response.json())
}
