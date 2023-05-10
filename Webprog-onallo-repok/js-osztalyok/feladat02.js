class Pont {
    constructor (x, y) {
        this.x = x;
        this.y = y;
    }

    setX (value) {
        if (value < 0) {
            window.alert("A program csak a jobbfelső síknegyedben lévő pontokat tudja kezelni.")
        }
        else {
            this.x = value;
        }
        return this;
    }

    setY (value) {
        if (value < 0) {
            window.alert("A program csak a jobbfelső síknegyedben lévő pontokat tudja kezelni.")
        }
        else {
            this.y = value;
        }
        return this;
    }

    toString() {
        return `Pont{x = ${this.x}, y = ${this.y}}`;
    }

    tavolsagAzOrigotol() {
        const tavolsag = Math.hypot(this.x, this.y);
        return tavolsag.toFixed(2);
    }

    static tavolsag(p1, p2){
        var c;
        if (p1.x > p2.x && p1.y > p2.y){
            c = Math.hypot(p1.x - p2.x, p1.y - p2.y);
        }
        else if (p1.x < p2.x && p1.y < p2.y){
            c = Math.hypot(p2.x - p1.x, p2.y - p1.y);
        }
        else if (p1.x < p2.x && p1.y > p2.y){
            c = Math.hypot(p2.x - p1.x, p1.y - p2.y);
        }
        else if (p1.x > p2.x && p1.y < p2.y){
            c = Math.hypot(p1.x - p2.x, p2.y - p1.y);
        }
        else if (p1.x == p2.x && p1.y > p2.y){
            c = p1.y - p2.y;
        }
        else if (p1.x == p2.x && p2.y > p1.y){
            c = p2.y - p1.y;
        }
        else if (p1.x > p2.x && p1.y == p2.y){
            c = p1.x - p2.x;
        }
        else if (p1.x < p2.x && p1.y == p2.y){
            c = p2.x - p1.x;
        }
        else if (p1.x == p2.x && p1.y == p2.y){
            c = 0;
        }
        return c.toFixed(2);
    }
}