using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public static class Conexion
    {
        
        private const string _servidor = @"JUAN-PC\SQLEXPRESS";
        private const string _baseDatos = "ComercioDB";

        public static string CadenaConexion
        {
            //get { return @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-prueba1-20150504012553.mdf;Initial Catalog=aspnet-prueba1-20150504012553;Integrated Security=True"; }
            get { return @"Data Source=" + _servidor + ";Initial Catalog=" + _baseDatos + ";Integrated Security=true"; }
        }
    }
}
