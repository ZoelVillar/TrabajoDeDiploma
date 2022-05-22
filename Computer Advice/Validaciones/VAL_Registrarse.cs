using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validaciones
{
    public class VAL_Registrarse
    {
        public bool ValidarNombreYApellido(string data) { Regex ValNombre = new Regex(@"^[a-zA-Z]+$"); return ValNombre.IsMatch(data); }
        public bool ValidarNombreDeUsuario(string data) { Regex valNomUsu = new Regex(@"^[A-Za-z]+$"); return valNomUsu.IsMatch(data); }

        public bool ValidarEmail(string data)
        {
            return new EmailAddressAttribute().IsValid(data);

        }
        public bool ValidarContraseña(string data)
        {
            Regex ValPass = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&].{8,}$");
            //Regex ValPass = new Regex(@"^[a-zA-Z]+$");
            return ValPass.IsMatch(data);
        }
    }
}
