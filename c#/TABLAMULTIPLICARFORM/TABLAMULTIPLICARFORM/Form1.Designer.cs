namespace TABLAMULTIPLICARFORM
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
            lstTabla = new ListBox();
            btnMostrar = new Button();
            label1 = new Label();
            nupNumero = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nupNumero).BeginInit();
            SuspendLayout();
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.Location = new Point(491, 75);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(120, 94);
            lstTabla.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(70, 208);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(92, 23);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Tabla";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 88);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingresar un numero";
            // 
            // nupNumero
            // 
            nupNumero.Location = new Point(70, 146);
            nupNumero.Name = "nupNumero";
            nupNumero.Size = new Size(120, 23);
            nupNumero.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nupNumero);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Controls.Add(lstTabla);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nupNumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTabla;
        private Button btnMostrar;
        private Label label1;
        private NumericUpDown nupNumero;
    }
}
