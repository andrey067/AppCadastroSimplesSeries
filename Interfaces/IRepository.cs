using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Lista();
        T RetornaPorId(string id);
        void Insere(T entidade);
        void Exclui(string id);
        void Atualiza(string id, T entidade);
        string ProximoId();
    }
}