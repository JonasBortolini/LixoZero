import React, { useEffect, useState } from 'react';
import '../styles/educacional.css'
import ImagemLixo from '../assets/ImagenLixo.png';
import { getPublicacoes, getResiduos } from '../services/apiService';


function Educacional() {
    const [publicacoes, setPublicacoes] = useState([]);
    const [residuos, setResiduos] = useState([]);
    const [selectedResiduo, setSelectedResiduo] = useState('');

    useEffect(() => {
        const fetchData = async () => {
            try {
                const [ecopontosData, residuosData] = await Promise.all([
                    getPublicacoes(),
                    getResiduos()
                ]);
                setResiduos(residuosData);
                setPublicacoes(ecopontosData);
            } catch (error) {
                console.error('Error fetching data:', error);
            }
        };

        fetchData();
    }, []);

    const handleChange = (event) => {
        setSelectedResiduo(event.target.value);
    };

    const publicacoesFiltradas = selectedResiduo ? 
        publicacoes.filter(publicacao => publicacao.residuos.some(residuo => residuo.tipo === selectedResiduo)) : 
        publicacoes;

    return <div className='educacional-container'>
        <h1 className="h1">Educacional</h1>
        <select onChange={handleChange}>
            <option value="" hidden>Selecione um resíduo</option>
            {residuos.map(residuo => (
                <option key={residuo.Id} value={residuo.tipo}>{residuo.tipo}</option>
            ))}
        </select>
        <div className='publicacoes'>
            {publicacoesFiltradas.map(publicacao => (
                <a className='publicacao' href={`educacional/${publicacao.id}`} key={publicacao.id}>
                    <img src={ImagemLixo} alt={publicacao.titulo} />
                    <h3 className='title'>{publicacao.titulo}</h3>
                    <p className='date'>Data: {publicacao.data}</p>
                    {publicacao.residuos.length > 0 && (
                        <div className="categories">
                            {publicacao.residuos.map(residuo => (
                                <p className='category'>{residuo.tipo}</p>
                            ))}
                        </div>
                    )}
                </a>
            ))}
        </div>
    </div>; 
}

export default Educacional;
