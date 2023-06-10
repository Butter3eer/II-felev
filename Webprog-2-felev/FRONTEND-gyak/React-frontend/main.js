const rectangles = [];

document.addEventListener("DOMContentLoaded", () => {
    document.getElementById("rectangle_form").addEventListener("submit", (event) => {
        event.preventDefault();
        Create_rectangle();
        Refresh_Table();
    })
})

function Create_rectangle() { 
    const a_input = document.getElementById("a_input");
    const b_input = document.getElementById("b_input");
    const a = parseInt(a_input.value);
    const b = parseInt(b_input.value);

    const rectangle = {
        a: a,
        b: b,
        kerulet: function () {
            return 2 * (this.a + this.b);
        },
        terulet: function () {
            return this.a * this.b;
        }
    }
    rectangles.push(rectangle);
}

function Refresh_Table() {
    let html = "";
    rectangles.forEach((rectangle) => {
        html += `<tr>
            <td>${rectangle.a}</td>
            <td>${rectangle.b}</td>
            <td>${rectangle.kerulet()}</td>
            <td>${rectangle.terulet()}</td>
        </tr>`
    })

    const rectangle_table = document.getElementById("rectangle_table");
    rectangle_table.innerHTML = html;
}