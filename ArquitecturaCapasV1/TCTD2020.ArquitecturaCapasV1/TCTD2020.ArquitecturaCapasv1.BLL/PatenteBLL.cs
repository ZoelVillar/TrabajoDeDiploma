using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV1.BE;
using TCTD2020.ArquitecturaCapasV1.BE.Composite;
using TCTD2020.ArquitecturaCapasV1.DAL;
using TCTD2020.ArquitecturaCapasV1.Servicios;

namespace TCTD2020.ArquitecturaCapasv1.BLL
{
    public class PatenteBLL : AbstractBLL<Patente>
    {

        public PatenteBLL()
        {
            _crud = new PatenteDAL();
        }


        public void SimularDatos()
        {
            var p = new Patente();
            p.Nombre = "Puede gestionar usuarios";
            p.Tipo = TipoPermiso.GestorUsuario;
           _crud.Save(p);

             p = new Patente();
            p.Nombre = "Puede gestionar permisos";
            p.Tipo = TipoPermiso.GestorPermiso;
            _crud.Save(p);

        }

       
    }
}
