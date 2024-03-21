using DAL;
using SISTEMAGE.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAGE.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPersonasDal(PERSONA persona)
        {
            string consulta = $"insert into persona values ('{persona.Nombre.ToString()}', '{persona.Apellido.ToString()}', 'Activo')";
            conexion.Ejecutar(consulta);
        }
        public PERSONA ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            PERSONA pers = new PERSONA();
            if (tabla.Rows.Count > 0)
            {
                pers.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                pers.Nombre = tabla.Rows[0]["nombre"].ToString();
                pers.Apellido = tabla.Rows[0]["apellido"].ToString();
            }
            return pers;

        }
        public void EditarPersonaDal(PERSONA p)
        {
            string consulta = $"update persona set nombre= '{p.Nombre.ToString()}', Apellido= '{p.Apellido.ToString()}'";
            conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);

        }
    }
}
