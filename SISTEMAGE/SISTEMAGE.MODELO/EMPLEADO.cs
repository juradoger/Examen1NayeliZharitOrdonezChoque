using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAGE.MODELO
{
    public class EMPLEADO
    {
        public int IdEmpleado { get; set; }
        public int IdPersona { get; set; }  
        public string Puesto { get; set; }  
        public decimal Salario { get; set; }    
        public DateTime FechaContratacion { get; set; } 
    }
}
