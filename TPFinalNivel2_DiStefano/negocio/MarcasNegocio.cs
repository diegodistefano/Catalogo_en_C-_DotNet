using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcasNegocio
    {
        public List<Marcas> listar()
        {
            List<Marcas> lista = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }
    }
}
