using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IGenerica<T> where T : class
    {
        T Obtener(int index);
        void Agregar(T modelo);

        public int Total();
    }
}