namespace Programa02_03
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
            btnEnvio1 = new Button();
            txtMensaje = new TextBox();
            btnEnvio2 = new Button();
            SuspendLayout();
            // 
            // btnEnvio1
            // 
            btnEnvio1.Location = new Point(250, 25);
            btnEnvio1.Name = "btnEnvio1";
            btnEnvio1.Size = new Size(94, 29);
            btnEnvio1.TabIndex = 0;
            btnEnvio1.Text = "Envio 1";
            btnEnvio1.UseVisualStyleBackColor = true;
            btnEnvio1.Click += btnEnvio1_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(12, 25);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(188, 27);
            txtMensaje.TabIndex = 1;
            // 
            // btnEnvio2
            // 
            btnEnvio2.Location = new Point(250, 60);
            btnEnvio2.Name = "btnEnvio2";
            btnEnvio2.Size = new Size(94, 29);
            btnEnvio2.TabIndex = 2;
            btnEnvio2.Text = "Envio 2";
            btnEnvio2.UseVisualStyleBackColor = true;
            btnEnvio2.Click += btnEnvio2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 274);
            Controls.Add(btnEnvio2);
            Controls.Add(txtMensaje);
            Controls.Add(btnEnvio1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnvio1;
        private TextBox txtMensaje;
        private Button btnEnvio2;
    }
}
