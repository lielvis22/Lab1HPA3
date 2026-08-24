namespace Pract2_Descuento_ProgramadoPor_ElvisLi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblDescuentoPorcentaje = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtDescuentoPorcentaje = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblValorVenta.Location = new System.Drawing.Point(94, 97);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(77, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Venta";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(94, 160);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(82, 16);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento $";
            // 
            // lblDescuentoPorcentaje
            // 
            this.lblDescuentoPorcentaje.AutoSize = true;
            this.lblDescuentoPorcentaje.Location = new System.Drawing.Point(94, 234);
            this.lblDescuentoPorcentaje.Name = "lblDescuentoPorcentaje";
            this.lblDescuentoPorcentaje.Size = new System.Drawing.Size(87, 16);
            this.lblDescuentoPorcentaje.TabIndex = 2;
            this.lblDescuentoPorcentaje.Text = "Descuento %";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(94, 298);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(74, 16);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(412, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(412, 174);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(412, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(215, 97);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenta.TabIndex = 7;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(215, 160);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento.TabIndex = 8;
            // 
            // txtDescuentoPorcentaje
            // 
            this.txtDescuentoPorcentaje.Location = new System.Drawing.Point(215, 234);
            this.txtDescuentoPorcentaje.Name = "txtDescuentoPorcentaje";
            this.txtDescuentoPorcentaje.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoPorcentaje.TabIndex = 9;
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(215, 298);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.Size = new System.Drawing.Size(100, 22);
            this.txtVentaFinal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtDescuentoPorcentaje);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescuentoPorcentaje);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblDescuentoPorcentaje;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtDescuentoPorcentaje;
        private System.Windows.Forms.TextBox txtVentaFinal;
    }
}

