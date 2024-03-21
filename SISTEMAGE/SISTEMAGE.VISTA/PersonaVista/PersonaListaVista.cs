using SISTEMAGE.BSS;
using SISTEMAGE.VISTA.EmpleadoVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAGE.VISTA.PersonaVista
{
    public partial class PersonaListaVista : Form
    {
        public PersonaListaVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonaListaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonasBss();
        }
    }
}
