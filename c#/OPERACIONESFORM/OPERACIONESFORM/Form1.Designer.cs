namespace OPERACIONESFORM
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbOperaciones = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            label4 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(57, 54);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(57, 164);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(57, 106);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(121, 23);
            cmbOperaciones.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Primer Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 146);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 4;
            label2.Text = "Segundo Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 88);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 5;
            label3.Text = "Operacion a realizar";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(57, 193);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(164, 31);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 90);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(305, 114);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOperaciones);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbOperaciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label label4;
        private Label lblResultado;
    }
}
