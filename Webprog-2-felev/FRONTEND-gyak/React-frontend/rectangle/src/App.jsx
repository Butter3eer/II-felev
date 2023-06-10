import { useState } from "react";
import ReactagleForm from "./components/rectangle_form";
import RectangleTable from "./components/rectangle_table";

function App() {
  
  const [ rectangles, setRectangles] = useState([
    {
      a: 3,
      b: 5,
    },
    {
      a: 10,
      b: 15,
    },
  ]);

  return (
    <main>
      <section>
        <ReactagleForm items={rectangles} setItems={setRectangles}/>
      </section>
      <section>
        <RectangleTable items={rectangles}/>
      </section>
    </main>
  );
}

export default App;
