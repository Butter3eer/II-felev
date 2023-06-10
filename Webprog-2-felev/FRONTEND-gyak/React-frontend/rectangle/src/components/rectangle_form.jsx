import { useRef } from "react";

function ReactagleForm(props) {
    const { items, setItems } = props;
    const labelStyle = {
        color: "olive",
        fontWeight: "bold",
    };

    const a = useRef();
    const b = useRef();
    const CreateRectangle = (event) => {
        event.preventDefault();
        const rectangle = {
            a: parseInt(a.current.value),
            b: parseInt(b.current.value),
        };
        setItems([...items, rectangle]);
    }

    return ( <form onSubmit={(event) => CreateRectangle(event)}>
        <h1>Téglalap felvétele</h1>
        <div>
            <label style={labelStyle} htmlFor="a_input">A:</label>
            <input type="number" required min={1} id="a_input" ref={a}/>
        </div>
        <div>
            <label style={labelStyle} htmlFor="b_input">B:</label>
            <input type="number" required min={1} id="b_input" ref={b}/>
        </div>
        <button type="submit">Felvétel</button>
    </form> );
}

export default ReactagleForm;