namespace Programa05_02
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
            cmbAlimentos = new ComboBox();
            txtAlimento = new TextBox();
            btnAdiccionar = new Button();
            lblIndice = new Label();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // cmbAlimentos
            // 
            cmbAlimentos.FormattingEnabled = true;
            cmbAlimentos.Items.AddRange(new object[] { "Frijol", "Tomate" });
            cmbAlimentos.Location = new Point(140, 105);
            cmbAlimentos.Name = "cmbAlimentos";
            cmbAlimentos.Size = new Size(151, 28);
            cmbAlimentos.TabIndex = 0;
            cmbAlimentos.Text = "Alimentos";
            cmbAlimentos.SelectedIndexChanged += cmbAlimentos_SelectedIndexChanged;
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(127, 196);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(125, 27);
            txtAlimento.TabIndex = 1;
            // 
            // btnAdiccionar
            // 
            btnAdiccionar.Location = new Point(280, 197);
            btnAdiccionar.Name = "btnAdiccionar";
            btnAdiccionar.Size = new Size(94, 29);
            btnAdiccionar.TabIndex = 2;
            btnAdiccionar.Text = "Adiccionar";
            btnAdiccionar.UseVisualStyleBackColor = true;
            btnAdiccionar.Click += btnAdiccionar_Click;
            // 
            // lblIndice
            // 
            lblIndice.AutoSize = true;
            lblIndice.Location = new Point(12, 140);
            lblIndice.Name = "lblIndice";
            lblIndice.Size = new Size(50, 20);
            lblIndice.TabIndex = 3;
            lblIndice.Text = "label1";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(81, 140);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(50, 20);
            lblTexto.TabIndex = 4;
            lblTexto.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 355);
            Controls.Add(lblTexto);
            Controls.Add(lblIndice);
            Controls.Add(btnAdiccionar);
            Controls.Add(txtAlimento);
            Controls.Add(cmbAlimentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAlimentos;
        private TextBox txtAlimento;
        private Button btnAdiccionar;
        private Label lblIndice;
        private Label lblTexto;
    }
}
