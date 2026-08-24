namespace Pract3_Estructura_ProgramadoPor_ElvisLi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa los valores y selecciona una opcion";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(102, 142);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 22);
            this.txtValor1.TabIndex = 1;
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Location = new System.Drawing.Point(245, 142);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(0, 16);
            this.lblSimbolo.TabIndex = 2;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(327, 142);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 3;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(476, 147);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(14, 16);
            this.lblIgual.TabIndex = 4;
            this.lblIgual.Text = "=";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(550, 147);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDivision);
            this.groupBox1.Controls.Add(this.rbMultiplicacion);
            this.groupBox1.Controls.Add(this.rbResta);
            this.groupBox1.Controls.Add(this.rbSuma);
            this.groupBox1.Location = new System.Drawing.Point(102, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 192);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBox";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(27, 34);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(63, 20);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(26, 72);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(64, 20);
            this.rbResta.TabIndex = 1;
            this.rbResta.TabStop = true;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(26, 110);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rbMultiplicacion.TabIndex = 2;
            this.rbMultiplicacion.TabStop = true;
            this.rbMultiplicacion.Text = "Multiplicación";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(27, 150);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(76, 20);
            this.rbDivision.TabIndex = 7;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "División";
            this.rbDivision.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

