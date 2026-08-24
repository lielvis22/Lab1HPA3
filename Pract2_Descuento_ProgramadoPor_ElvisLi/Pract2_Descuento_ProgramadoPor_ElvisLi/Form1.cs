using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2_Descuento_ProgramadoPor_ElvisLi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Descuentos – Programado por: Elvis Li";
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            decimal ValorVentas;
            decimal DescuentoPorcentaje;
            decimal DescuentoVentas;
            decimal VentasTotales;

            // Validar que el textbox no esté vacío
            if (string.IsNullOrWhiteSpace(txtValorVenta.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor de venta.",
                                 "Campo vacío",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            // Validar que el valor ingresado sea numérico
            if (!decimal.TryParse(txtValorVenta.Text, out ValorVentas))
            {
                MessageBox.Show("Por favor, ingrese un valor de venta válido.",
                                 "Dato inválido",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            // Determinar el porcentaje de descuento según el rango de venta
            if (ValorVentas >= 500)
            {
                DescuentoPorcentaje = 0.30m;
            }
            else if (ValorVentas >= 300 && ValorVentas <= 499)
            {
                DescuentoPorcentaje = 0.20m;
            }
            else if (ValorVentas >= 100 && ValorVentas <= 299)
            {
                DescuentoPorcentaje = 0.10m;
            }
            else
            {
                DescuentoPorcentaje = 0;
            }

            // Calcular descuento y venta final
            DescuentoVentas = ValorVentas * DescuentoPorcentaje;
            VentasTotales = ValorVentas - DescuentoVentas;

            // Mostrar resultados
            txtVentaFinal.Text = VentasTotales.ToString();
            txtDescuentoPorcentaje.Text = DescuentoPorcentaje.ToString();
            txtDescuento.Text = DescuentoVentas.ToString();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtValorVenta.Text = "";
            txtDescuento.Text = "";
            txtDescuentoPorcentaje.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A continuación se cerrará la aplicación",
                             "Cerrar Aplicación",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            this.Close();
        }
    }
}