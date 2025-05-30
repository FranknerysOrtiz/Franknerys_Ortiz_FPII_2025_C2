namespace programa01_01
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
            btnSaludo = new Button();
            lblMensaje = new Label();
            btnDespedida = new Button();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(318, 43);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(94, 29);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "Saludo";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(53, 52);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "label1";
            // 
            // btnDespedida
            // 
            btnDespedida.Location = new Point(318, 101);
            btnDespedida.Name = "btnDespedida";
            btnDespedida.Size = new Size(94, 38);
            btnDespedida.TabIndex = 2;
            btnDespedida.Text = "Despedida";
            btnDespedida.UseVisualStyleBackColor = true;
            btnDespedida.Click += btnDespedida_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(btnDespedida);
            Controls.Add(lblMensaje);
            Controls.Add(btnSaludo);
            Name = "Form1";
            Text = "Programa01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludo;
        private Label lblMensaje;
        private Button btnDespedida;
    }
}
