using LixoZero.Model;
using LixoZero.Model.Interface;
using LixoZero.Persistencia.Inferface;

namespace LixoZero.Persistencia
{
    public class PublicacaoPersistencia : IPersistencia
    {
        public IEnumerable<IObjeto> ObterTodos()
        {
            //aqui vai ser feito todo o tratamento para transformar os dados do banco em objetos
            //Publicação
            //Residuo

            return VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes;
        }

        public IObjeto ObterPorId(int id) => ObterTodos().FirstOrDefault(r => r.Id.Equals(id)) ?? new Publicacao();

        public IEnumerable<IObjeto> ObterPorIdDoResiduo(int id) => ObterTodos().OfType<Publicacao>().Where(r => r.Residuos.Any(r => r.Id.Equals(id)));

        public void Adicionar(IObjeto objeto)
        {
            //aqui sera feito o tratamento para salvar no banco 
            //lembrar de atualizar o Residuo nas tabelas de relacionamento

            objeto.Id = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes.OrderBy(r => r.Id).LastOrDefault().Id + 1;
            var publicacoes = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes.ToList();
            publicacoes.Add(objeto as Publicacao);

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes = publicacoes;
        }

        public void Atualizar(IObjeto objeto)
        {
            //aqui sera feito o tratamento para atualizar no banco
            //lembrar de atualizar o Residuo nas tabelas de relacionamento

            var publicacoes = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes.ToList();
            publicacoes.Remove(publicacoes.FirstOrDefault(r => r.Id.Equals(objeto.Id)));
            publicacoes.Add(objeto as Publicacao);

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes = publicacoes.OrderBy(r => r.Id);
        }

        public void Excluir(int id)
        {
            //aqui sera feito o tratamento para excluir no banco
            //lembrar de atualizar o Residuo nas tabelas de relacionamento

            var publicacoes = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes.ToList();
            publicacoes.Remove(publicacoes.FirstOrDefault(r => r.Id.Equals(id)));

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.Publicacoes = publicacoes;
        }
    }
}
