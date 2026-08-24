using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract3_Estructura_ProgramadoPor_ElvisLi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PRÁCTICA DE ESTRUCTURA IF";
            lblSimbolo.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor1;
            decimal valor2;
            decimal resultado;

            if (string.IsNullOrWhiteSpace(txtValor1.Text) ||
                string.IsNullOrWhiteSpace(txtValor2.Text))
            {
                MessageBox.Show("Por favor, complete ambos valores.",
                                 "Campos incompletos",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtValor1.Text, out valor1) ||
                !decimal.TryParse(txtValor2.Text, out valor2))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.",
                                 "Datos inválidos",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            if (!rbSuma.Checked && !rbResta.Checked && !rbMultiplicacion.Checked && !rbDivision.Checked)
            {
                MessageBox.Show("Por favor, seleccione una operación.",
                                 "Operación no seleccionada",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            if (rbSuma.Checked)
            {
                lblSimbolo.Text = "+";
                resultado = valor1 + valor2;
            }
            else if (rbResta.Checked)
            {
                lblSimbolo.Text = "-";
                resultado = valor1 - valor2;
            }
            else if (rbMultiplicacion.Checked)
            {
                lblSimbolo.Text = "*";
                resultado = valor1 * valor2;
            }
            else
            {
                lblSimbolo.Text = "/";
                if (valor2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.",
                                     "Error de operación",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    return;
                }
                resultado = valor1 / valor2;
            }

            txtResultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuación se cerrará la aplicación",
                             "Cerrar Aplicación",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            this.Close();
        }
    }
}