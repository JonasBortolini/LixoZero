using LixoZero.Model.Interface;

namespace LixoZero.Persistencia.Inferface
{
    public interface IPersistencia
    {
        public IEnumerable<IObjeto> ObterTodos();
        public IObjeto ObterPorId(int id);
        public void Adicionar(IObjeto objeto);
        public void Atualizar(IObjeto objeto);
        public void Excluir(int id);
    }
}
