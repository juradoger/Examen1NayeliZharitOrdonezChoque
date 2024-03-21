using SISTEMAGE.BSS;
using SISTEMAGE.MODELO;
using SISTEMAGE.VISTA.PersonaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SISTEMAGE.VISTA.EmpleadoVista
{
    public partial class EmpleadoEditarVista : Form
    {
        public EmpleadoEditarVista()
        {
            InitializeComponent();
        }

        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        int idx = 0;
        EMPLEADO empl = new EMPLEADO();
        EmpleadoBss bssp = new EmpleadoBss();

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            empl = bssp.ObtenerIdBss(idx);
            textBox2.Text = empl.Puesto;
            textBox3.Text = empl.Salario.ToString();
            dateTimePicker1.Value = empl.FechaContratacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empl.IdPersona = IdPersonaSeleccionada;
            empl.Puesto = textBox2.Text;
            empl.Salario = Convert.ToDecimal(textBox3.Text);
            empl.FechaContratacion = dateTimePicker1.Value;
            bssp.EditarEmpleadosBss(empl);
            MessageBox.Show("Datos actualizados");

        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListaVista fr = new PersonaListaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;

            }
        }
    }

}
