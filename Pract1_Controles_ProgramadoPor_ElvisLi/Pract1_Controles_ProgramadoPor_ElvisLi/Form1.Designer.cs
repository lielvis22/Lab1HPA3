namespace Pract1_Controles_ProgramadoPor_ElvisLi
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(170, 126);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 22);
            this.txtDia.TabIndex = 0;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(170, 207);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 22);
            this.txtMes.TabIndex = 1;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(170, 288);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 22);
            this.txtAnio.TabIndex = 2;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(105, 126);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(34, 16);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Día: ";
            this.lblDia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(105, 207);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(39, 16);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes: ";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(105, 291);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(34, 16);
            this.lblAnio.TabIndex = 5;
            this.lblAnio.Text = "Año:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(381, 200);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Enviar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(381, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(378, 129);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(82, 16);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "La fecha es: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(466, 132);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblResultado;
    }
}

