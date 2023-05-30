document.getElementById("random_number_form").addEventListener("submit", (event) => {
    event.preventDefault();

    const min = parseInt(document.getElementById('min').value);
    const max = parseInt(document.getElementById('max').value);
    const db = parseInt(document.getElementById('db').value);

    //debugger;

    FillListWithRandomNumbers(min, max, db);

    const random_numbers = document.getElementById('random_numbers');
    random_numbers.innerHTML = list.join(", ");
})

document.getElementById("find_max").addEventListener("click", (event) => {
    const max = FindMaxList();
    const max_value = document.getElementById('max_value');
    if (max === null) {
        max_value.innerHTML = "";
    } else {
        max_value.innerHTML = max;
    }
    //max_value.innerHTML = (max === null ? "" : max);
})