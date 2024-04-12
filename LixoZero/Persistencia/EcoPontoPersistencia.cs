using LixoZero.Model;
using LixoZero.Model.Interface;
using LixoZero.Persistencia.Inferface;

namespace LixoZero.Persistencia
{
    public class EcoPontoPersistencia : IPersistencia
    {
        public IEnumerable<IObjeto> ObterTodos()
        {
            //aqui vai ser feito todo o tratamento para transformar os dados do banco em objetos
            //EcoPonto
            //Residuo

            return VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos;
        }

        public IObjeto ObterPorId(int id) => ObterTodos().FirstOrDefault(r => r.Id.Equals(id)) ?? new EcoPonto();
        public IEnumerable<IObjeto> ObterPorIdDoResiduo(int id) => ObterTodos().OfType<EcoPonto>().Where(r => r.Residuos.Any(r => r.Id.Equals(id)));

        public void Adicionar(IObjeto objeto)
        {
            //aqui sera feito o tratamento para salvar no banco 
            //lembrar de atualizar o Residuo nas tabelas de relacionamento

            objeto.Id = VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos.OrderBy(r => r.Id).LastOrDefault().Id + 1;
            var ecoPontos = VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos.ToList();
            ecoPontos.Add(objeto as EcoPonto);

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos = ecoPontos;
        }

        public void Atualizar(IObjeto objeto)
        {
            //aqui sera feito o tratamento para atualizar no banco
            //lembrar de atualizar o Residuo nas tabelas de relacionamento

            var ecoPontos = VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos.ToList();
            ecoPontos.Remove(ecoPontos.FirstOrDefault(r => r.Id.Equals(objeto.Id)));
            ecoPontos.Add(objeto as EcoPonto);

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos = ecoPontos.OrderBy(r => r.Id);
        }

        public void Excluir(int id)
        {
            //aqui sera feito o tratamento para excluir no banco
            //lembrar de atualizar o Residuo nas tabelas de relacionamento

            var ecoPontos = VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos.ToList();
            ecoPontos.Remove(ecoPontos.FirstOrDefault(r => r.Id.Equals(id)));

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.EcoPontos = ecoPontos;
        }
    }
}
