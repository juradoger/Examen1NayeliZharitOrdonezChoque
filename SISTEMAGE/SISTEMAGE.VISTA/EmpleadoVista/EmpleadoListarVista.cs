using SISTEMAGE.BSS;
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
    public partial class EmpleadoListarVista : Form
    {
        public EmpleadoListarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss bssp = new EmpleadoBss();
        public static int IdPersonaSeleccionada = 0;
        EmpleadoBss bss = new EmpleadoBss();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoListarVista_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssp.ListarEmpleadosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdPersonaSelecciionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista fr = new EmpleadoEditarVista(IdPersonaSelecciionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadosBss();
            }
        }
        EmpleadoBss bssz = new EmpleadoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSelecciionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("Esta seguro de eliminar este empleado?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarEmpleadosBss(IdEmpleadoSelecciionada);
                dataGridView1.DataSource = bssz.ListarEmpleadosBss();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadosBss();
            }
        }
    }
}
