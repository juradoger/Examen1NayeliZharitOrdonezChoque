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
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadosDal()
        {
            string consulta = "select * from empleado";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public void InsertarEmpleadoDal(EMPLEADO empleado)
        {
            string consulta = $"insert into empleado values({empleado.IdPersona}, '{empleado.Puesto.ToString()}', {empleado.Salario}, '{empleado.FechaContratacion.ToString()}')";
            conexion.Ejecutar(consulta);
        }
        public EMPLEADO ObtenerEmpleadoId(int id)
        {
            string consulta = "select * from empleado where idempleado=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            EMPLEADO empl = new EMPLEADO();
            if (tabla.Rows.Count > 0)
            {
                empl.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                empl.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                empl.Puesto = tabla.Rows[0]["puesto"].ToString();
                empl.Salario = Convert.ToDecimal(tabla.Rows[0]["salario"]);
                empl.FechaContratacion = Convert.ToDateTime(tabla.Rows[0]["fechacontratacion"]);
            }
            return empl;

        }
        public void EditarEmpleadoDal(EMPLEADO empleado)
        {
            string consulta = $"update empleado set persona= '{empleado.IdPersona.ToString()}', puesto= '{empleado.Puesto.ToString()}', salario= {empleado.Salario}, fechacontratacion= '{empleado.FechaContratacion}'";
            conexion.Ejecutar(consulta);
        }
        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleado where idempleado=" + id;
            conexion.Ejecutar(consulta);

        }
    }
}
