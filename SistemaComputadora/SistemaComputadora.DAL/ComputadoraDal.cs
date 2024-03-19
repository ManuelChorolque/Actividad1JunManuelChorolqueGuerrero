using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaComputadora.DAL
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadorasDal()
        {
            string consulta = "select * from computadora";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

       
    }
}
