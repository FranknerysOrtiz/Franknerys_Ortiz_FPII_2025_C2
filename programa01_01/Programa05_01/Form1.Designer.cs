namespace Programa05_01
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
            chlbAlimentos = new CheckedListBox();
            txtNuevoAlimeto = new TextBox();
            btnAdiccionar = new Button();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // chlbAlimentos
            // 
            chlbAlimentos.CheckOnClick = true;
            chlbAlimentos.FormattingEnabled = true;
            chlbAlimentos.Items.AddRange(new object[] { "Frijol", "Tomate" });
            chlbAlimentos.Location = new Point(1, 12);
            chlbAlimentos.Name = "chlbAlimentos";
            chlbAlimentos.Size = new Size(463, 114);
            chlbAlimentos.TabIndex = 0;
            chlbAlimentos.SelectedIndexChanged += chlbAlimentos_SelectedIndexChanged;
            // 
            // txtNuevoAlimeto
            // 
            txtNuevoAlimeto.Location = new Point(39, 196);
            txtNuevoAlimeto.Name = "txtNuevoAlimeto";
            txtNuevoAlimeto.Size = new Size(125, 27);
            txtNuevoAlimeto.TabIndex = 1;
            // 
            // btnAdiccionar
            // 
            btnAdiccionar.Location = new Point(192, 195);
            btnAdiccionar.Name = "btnAdiccionar";
            btnAdiccionar.Size = new Size(94, 29);
            btnAdiccionar.TabIndex = 2;
            btnAdiccionar.Text = "Adiccionar";
            btnAdiccionar.UseVisualStyleBackColor = true;
            btnAdiccionar.Click += btnAdiccionar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(55, 155);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 303);
            Controls.Add(lblNombre);
            Controls.Add(btnAdiccionar);
            Controls.Add(txtNuevoAlimeto);
            Controls.Add(chlbAlimentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chlbAlimentos;
        private TextBox txtNuevoAlimeto;
        private Button btnAdiccionar;
        private Label lblNombre;
    }
}
