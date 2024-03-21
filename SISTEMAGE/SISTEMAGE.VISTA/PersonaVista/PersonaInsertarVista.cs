using SISTEMAGE.BSS;
using SISTEMAGE.MODELO;
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

namespace SISTEMAGE.VISTA.PersonaVista
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();

        private void button2_Click(object sender, EventArgs e)
        {
            PERSONA p = new PERSONA();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;

            bss.InsertarPersonasBss(p);

            MessageBox.Show("Persona registrada!");
        }
    }
}
