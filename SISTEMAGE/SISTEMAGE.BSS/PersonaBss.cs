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
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonasBss()
        {
            return dal.ListarPersonasDal();
        }
        public void InsertarPersonasBss(PERSONA persona)
        {
            dal.InsertarPersonasDal(persona);
        }
        public PERSONA ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaBss(PERSONA person)
        {
            dal.EditarPersonaDal(person);
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
