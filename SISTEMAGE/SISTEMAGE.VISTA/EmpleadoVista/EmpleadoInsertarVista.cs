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

namespace SISTEMAGE.VISTA.EmpleadoVista
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        EmpleadoBss bsse = new EmpleadoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            EMPLEADO empl = new EMPLEADO();
            empl.IdPersona = IdPersonaSeleccionada;
            empl.Puesto = textBox2.Text;
            empl.Salario = Convert.ToDecimal(textBox3.Text);
            empl.FechaContratacion = dateTimePicker1.Value;
            bsse.InsertarEmpleadosBss(empl);
            MessageBox.Show("Empleado registrado");

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
