function RectangleTableRow(props) {
    const { rectangle } = props;
    const { a, b } = rectangle;
    const kerulet = 2 * (a + b);
    const terulet = a * b;
    
    return ( 
        <tr>
            <td>{a}</td>
            <td>{b}</td>
            <td>{kerulet}</td>
            <td>{terulet}</td>
        </tr>
     );
}

export default RectangleTableRow;