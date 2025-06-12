namespace Programa05_05
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
            lstFrutas = new ListBox();
            txtFruta = new TextBox();
            btnAdiccionar = new Button();
            lblFruta = new Label();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // lstFrutas
            // 
            lstFrutas.FormattingEnabled = true;
            lstFrutas.Items.AddRange(new object[] { "Manzana", "Aguacate", "Pera" });
            lstFrutas.Location = new Point(119, 256);
            lstFrutas.Name = "lstFrutas";
            lstFrutas.Size = new Size(150, 104);
            lstFrutas.TabIndex = 0;
            lstFrutas.SelectedIndexChanged += lstFrutas_SelectedIndexChanged;
            // 
            // txtFruta
            // 
            txtFruta.Location = new Point(61, 40);
            txtFruta.Name = "txtFruta";
            txtFruta.Size = new Size(125, 27);
            txtFruta.TabIndex = 1;
            // 
            // btnAdiccionar
            // 
            btnAdiccionar.Location = new Point(198, 45);
            btnAdiccionar.Name = "btnAdiccionar";
            btnAdiccionar.Size = new Size(94, 29);
            btnAdiccionar.TabIndex = 2;
            btnAdiccionar.Text = "Adiccionar";
            btnAdiccionar.UseVisualStyleBackColor = true;
            btnAdiccionar.Click += btnAdiccionar_Click;
            // 
            // lblFruta
            // 
            lblFruta.AutoSize = true;
            lblFruta.Location = new Point(94, 120);
            lblFruta.Name = "lblFruta";
            lblFruta.Size = new Size(50, 20);
            lblFruta.TabIndex = 3;
            lblFruta.Text = "label1";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(198, 74);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(btnBorrar);
            Controls.Add(lblFruta);
            Controls.Add(btnAdiccionar);
            Controls.Add(txtFruta);
            Controls.Add(lstFrutas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstFrutas;
        private TextBox txtFruta;
        private Button btnAdiccionar;
        private Label lblFruta;
        private Button btnBorrar;
    }
}
