import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import '../styles/educacional-detalhe.css';
import ImagemLixo from '../assets/ImagenLixo.png';
import { getPublicacaoById } from '../services/apiService';

function EducacionalDetalhe() {
  let { id } = useParams();
  const [publicacao, setPublicacao] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const publicacaoData = await getPublicacaoById(id);
        setPublicacao(publicacaoData);
      } catch (error) {
        console.error('Error fetching data:', error);
        setError(error);
      } finally {
        setLoading(false);
      }
    };
    fetchData(); 
  }, [id]);

  if (loading) {
    return <div>Carregando...</div>;
  }

  if (error) {
    return <div>Erro ao carregar a publicação: {error.message}</div>;
  }

  if (!publicacao) {
    return <div>Publicação não encontrada</div>;
  }

  return (
    <div className="publicacao">
      <h1 className='h1'>{publicacao.titulo}</h1>
      <img src={ImagemLixo} alt={publicacao.titulo} />
      <p className='subtitle'>{publicacao.subtitulo}</p>
      <ul>
        {publicacao.residuos && publicacao.residuos.map(residuo => (
          <li key={residuo.id}>{residuo.tipo}</li>
        ))}
      </ul>
      <p className='date'>{publicacao.data}</p>
      <p className='content'>{publicacao.conteudo}</p>
    </div>
  );
}

export default EducacionalDetalhe;
