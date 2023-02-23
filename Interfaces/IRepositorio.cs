using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int Id);

        void Insere(T entidade);

        void Excluir(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    }
}