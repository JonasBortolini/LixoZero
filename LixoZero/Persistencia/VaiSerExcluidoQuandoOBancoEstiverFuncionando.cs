using LixoZero.Model;

namespace LixoZero.Persistencia
{
    public static class VaiSerExcluidoQuandoOBancoEstiverFuncionando
    {
        public static IEnumerable<Usuario> Usuarios { get; set; }
        public static IEnumerable<EcoPonto> EcoPontos { get; set; }
        public static IEnumerable<Publicacao> Publicacoes { get; set; }
        public static IEnumerable<Residuo> Residuos { get; set; }

        public static void InicializarObjetos()
        {
            Residuos = new List<Residuo>
                {
                    new Residuo { Id = 1, Tipo = "Esponjas de cozinha" },
                    new Residuo { Id = 2, Tipo = "Lâminas de RAIO X" },
                    new Residuo { Id = 3, Tipo = "Cápsulas de café" },
                    new Residuo { Id = 4, Tipo = "Embalagens laminadas" },
                    new Residuo { Id = 5, Tipo = "Papel branco" },
                    new Residuo { Id = 6, Tipo = "Eletrônicos" },
                    new Residuo { Id = 7, Tipo = "Tampinhas de garrafa" },
                    new Residuo { Id = 8, Tipo = "Isopor" },
                    new Residuo { Id = 9, Tipo = "Blister" },
                    new Residuo { Id = 10, Tipo = "Pilhas e baterias" },
                    new Residuo { Id = 11, Tipo = "Material de escritório" },
                };

            EcoPontos = new List<EcoPonto>
            {
                new EcoPonto
                {
                    Id = 1,
                    Nome = "Bem Natural",
                    Endereco = "Rua Sagitarius, 664 Apto 1 - Cruzeiro",
                    HorarioFuncionamento = "Segunda a Sexta: 08h às 17h30",
                    Latitude = -29.1708685731935,
                    Longitude = -51.140157203087746,
                    Residuos = new Residuo[]
                    {
                        new Residuo { Id = 1, Tipo = "Esponjas de cozinha" },
                        new Residuo { Id = 4, Tipo = "Embalagens laminadas" }
                    }
                },
                new EcoPonto
                {
                    Id = 2,
                    Nome = "Escola de Filosofia Nova Acrópole Caxias",
                    Endereco = "Rua Pinheiro Machado, 399",
                    HorarioFuncionamento = "Segunda a Sexta: depois das 19h; Sábado: 09h às 11h30 e 13h30 às 17h30",
                    Latitude = -29.166207179111073,
                    Longitude = -51.16554944541688,
                    Residuos = new Residuo[]
                    {
                        new Residuo { Id = 1, Tipo = "Esponjas de cozinha" },
                        new Residuo { Id = 2, Tipo = "Lâminas de RAIO X" },
                        new Residuo { Id = 3, Tipo = "Cápsulas de café" },
                        new Residuo { Id = 4, Tipo = "Embalagens laminadas" },
                        new Residuo { Id = 6, Tipo = "Eletrônicos" }
                    }
                },
                new EcoPonto
                {
                    Id = 3,
                    Nome = "Mônalis Odontologia",
                    Endereco = "Rua Moreira César, 2695/301",
                    HorarioFuncionamento = "Segunda a Sexta: 09h às 11h30 e 13h30 às 17h30",
                    Latitude = -29.166349831375136,
                    Longitude =  -51.18574743192338,
                    Residuos = new Residuo[]
                    {
                        new Residuo { Id = 1, Tipo = "Esponjas de cozinha" },
                        new Residuo { Id = 2, Tipo = "Lâminas de RAIO X" },
                        new Residuo { Id = 3, Tipo = "Cápsulas de café" },
                        new Residuo { Id = 4, Tipo = "Embalagens laminadas" },
                        new Residuo { Id = 6, Tipo = "Eletrônicos" }
                    }
                },
                new EcoPonto
                {
                    Id = 4,
                    Nome = "Quintal da Salsa",
                    Endereco = "Rua Treze de Maio, 1159",
                    HorarioFuncionamento = "Segunda a Sábado: 10h às 15h",
                    Latitude = -29.171183510008852,
                    Longitude = -51.167643031923404,
                    Residuos = new Residuo[]
                    {
                        new Residuo { Id = 1, Tipo = "Esponjas de cozinha" },
                        new Residuo { Id = 3, Tipo = "Cápsulas de café" }
                    }
                },
                new EcoPonto
                {
                    Id = 5,
                    Nome = "Brinox",
                    Endereco = "Rodovia RS 122, Km 80, 32503",
                    HorarioFuncionamento = "Segunda a Sexta: 09h às 18h; Sábado: 10h às 16h50",
                    Latitude = -29.132477906170504,
                    Longitude =  -51.19351460071775,
                    Residuos = new Residuo[]
                    {
                        new Residuo { Id = 2, Tipo = "Lâminas de RAIO X" },
                        new Residuo { Id = 6, Tipo = "Eletrônicos" },
                        new Residuo { Id = 7, Tipo = "Tampinhas de garrafa" },
                        new Residuo { Id = 8, Tipo = "Isopor" },
                        new Residuo { Id = 9, Tipo = "Blister" },
                        new Residuo { Id = 10, Tipo = "Pilhas e baterias" }
                    }
                },
                new EcoPonto
                {
                    Id = 6,
                    Nome = "Tem Design",
                    Endereco = "Rua Henrique Fracasso, 559, térreo",
                    HorarioFuncionamento = "Segunda a Sexta: 08h30 às 20h",
                    Latitude = -29.13783395759237,
                    Longitude = -51.176252014108385,
                    Residuos = new Residuo[]
                    {
                        new Residuo { Id = 4, Tipo = "Embalagens laminadas" }
                    }
                }
            };

            Publicacoes = new List<Publicacao> {
                new Publicacao
                {
                    Id = 1,
                    Titulo = "Comunidade realiza mutirão de limpeza em parque local",
                    Conteudo = "No último sábado, voluntários da comunidade se reuniram no Parque da Cidade para um mutirão de limpeza. Durante o evento, foram recolhidos mais de uma tonelada de resíduos, incluindo plásticos, vidros e papel. Essa iniciativa faz parte dos esforços da comunidade em promover práticas sustentáveis e alcançar a meta de Lixo Zero.",
                    Imagem = "Imagem4.jpg",
                    Data = DateTime.Now.ToString("yyyy-MM-dd"),
                    Residuos = new List<Residuo>
                    {
                        new Residuo { Id = 5, Tipo = "Papel branco" },
                        new Residuo { Id = 7, Tipo = "Tampinhas de garrafa" }
                    }
                },
                new Publicacao
                {
                    Id = 2,
                    Titulo = "Novo projeto de reciclagem é lançado na cidade",
                    Conteudo = "A prefeitura da cidade lançou um novo projeto de reciclagem com o objetivo de incentivar a população a separar corretamente o lixo e contribuir para a preservação do meio ambiente. O projeto conta com a instalação de novos pontos de coleta seletiva e a realização de campanhas de conscientização.",
                    Imagem = "Imagem5.jpg",
                    Data = DateTime.Now.ToString("yyyy-MM-dd"),
                    Residuos = new List<Residuo>
                    {
                        new Residuo { Id = 1, Tipo = "Esponjas de cozinha" },
                        new Residuo { Id = 10, Tipo = "Pilhas e baterias" },
                    }
                },
                new Publicacao
                {
                    Id = 3,
                    Titulo = "Dicas para reduzir o consumo de plástico",
                    Conteudo = "O plástico é um dos principais poluentes do meio ambiente. Para ajudar a reduzir o consumo desse material, separamos algumas dicas simples que você pode seguir no seu dia a dia. Evite o uso de sacolas plásticas, opte por produtos com embalagens sustentáveis e recuse canudos plásticos. Pequenas atitudes fazem a diferença!",
                    Imagem = "Imagem1.jpg",
                    Data = DateTime.Now.ToString("yyyy-MM-dd"),
                    Residuos = new List<Residuo>
                    {
                        new Residuo { Id = 5, Tipo = "Papel branco" },
                        new Residuo { Id = 6, Tipo = "Eletrônicos" },
                        new Residuo { Id = 7, Tipo = "Tampinhas de garrafa" },
                    }
                },
                new Publicacao
                {
                    Id = 4,
                    Titulo = "A importância da reciclagem de eletrônicos",
                    Conteudo = "Os eletrônicos contêm diversos materiais que podem ser reciclados, como metais e plásticos. No entanto, muitas pessoas ainda descartam esses produtos de forma inadequada, causando danos ao meio ambiente. Nessa publicação, vamos falar sobre a importância da reciclagem de eletrônicos e como você pode fazer o descarte correto.",
                    Imagem = "Imagem2.jpg",
                    Data = DateTime.Now.ToString("yyyy-MM-dd"),
                    Residuos = new List<Residuo>
                    {
                        new Residuo { Id = 9, Tipo = "Blister" },
                        new Residuo { Id = 10, Tipo = "Pilhas e baterias" },
                        new Residuo { Id = 11, Tipo = "Material de escritório" },
                    }
                },
                new Publicacao
                {
                    Id = 5,
                    Titulo = "Ações sustentáveis para o dia a dia",
                    Conteudo = "Pequenas ações sustentáveis podem fazer a diferença no nosso dia a dia. Nessa publicação, vamos compartilhar algumas dicas simples que você pode seguir para contribuir com a preservação do meio ambiente. Desde economizar água e energia até reciclar corretamente o lixo, todas as atitudes são importantes.",
                    Imagem = "Imagem3.jpg",
                    Data = DateTime.Now.ToString("yyyy-MM-dd"),
                    Residuos = new List<Residuo>
                    {
                        new Residuo { Id = 2, Tipo = "Lâminas de RAIO X" },
                    }
                }
            };
        }
    }
}
