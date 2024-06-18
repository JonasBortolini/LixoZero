import React, { useEffect, useState } from 'react';
import '../styles/ecopontos.css';
import Map from '../components/map';
import { getEcopontos, getResiduos } from '../services/apiService';

function Ecopontos() {
    const [ecopontos, setEcopontos] = useState([]);
    const [residuos, setResiduos] = useState([]);
    const [selectedResiduo, setSelectedResiduo] = useState('');

    useEffect(() => {
        const fetchData = async () => {
            try {
                const [ecopontosData, residuosData] = await Promise.all([
                    getEcopontos(),
                    getResiduos()
                ]);
                setEcopontos(ecopontosData);
                setResiduos(residuosData);
            } catch (error) {
                console.error('Error fetching data:', error);
            }
        };

        fetchData();
    }, []);

    const handleChange = (event) => {
        setSelectedResiduo(event.target.value);
    }

    const ecopontosFiltrados = selectedResiduo
        ? ecopontos.filter(ecoponto =>
            ecoponto.residuos.some(residuo => residuo.tipo === selectedResiduo)
        )
        : ecopontos;

    return (
        <div className='ecopontos-container'>
            <h1 className="h1">Ecopontos</h1>
            <select onChange={handleChange}>
                <option value="" hidden>Selecione um resíduo</option>
                {residuos.map(residuo => (
                    <option key={residuo.Id} value={residuo.tipo}>{residuo.tipo}</option>
                ))}
            </select>
            <Map ecopontos={ecopontosFiltrados} />
        </div>
    );
}

export default Ecopontos;
