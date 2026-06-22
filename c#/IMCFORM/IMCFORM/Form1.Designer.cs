namespace IMCFORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcularclick = new Button();
            lblIngresarPeso = new Label();
            lblIngresarAltura = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            lblIMC = new Label();
            lblResultado = new Label();
            lblAnalisis = new Label();
            SuspendLayout();
            // 
            // btnCalcularclick
            // 
            btnCalcularclick.Location = new Point(43, 202);
            btnCalcularclick.Name = "btnCalcularclick";
            btnCalcularclick.Size = new Size(148, 47);
            btnCalcularclick.TabIndex = 0;
            btnCalcularclick.Text = "Calcular";
            btnCalcularclick.UseVisualStyleBackColor = true;
            btnCalcularclick.Click += button1_Click;
            // 
            // lblIngresarPeso
            // 
            lblIngresarPeso.AutoSize = true;
            lblIngresarPeso.Location = new Point(43, 41);
            lblIngresarPeso.Name = "lblIngresarPeso";
            lblIngresarPeso.Size = new Size(77, 15);
            lblIngresarPeso.TabIndex = 1;
            lblIngresarPeso.Text = "Ingresar peso";
            lblIngresarPeso.Click += label1_Click;
            // 
            // lblIngresarAltura
            // 
            lblIngresarAltura.AutoSize = true;
            lblIngresarAltura.Location = new Point(43, 106);
            lblIngresarAltura.Name = "lblIngresarAltura";
            lblIngresarAltura.Size = new Size(82, 15);
            lblIngresarAltura.TabIndex = 2;
            lblIngresarAltura.Text = "Ingresar altura";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(43, 59);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(43, 124);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 4;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Location = new Point(378, 47);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(136, 15);
            lblIMC.TabIndex = 5;
            lblIMC.Text = "Indice de masa corporal:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.ControlLight;
            lblResultado.Location = new Point(378, 80);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // lblAnalisis
            // 
            lblAnalisis.AutoSize = true;
            lblAnalisis.BackColor = SystemColors.ControlLight;
            lblAnalisis.Location = new Point(378, 106);
            lblAnalisis.Name = "lblAnalisis";
            lblAnalisis.Size = new Size(47, 15);
            lblAnalisis.TabIndex = 7;
            lblAnalisis.Text = "Analisis";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAnalisis);
            Controls.Add(lblResultado);
            Controls.Add(lblIMC);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lblIngresarAltura);
            Controls.Add(lblIngresarPeso);
            Controls.Add(btnCalcularclick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularclick;
        private Label lblIngresarPeso;
        private Label lblIngresarAltura;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label lblIMC;
        private Label lblResultado;
        private Label lblAnalisis;
    }
}
