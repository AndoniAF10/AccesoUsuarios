using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AccesoDatosPermisos
{
    public class UsuariosAccesoDatos
    {
        ConexionAccesoDatos _conexion;
        public UsuariosAccesoDatos()
        {

            try
            {
                _conexion = new ConexionAccesoDatos("localhost", "root", "123456789", "permisos", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }
    }
}
