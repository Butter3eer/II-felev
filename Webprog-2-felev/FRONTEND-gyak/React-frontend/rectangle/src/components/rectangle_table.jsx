import RectangleTableRow from "./rectangleTableRow";

function RectangleTable(props) {
    const {items} = props;
    const tableRows = items.map( (item) =>  <RectangleTableRow rectangle={item}/>);

    return ( <>
        <h2>Téglalapok</h2>
        <table>
            <thead>
                <tr>
                    <th>A</th>
                    <th>B</th>
                    <th>K</th>
                    <th>T</th>
                </tr>
            </thead>
            <tbody>
                {tableRows}
            </tbody>
        </table> 
    </>);
}

export default RectangleTable;