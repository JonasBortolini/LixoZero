import React, { useState } from 'react';
import '../styles/ecopontos.css'
import Map from '../components/map';

const Residuos = [
    {
        "Id": 1,
        "Tipo": "Vidro"
    },
    {
        "Id": 2,
        "Tipo": "Metal"
    },
    {
        "Id": 3,
        "Tipo": "Papel"
    },
    {
        "Id": 4,
        "Tipo": "Plástico"
    },
    {
        "Id": 5,
        "Tipo": "Orgânico"
    },
    {
        "Id": 6,
        "Tipo": "Eletrônico"
    },
    {
        "Id": 7,
        "Tipo": "Outro"
    }
]

const Ecoponto = [
    {
        "Id": 1,
        "Nome": "BEM NATURAL",
        "Endereco": "Rua Sagitarius, 664 Apto 1 - Cruzeiro",
        "HorarioFuncionamento": "Seg - sex: 08h às 17h30",
        "Latitude": -29.183654,
        "Longitude": -51.174491,
        "Residuos": [
            {"Id": 1, "Tipo": "Vidro"},
            {"Id": 2, "Tipo": "Metal"}
        ]
    },
    {
        "Id": 2,
        "Nome": "ESCOLA DE FILOSOFIA NOVA ACRÓPOLE CAXIAS",
        "Endereco": "Rua Pinheiro Machado, 399",
        "HorarioFuncionamento": "Seg - sex: depois das 19h\nSáb -  09h ás 11h30 e 13h30 ás 17h30",
        "Latitude": -29.167805,
        "Longitude": -51.179597,
        "Residuos": [
            {"Id": 3, "Tipo": "Papel"},
            {"Id": 4, "Tipo": "Plástico"},
            {"Id": 5, "Tipo": "Orgânico"}
        ]
    },
    {
        "Id": 3,
        "Nome": "MONALIS ODONTOLOGIA",
        "Endereco": "Rua Moreira César, 2695/301",
        "HorarioFuncionamento": "Seg - sex: 09h ás 11h30 e 13h30 ás 17h30",
        "Latitude": -29.175991,
        "Longitude": -51.175052,
        "Residuos": [
            {"Id": 6, "Tipo": "Eletrônico"}
        ]
    },
    {
        "Id": 4,
        "Nome": "QUINTAL DA SALSA",
        "Endereco": "Rua Treze de Maio, 1159",
        "HorarioFuncionamento": "Seg - sáb: 10h às 15h",
        "Latitude": -29.162546,
        "Longitude": -51.191789,
        "Residuos": [
            {"Id": 7, "Tipo": "Outro"}
        ]
    },
    {
        "Id": 5,
        "Nome": "BRINOX",
        "Endereco": "Rodovia RS 122, Km 80, 32503",
        "HorarioFuncionamento": "Seg - sex: 09h ás 18h\nSáb - 10h ás 16h50",
        "Latitude": -29.160734,
        "Longitude": -51.145432,
        "Residuos": [
            {"Id": 3, "Tipo": "Papel"},
        ]
    },
    {
        "Id": 6,
        "Nome": "TEM DESIGN",
        "Endereco": "Rua Henrique Fracasso, 559, térreo",
        "HorarioFuncionamento": "Seg - sex: 08h30 ás 20h",
        "Latitude": -29.177302,
        "Longitude": -51.176704,
        "Residuos": [
            {"Id": 4, "Tipo": "Plástico"},
            {"Id": 5, "Tipo": "Orgânico"}
        ]
    },
    {
        "Id": 7,
        "Nome": "Ecoponto Caxias",
        "Endereco": "Rua Vereador Mário Pezzi, 1929 - Exposição, Caxias do Sul - RS, 95084-110",
        "HorarioFuncionamento": "Seg - sex: 08h às 18h",
        "Latitude": -29.169905,
        "Longitude": -51.198696,
        "Residuos": [
            {"Id": 1, "Tipo": "Vidro"},
            {"Id": 3, "Tipo": "Papel"},
            {"Id": 4, "Tipo": "Plástico"}
        ]
    },
    {
        "Id": 8,
        "Nome": "Ecoponto Fátima",
        "Endereco": "Rua Luiz Michelon, 1033 - Fátima, Caxias do Sul - RS, 95076-820",
        "HorarioFuncionamento": "Seg - sáb: 08h às 17h",
        "Latitude": -29.160364,
        "Longitude": -51.183768,
        "Residuos": [
            {"Id": 1, "Tipo": "Vidro"},
            {"Id": 2, "Tipo": "Metal"}
        ]
    },
    {
        "Id": 9,
        "Nome": "Ecoponto Desvio Rizzo",
        "Endereco": "Rua Padre Angelo Muratore, 650 - Desvio Rizzo, Caxias do Sul - RS, 95110-240",
        "HorarioFuncionamento": "Seg - sex: 09h às 17h",
        "Latitude": -29.173963,
        "Longitude": -51.181223,
        "Residuos": [
            {"Id": 3, "Tipo": "Papel"},
        ]
    }
]

function Ecopontos() {

    const [selectedResiduo, setSelectedResiduo] = useState('');

    const handleChange = (event) => {
        setSelectedResiduo(event.target.value);
    }

    const ecopontosFiltrados = Ecoponto.filter(ecoponto =>
        ecoponto.Residuos.some(residuo => residuo.Tipo === selectedResiduo)
    );
    
    return <div className='ecopontos-container'>
        <h1 className="h1">Ecopontos</h1>
        <select onChange={handleChange}>
            <option value="" hidden>Selecione um resíduo</option>
            {Residuos.map(residuo => (
                <option key={residuo.Id} value={residuo.Tipo}>{residuo.Tipo}</option>
            ))}
        </select>
        <Map ecopontos={ecopontosFiltrados} />
    </div>;
}

export default Ecopontos;
