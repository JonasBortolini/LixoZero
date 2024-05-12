import React from 'react';
import { useParams } from 'react-router-dom';
import '../styles/educacional-detalhe.css'
import ImagemLixo from '../assets/ImagenLixo.png';

const Publicacoes = [
  {
      "Id": 1,
      "Titulo": "A importância da reciclagem",
      "Subtitulo": "Subtitulo da reciclagem",
      "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque pulvinar laoreet egestas. Sed auctor, orci at iaculis maximus, elit lacus volutpat nulla, id ultrices orci ante eget justo. Nullam sapien nunc, vehicula vitae varius quis, maximus lacinia nibh. Morbi dapibus sodales dui, a mattis augue efficitur non. Nunc faucibus diam at tortor bibendum, ut interdum quam semper. Praesent vitae turpis vel nunc scelerisque commodo a a ligula. Cras sed nulla in arcu consequat porta in at diam. Curabitur porttitor magna magna, nec iaculis urna blandit vulputate. Aenean ut elit sit amet mauris pharetra porta in in libero. Praesent et ex vitae orci hendrerit rutrum. Donec vel commodo lectus. Nam scelerisque odio vel molestie pellentesque. Vestibulum a dictum est. Fusce condimentum, dui eu ornare vestibulum, lorem odio placerat ante, mattis dignissim urna tortor rhoncus enim. Ut sit amet quam ipsum. Integer maximus risus eget neque auctor placerat. Vestibulum tincidunt ligula lectus, eget accumsan orci venenatis scelerisque. Duis posuere mi nisi, et blandit nibh aliquam vitae. Donec sagittis arcu quis faucibus vestibulum. Interdum et malesuada fames ac ante ipsum primis in faucibus. In lacus neque, vehicula at posuere non, ultricies ac ex. In eget enim lacus. Etiam congue ipsum eu pulvinar luctus. Nulla ut fermentum ex. Nunc vulputate, elit in hendrerit commodo, arcu metus congue nunc, sed consectetur leo justo quis nisl. Donec pretium magna sed gravida sagittis. Fusce interdum nulla sed elit suscipit ultrices. Fusce at nibh nec nibh ullamcorper iaculis sed eget erat. Suspendisse elementum, elit non porta sagittis, odio lorem congue lacus, id pharetra ligula ex ut augue. Maecenas nibh magna, pharetra et ex non, pharetra finibus augue. Praesent sodales metus sit amet maximus consectetur. Donec porta aliquam libero. Donec arcu nisl, consectetur ac auctor sed, porta nec metus. Suspendisse potenti. Aliquam sed purus vel massa pretium pellentesque at at augue. Curabitur eu felis velit. Curabitur fermentum elit vitae velit euismod, a vulputate orci suscipit. Vestibulum a tempor ipsum. Suspendisse quis dolor eu quam lacinia semper vitae ut turpis. Donec diam felis, congue quis consectetur nec, efficitur quis magna. Phasellus vel ligula sit amet erat accumsan ultrices sed quis lorem. Mauris malesuada sed turpis in imperdiet. Vivamus lobortis, enim et lobortis tempus, elit nunc tristique eros, ut tempus orci purus nec ligula. Duis accumsan eget ante vel bibendum. Nullam in ex ullamcorper, ullamcorper ante et, tempor erat.",
      "Imagem": "ImagemLixo.png",
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
      "Subtitulo": "Subtitulo da reciclagem",
      "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque pulvinar laoreet egestas. Sed auctor, orci at iaculis maximus, elit lacus volutpat nulla, id ultrices orci ante eget justo. Nullam sapien nunc, vehicula vitae varius quis, maximus lacinia nibh. Morbi dapibus sodales dui, a mattis augue efficitur non. Nunc faucibus diam at tortor bibendum, ut interdum quam semper. Praesent vitae turpis vel nunc scelerisque commodo a a ligula. Cras sed nulla in arcu consequat porta in at diam. Curabitur porttitor magna magna, nec iaculis urna blandit vulputate. Aenean ut elit sit amet mauris pharetra porta in in libero. Praesent et ex vitae orci hendrerit rutrum. Donec vel commodo lectus. Nam scelerisque odio vel molestie pellentesque. Vestibulum a dictum est. Fusce condimentum, dui eu ornare vestibulum, lorem odio placerat ante, mattis dignissim urna tortor rhoncus enim. Ut sit amet quam ipsum. Integer maximus risus eget neque auctor placerat. Vestibulum tincidunt ligula lectus, eget accumsan orci venenatis scelerisque. Duis posuere mi nisi, et blandit nibh aliquam vitae. Donec sagittis arcu quis faucibus vestibulum. Interdum et malesuada fames ac ante ipsum primis in faucibus. In lacus neque, vehicula at posuere non, ultricies ac ex. In eget enim lacus. Etiam congue ipsum eu pulvinar luctus. Nulla ut fermentum ex. Nunc vulputate, elit in hendrerit commodo, arcu metus congue nunc, sed consectetur leo justo quis nisl. Donec pretium magna sed gravida sagittis. Fusce interdum nulla sed elit suscipit ultrices. Fusce at nibh nec nibh ullamcorper iaculis sed eget erat. Suspendisse elementum, elit non porta sagittis, odio lorem congue lacus, id pharetra ligula ex ut augue. Maecenas nibh magna, pharetra et ex non, pharetra finibus augue. Praesent sodales metus sit amet maximus consectetur. Donec porta aliquam libero. Donec arcu nisl, consectetur ac auctor sed, porta nec metus. Suspendisse potenti. Aliquam sed purus vel massa pretium pellentesque at at augue. Curabitur eu felis velit. Curabitur fermentum elit vitae velit euismod, a vulputate orci suscipit. Vestibulum a tempor ipsum. Suspendisse quis dolor eu quam lacinia semper vitae ut turpis. Donec diam felis, congue quis consectetur nec, efficitur quis magna. Phasellus vel ligula sit amet erat accumsan ultrices sed quis lorem. Mauris malesuada sed turpis in imperdiet. Vivamus lobortis, enim et lobortis tempus, elit nunc tristique eros, ut tempus orci purus nec ligula. Duis accumsan eget ante vel bibendum. Nullam in ex ullamcorper, ullamcorper ante et, tempor erat.",
      "Imagem": "ImagemLixo.png",
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
      "Subtitulo": "Subtitulo da reciclagem",
      "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque pulvinar laoreet egestas. Sed auctor, orci at iaculis maximus, elit lacus volutpat nulla, id ultrices orci ante eget justo. Nullam sapien nunc, vehicula vitae varius quis, maximus lacinia nibh. Morbi dapibus sodales dui, a mattis augue efficitur non. Nunc faucibus diam at tortor bibendum, ut interdum quam semper. Praesent vitae turpis vel nunc scelerisque commodo a a ligula. Cras sed nulla in arcu consequat porta in at diam. Curabitur porttitor magna magna, nec iaculis urna blandit vulputate. Aenean ut elit sit amet mauris pharetra porta in in libero. Praesent et ex vitae orci hendrerit rutrum. Donec vel commodo lectus. Nam scelerisque odio vel molestie pellentesque. Vestibulum a dictum est. Fusce condimentum, dui eu ornare vestibulum, lorem odio placerat ante, mattis dignissim urna tortor rhoncus enim. Ut sit amet quam ipsum. Integer maximus risus eget neque auctor placerat. Vestibulum tincidunt ligula lectus, eget accumsan orci venenatis scelerisque. Duis posuere mi nisi, et blandit nibh aliquam vitae. Donec sagittis arcu quis faucibus vestibulum. Interdum et malesuada fames ac ante ipsum primis in faucibus. In lacus neque, vehicula at posuere non, ultricies ac ex. In eget enim lacus. Etiam congue ipsum eu pulvinar luctus. Nulla ut fermentum ex. Nunc vulputate, elit in hendrerit commodo, arcu metus congue nunc, sed consectetur leo justo quis nisl. Donec pretium magna sed gravida sagittis. Fusce interdum nulla sed elit suscipit ultrices. Fusce at nibh nec nibh ullamcorper iaculis sed eget erat. Suspendisse elementum, elit non porta sagittis, odio lorem congue lacus, id pharetra ligula ex ut augue. Maecenas nibh magna, pharetra et ex non, pharetra finibus augue. Praesent sodales metus sit amet maximus consectetur. Donec porta aliquam libero. Donec arcu nisl, consectetur ac auctor sed, porta nec metus. Suspendisse potenti. Aliquam sed purus vel massa pretium pellentesque at at augue. Curabitur eu felis velit. Curabitur fermentum elit vitae velit euismod, a vulputate orci suscipit. Vestibulum a tempor ipsum. Suspendisse quis dolor eu quam lacinia semper vitae ut turpis. Donec diam felis, congue quis consectetur nec, efficitur quis magna. Phasellus vel ligula sit amet erat accumsan ultrices sed quis lorem. Mauris malesuada sed turpis in imperdiet. Vivamus lobortis, enim et lobortis tempus, elit nunc tristique eros, ut tempus orci purus nec ligula. Duis accumsan eget ante vel bibendum. Nullam in ex ullamcorper, ullamcorper ante et, tempor erat.",
      "Imagem": "ImagemLixo.png",
      "Data": "2024-05-05",
      "Slug": "reducao-do-consumo-de-plastico",
      "Residuos": [
          {"Id": 1, "Tipo": "Plástico"}
      ]
  },
  {
      "Id": 4,
      "Titulo": "Como reciclar papel corretamente",
      "Subtitulo": "Subtitulo da reciclagem",
      "Conteudo": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque pulvinar laoreet egestas. Sed auctor, orci at iaculis maximus, elit lacus volutpat nulla, id ultrices orci ante eget justo. Nullam sapien nunc, vehicula vitae varius quis, maximus lacinia nibh. Morbi dapibus sodales dui, a mattis augue efficitur non. Nunc faucibus diam at tortor bibendum, ut interdum quam semper. Praesent vitae turpis vel nunc scelerisque commodo a a ligula. Cras sed nulla in arcu consequat porta in at diam. Curabitur porttitor magna magna, nec iaculis urna blandit vulputate. Aenean ut elit sit amet mauris pharetra porta in in libero. Praesent et ex vitae orci hendrerit rutrum. Donec vel commodo lectus. Nam scelerisque odio vel molestie pellentesque. Vestibulum a dictum est. Fusce condimentum, dui eu ornare vestibulum, lorem odio placerat ante, mattis dignissim urna tortor rhoncus enim. Ut sit amet quam ipsum. Integer maximus risus eget neque auctor placerat. Vestibulum tincidunt ligula lectus, eget accumsan orci venenatis scelerisque. Duis posuere mi nisi, et blandit nibh aliquam vitae. Donec sagittis arcu quis faucibus vestibulum. Interdum et malesuada fames ac ante ipsum primis in faucibus. In lacus neque, vehicula at posuere non, ultricies ac ex. In eget enim lacus. Etiam congue ipsum eu pulvinar luctus. Nulla ut fermentum ex. Nunc vulputate, elit in hendrerit commodo, arcu metus congue nunc, sed consectetur leo justo quis nisl. Donec pretium magna sed gravida sagittis. Fusce interdum nulla sed elit suscipit ultrices. Fusce at nibh nec nibh ullamcorper iaculis sed eget erat. Suspendisse elementum, elit non porta sagittis, odio lorem congue lacus, id pharetra ligula ex ut augue. Maecenas nibh magna, pharetra et ex non, pharetra finibus augue. Praesent sodales metus sit amet maximus consectetur. Donec porta aliquam libero. Donec arcu nisl, consectetur ac auctor sed, porta nec metus. Suspendisse potenti. Aliquam sed purus vel massa pretium pellentesque at at augue. Curabitur eu felis velit. Curabitur fermentum elit vitae velit euismod, a vulputate orci suscipit. Vestibulum a tempor ipsum. Suspendisse quis dolor eu quam lacinia semper vitae ut turpis. Donec diam felis, congue quis consectetur nec, efficitur quis magna. Phasellus vel ligula sit amet erat accumsan ultrices sed quis lorem. Mauris malesuada sed turpis in imperdiet. Vivamus lobortis, enim et lobortis tempus, elit nunc tristique eros, ut tempus orci purus nec ligula. Duis accumsan eget ante vel bibendum. Nullam in ex ullamcorper, ullamcorper ante et, tempor erat.",
      "Imagem": "ImagemLixo.png",
      "Data": "2024-05-04",
      "Slug": "como-reciclar-papel-corretamente",
      "Residuos": [
          {"Id": 2, "Tipo": "Papel"}
      ]
  }
]

function EducacionalDetalhe() {

  let { slug  } = useParams();
  console.log(slug );

  const publicacao = Publicacoes.find(pub => pub.Slug === slug );

  if (!publicacao) {
    return <div>Publicação não encontrada</div>;
  }

  return (
    <div className="publicacao">
      <h1 className='h1'>{publicacao.Titulo}</h1>
      <img src={ImagemLixo} alt={publicacao.Titulo} />
      <p className='subtitle'>{publicacao.Subtitulo}</p>
      <ul>
        {publicacao.Residuos.map(residuo => (
          <li key={residuo.Id}>{residuo.Tipo}</li>
        ))}
      </ul>
      <p className='date'>{publicacao.Data}</p>
      <p className='content'>{publicacao.Conteudo}</p>
    </div>
  );
}

export default EducacionalDetalhe;
