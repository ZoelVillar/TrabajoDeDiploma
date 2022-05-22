using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV1.DAL;
using TCTD2020.ArquitecturaCapasV1.BE;

namespace TCTD2020.ArquitecturaCapasv1.BLL
{
    public abstract class AbstractBLL<T> : ICrud<T> where T:Entity
    {

        protected ICrud<T> _crud;

   
        public void Delete(T entity)
        {
            _crud.Delete(entity);
        }

        public IList<T> GetAll()
        {
            return _crud.GetAll();
        }

        public T GetById(Guid id)
        {
            return _crud.GetById(id);
        }

        public void Save(T entity)
        {
            _crud.Save(entity);
                 
        }
    }
}
