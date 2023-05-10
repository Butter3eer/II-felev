const base_url = "https://retoolapi.dev/2bEWtP/people";

$(function () {
    listPeople();

    $("#personForm").submit(function (e) { 
        e.preventDefault();
        const name = $("#name_input").val();
        const email = $("#email_input").val();
        const job = $("#job_input").val();
        const person = {
            name: name,
            email: email,
            job: job
        }
        $.post(base_url, person,
            function (data, textStatus, jqXHR) {
                if (textStatus === "success") {
                    $("#name_input").val("");
                    $("#email_input").val("");
                    $("#job_input").val("");
                    listPeople();
                }
            },
            "json"
        );
    });
});

function listPeople(){
    $.get(base_url,
        function (data) {
            console.log(data);
            let html = "";
            data.forEach(person => {
                html += `<tr>
                    <td>${person.id}</td>
                    <td>${person.name}</td>
                    <td>${person.email}</td>
                    <td>${person.job}</td>
                    <td><i onclick="deletePerson(${person.id})" class="fa-solid fa-delete-left" style="color:red"></i></td>
                </tr>`;
            })
            $("#peopleTable").html(html);
        },
        "json"
    );
}

function deletePerson(personId){
    $.ajax({
        type: "DELETE",
        url: `${base_url}/${personId}`,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            if (textStatus === "success"){
                listPeople();
            };
        }
    });
}