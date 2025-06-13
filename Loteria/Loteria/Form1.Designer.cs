namespace Loteria
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
            txtNumero = new TextBox();
            txtMonto = new TextBox();
            btnJugar = new Button();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            txtPremio = new TextBox();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(53, 56);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 0;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(206, 56);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 2;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(351, 56);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(94, 29);
            btnJugar.TabIndex = 3;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(66, 136);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(50, 20);
            lblNum1.TabIndex = 4;
            lblNum1.Text = "label1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(154, 134);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(50, 20);
            lblNum2.TabIndex = 5;
            lblNum2.Text = "label2";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(233, 136);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(50, 20);
            lblNum3.TabIndex = 6;
            lblNum3.Text = "label3";
            // 
            // txtPremio
            // 
            txtPremio.Location = new Point(180, 187);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(125, 27);
            txtPremio.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 264);
            Controls.Add(txtPremio);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnJugar);
            Controls.Add(txtMonto);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtMonto;
        private Button btnJugar;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private TextBox txtPremio;
    }
}
