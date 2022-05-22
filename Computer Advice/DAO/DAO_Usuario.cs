using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Corte.CacheFolder;
using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace DAO
{
    public class DAO_Usuario : DAO_conectionSQL
    {
        SqlDataAdapter sqlDataAdapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet DataSet;
        DataTable DataTable;

        public DAO_Usuario()
        {
            sqlDataAdapter = new SqlDataAdapter("Select * from Users", GetConnection());
            SqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet = new DataSet("Gestion");
            DataTable = new DataTable();

            sqlDataAdapter.InsertCommand = SqlCommandBuilder.GetInsertCommand();
            sqlDataAdapter.DeleteCommand = SqlCommandBuilder.GetDeleteCommand();
            sqlDataAdapter.UpdateCommand = SqlCommandBuilder.GetUpdateCommand();

            LeeDBtoDS();
            DataSet.Tables[0].PrimaryKey = new DataColumn[] { DataSet.Tables[0].Columns[0] };
            DataSet.Tables.Add(DataTable);
        }

        private void LeeDBtoDS()
        {
            using (var connection = GetConnection())
            {
                var DA = new SqlDataAdapter("Select * from Users", connection);
                DA.Fill(DataSet);
            }
        }
        private void GrabarDStoDB()
        {
            using (var connection = GetConnection())
            {
                sqlDataAdapter.Update(DataSet);
            }
        }
        public bool YaExisteEnBD(string code)
        {
            return DataSet.Tables[0].Rows.Find(code) == null;
        }

        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"select * from Users where LoginName = @user and CONVERT(nvarchar(max),DECRYPTBYPASSPHRASE('password', Password)) = @password";

                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) 
                    {
                        while(reader.Read())
                        {
                            CacheDeUsuario.LoginName = reader.GetString(0);
                            CacheDeUsuario.FirstName = reader.GetString(1);
                            CacheDeUsuario.LastName = reader.GetString(2);
                            CacheDeUsuario.Position = reader.GetString(3);
                            CacheDeUsuario.Email = reader.GetString(4);
                        }
                        return true; 
                    } 
                    else { return false; } 
                }
            }
        }

        public void Registrarse(string nombreDeUsuario, string nombre, string apellido, string email, string contraseña)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"exec Registrar '@nombreDeUsuario', '@nombre', '@apellido', 'Cliente', '@email', '@contraseña'";

                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombreDeUsuario", nombreDeUsuario);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                }

            }
        }


        //public static List<Menu> ObtenerPermisos(string LoginName)
        //{
        //    List<Menu> Permisos = new List<Menu>();

        //    using(var connection = GetConnection)
        //    {
        //        connection.open();
        //        using (var command = new SqlCommand())
        //        {
        //            try
        //            {
        //                SqlCommand command = new SqlCommand("ObtenerPermisos", connection);
        //                command.Parameters.AddWithValue("LoginName", LoginName);
        //                command.CommandType = CommandType.StoredProcedure;

        //                XmlReader LeerXml = command.ExecuteXmlReader();

        //                while(LeerXml.Read())
        //                {
        //                    XDocument doc = XDocument.Load(LeerXml);

        //                    if (doc.Element("permisos") != null)
        //                    {
        //                        Permisos = doc.Element("permisos").Element("DetalleMenu") == null ? new List<Menu>() :
        //                        (from menu in doc.Element("permisos").Element("DetalleMenu").Elements("Menu")
        //                         select new Menu()
        //                         {
        //                             Nombre = menu.Element("Nombre").value,
        //                             Icono = menu.Element("Icono").value,
        //                             ListaSubMenu = menu.Element("DetalleMenu") == null ? new List<Menu>() :

        //                             (from submenu in menu.Element("DetalleMenu").Elements("Submenu")
        //                              select new Submenu()
        //                              {
        //                                  Nombre = submenu.Element("Nombre").Value
        //                                  NombreFormulario = submenu.Element("NombreFormulario").Value
        //                              }

        //                             ).ToList()
        //                         }
        //                        ).ToList();
        //                    }
        //                }
        //            }
        //            catch (Exception)
        //            {

        //                throw;
        //            }
        //        }
          
        //    }

        //}


    }
}
