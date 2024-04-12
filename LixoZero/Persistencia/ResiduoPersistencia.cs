using LixoZero.Model;
using LixoZero.Model.Interface;
using LixoZero.Persistencia.Inferface;

namespace LixoZero.Persistencia
{
    public class ResiduoPersistencia : IPersistencia
    {
        public IEnumerable<IObjeto> ObterTodos()
        {
            //aqui vai ser feito todo o tratamento para transformar os dados do banco em objetos
            //Residuo

            return VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos;
        }

        public IObjeto ObterPorId(int id) => ObterTodos().FirstOrDefault(r => r.Id.Equals(id)) ?? new Residuo();
 
        public void Adicionar(IObjeto objeto)
        {
            //aqui sera feito o tratamento para salvar no banco 

            objeto.Id = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos.OrderBy(r => r.Id).LastOrDefault().Id + 1;
            var residuos = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos.ToList();
            residuos.Add(objeto as Residuo);

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos = residuos;
        }

        public void Atualizar(IObjeto objeto)
        {
            //aqui sera feito o tratamento para atualizar no banco

            var residuos = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos.ToList();
            residuos.Remove(residuos.FirstOrDefault(r => r.Id.Equals(objeto.Id)));
            residuos.Add(objeto as Residuo);

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos = residuos.OrderBy(r => r.Id);
        }

        public void Excluir(int id)
        {
            //aqui sera feito o tratamento para excluir no banco

            var residuos = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos.ToList();
            residuos.Remove(residuos.FirstOrDefault(r => r.Id.Equals(id)));

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.Residuos = residuos;
        }
    }
}
