using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles_ProgramadoPor_ElvisLi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Pract1-Controles Programado por: Elvis Li";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDia.Text) ||
                string.IsNullOrWhiteSpace(txtMes.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                 "Datos incompletos",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            string fechaCompleta = txtDia.Text + " - " + txtMes.Text + " - " + txtAnio.Text;
            lblResultado.Text = fechaCompleta;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana");
            MessageBox.Show("Cerrando");
            this.Close();
        }
    }
}