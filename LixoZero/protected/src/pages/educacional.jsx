import React, { useState } from 'react';
import '../styles/educacional.css'

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

const Publicacoes = [
    {
        "Id": 1,
        "Titulo": "A importância da reciclagem",
        "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed gravida sapien quis suscipit ultricies. Cras pulvinar sem et ante eleifend, vel aliquam ipsum congue.",
        "Imagem": "imagem1.jpg",
        "Data": "2024-05-07",
        "Slug": "a-importancia-da-reciclagem",
        "Residuos": [
            {"Id": 1, "Tipo": "Plástico"},
            {"Id": 2, "Tipo": "Papel"}
        ]
    },
    {
        "Id": 2,
        "Titulo": "Novas tecnologias para tratamento de resíduos",
        "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum eget nisi eu nisl iaculis interdum. Quisque nec pretium elit, nec venenatis mi. Integer at justo leo. ",
        "Imagem": "imagem2.jpg",
        "Data": "2024-05-06",
        "Slug": "novas-tecnologias-para-tratamento-de-residuos",
        "Residuos": [
            {"Id": 3, "Tipo": "Vidro"},
            {"Id": 4, "Tipo": "Metal"}
        ]
    },
    {
        "Id": 3,
        "Titulo": "Redução do consumo de plástico",
        "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce commodo, magna ut tincidunt lobortis, libero magna vehicula nunc, nec pellentesque quam ipsum et sapien.",
        "Imagem": "imagem3.jpg",
        "Data": "2024-05-05",
        "Slug": "reducao-do-consumo-de-plastico",
        "Residuos": [
            {"Id": 1, "Tipo": "Plástico"}
        ]
    },
    {
        "Id": 4,
        "Titulo": "Como reciclar papel corretamente",
        "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam id felis a justo vestibulum sollicitudin eu vitae elit. Nam sed ex at lectus ultricies rutrum.",
        "Imagem": "imagem4.jpg",
        "Data": "2024-05-04",
        "Slug": "como-reciclar-papel-corretamente",
        "Residuos": [
            {"Id": 2, "Tipo": "Papel"}
        ]
    }
]

function Educacional() {

    const [filtroResiduo, setFiltroResiduo] = useState(null);

    const handleFiltroChange = (event) => {
        setFiltroResiduo(event.target.value);
    };

    const publicacoesFiltradas = filtroResiduo ? 
        Publicacoes.filter(publicacao => publicacao.Residuos.some(residuo => residuo.Tipo === filtroResiduo)) : 
        Publicacoes;

    return <div className='educacional-container'>
        <h1 className="h1">Educacional</h1>
        <select onChange={handleFiltroChange}>
            <option value="" hidden>Selecione um resíduo</option>
            {Residuos.map(residuo => (
                <option key={residuo.Id} value={residuo.Tipo}>{residuo.Tipo}</option>
            ))}
        </select>
        <div className='publicacoes'>
            {publicacoesFiltradas.map(publicacao => (
                <a className='publicacao' href={`educacional/${publicacao.Slug}`} key={publicacao.Id}>
                    <img src={publicacao.Imagem} alt={publicacao.Titulo} />
                    <h3 className='title'>{publicacao.Titulo}</h3>
                    <p className='date'>Data: {publicacao.Data}</p>
                    {publicacao.Residuos.length > 0 && (
                        <p className='category'>Categoria: {publicacao.Residuos[0].Tipo}</p>
                    )}
                </a>
            ))}
        </div>
    </div>; 
}

export default Educacional;
