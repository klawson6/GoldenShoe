import { useState } from 'react';
import DataProvider from '../Providers/DataProvider'

export default function ShoeList() {

    function FetchShoes() {
        DataProvider.getShoes()
            .then(data => {
                setShoes(data)
            });
    }
    function FetchShoe(id) {
        DataProvider.getShoe(id)
            .then(data => {
                console.log(data)
                setShoe(data)
            });
    }

    const [shoes, setShoes] = useState();
    const [shoe, setShoe] = useState();

    return (
        <div>
            <p>{JSON.stringify(shoes)}</p>
            <button onClick={FetchShoes}>Click</button>
            <p>{JSON.stringify(shoe)}</p>
            <button onClick={() => FetchShoe(1)}>Click for one</button>
        </div>

    );
}