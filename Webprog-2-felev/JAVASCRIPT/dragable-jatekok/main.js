const draggableElements = document.querySelectorAll(".draggable");
const droppableElements = document.querySelectorAll(".droppable");

draggableElements.forEach((elem) => {
    elem.addEventListener("dragstart", dragStart);
    // elem.addEventListener("drag", dragStart);
    // elem.addEventListener("dragend", dragEnd);
});

droppableElements.forEach((elem) => {
    //elem.addEventListener("dragenter", dragEnter);
    elem.addEventListener("dragover", dragOver);
    //elem.addEventListener("dragleave", dragLeave);
    elem.addEventListener("drop", drop);

});

function dragStart(event) {
    let id = event.target.id;
    event.dataTransfer.clearData();
    event.dataTransfer.setData("text/plain", id);
    console.log(id + "VonszolÃ¡s indul...");
}

function dragOver(event) {
    event.preventDefault();
    console.log("Felette van.");
}

function drop(event) {
    event.preventDefault();
    const draggableElementData = event.dataTransfer.getData("text");
    const droppableElementData = event.target.getAttribute("data-droppable-id");
    console.log(draggableElementData + " - " + droppableElementData + "Elejtette...");
    if (draggableElementData === droppableElementData) {
        const draggableSource = document.getElementById(draggableElementData);
        event.target.appendChild(draggableSource);
    }
}