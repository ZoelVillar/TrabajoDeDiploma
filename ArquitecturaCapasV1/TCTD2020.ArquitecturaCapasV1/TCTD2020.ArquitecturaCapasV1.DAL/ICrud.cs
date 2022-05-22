using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV1.BE;

namespace TCTD2020.ArquitecturaCapasV1.DAL
{
    public interface ICrud<T> where T: Entity
    {
        T GetById(Guid id);
        IList<T> GetAll();
        void Save(T entity);
        void Delete(T entity);



    }
}
