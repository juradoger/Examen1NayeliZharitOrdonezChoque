using SISTEMAGE.DAL;
using SISTEMAGE.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAGE.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadosBss()
        {
            return dal.ListarEmpleadosDal();
        }
        public void InsertarEmpleadosBss(EMPLEADO emp)
        {
            dal.InsertarEmpleadoDal(emp);
        }
        public EMPLEADO ObtenerIdBss(int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }
        public void EditarEmpleadosBss(EMPLEADO empl)
        {
            dal.EditarEmpleadoDal(empl);
        }
        public void EliminarEmpleadosBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
