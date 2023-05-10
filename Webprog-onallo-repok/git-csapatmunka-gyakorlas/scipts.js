function calculateTriangle() {
  var side1 = parseFloat(document.getElementById("side1").value);
  var side2 = parseFloat(document.getElementById("side2").value);
  var side3 = parseFloat(document.getElementById("side3").value);
  if (side1 !== "" && side2 !== "" && side3 !== ""){
    if (canItBeATriangle(side1, side2, side3)) {
      var perimeter = (side1 + side2 + side3).toFixed(2);
      var s = perimeter / 2;
      var area = (Math.sqrt(s * (s - side1) * (s - side2) * (s - side3))).toFixed(2);
      addRow(side1, side2, side3, perimeter, area)
      document.getElementById("side1").value = ""
      document.getElementById("side2").value = ""
      document.getElementById("side3").value = ""
    }
    else {
      alert("Hibás értékek!")
      document.getElementById("side1").value = ""
      document.getElementById("side2").value = ""
      document.getElementById("side3").value = ""
    }
  }
}

function canItBeATriangle(side1, side2, side3) {
  if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1) {
    return false;
  } else {
    return true;
  }
}

function addRow(side1, side2, side3, perimeter, area) {
  let tableBody=document.getElementById("tableBody")
  let tableRow = document.createElement("tr");
  tableRow.innerHTML = `
    <td>${side1}</td>
    <td>${side2}</td>
    <td>${side3}</td>
    <td>${area}</td>
    <td>${perimeter}</td>
  `;
  tableBody.appendChild(tableRow);
}