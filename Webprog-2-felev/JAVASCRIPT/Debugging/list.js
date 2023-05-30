const list = [];

function FillListWithRandomNumbers(min, max, db) {
    ClearList();
    for (var i = 0; i < db; i++) {
        const element = GenerateRandomNumber(min, max);
        list.push(element)
    }
}

function GenerateRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function FindMaxList() { 
    if (list.length == 0){
        return null;
    }
    let max = list[0];
    for (let i = 1; i < list.length; i++) {
        const current = list[i];
        if (current > max) {
            max = current;
        }
    }
    return max;
}

function ClearList() {
    while (list.length > 0) {
        list.pop();
    }
}