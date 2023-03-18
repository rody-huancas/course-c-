using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Categoria
    {
        public static DataTable Listar_ca(string cTexto)
        {
            D_Categoria Datos = new D_Categoria();
            return Datos.Listar_ca(cTexto);
        }

        public static string Guardar_ca(int Opcion, E_Categoria oCa)
        {
            D_Categoria Datos = new D_Categoria();
            return Datos.Guardar_ca(Opcion, oCa);
        }
    }
}
