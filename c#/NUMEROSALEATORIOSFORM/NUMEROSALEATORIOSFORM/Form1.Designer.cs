namespace NUMEROSALEATORIOSFORM
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
            btnGenerar = new Button();
            lstNumeros = new ListBox();
            lblMayor = new Label();
            lblMenor = new Label();
            lblPromedio = new Label();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(236, 39);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(187, 34);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(140, 141);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(380, 124);
            lstNumeros.TabIndex = 1;
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(52, 101);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(88, 15);
            lblMayor.TabIndex = 2;
            lblMayor.Text = "Numero Mayor";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(288, 101);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(89, 15);
            lblMenor.TabIndex = 3;
            lblMenor.Text = "Numero Menor";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(487, 101);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(59, 15);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Promedio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPromedio);
            Controls.Add(lblMenor);
            Controls.Add(lblMayor);
            Controls.Add(lstNumeros);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private ListBox lstNumeros;
        private Label lblMayor;
        private Label lblMenor;
        private Label lblPromedio;
    }
}
