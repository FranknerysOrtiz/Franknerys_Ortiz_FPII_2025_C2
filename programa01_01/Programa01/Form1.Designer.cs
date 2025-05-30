namespace Programa01
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            lblSeguro = new Label();
            rbnBasico = new RadioButton();
            rbnTerceros = new RadioButton();
            rbnTotal = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chkAudio = new CheckBox();
            chkAire = new CheckBox();
            lblEquipo = new Label();
            lblCosto = new Label();
            txtCosto = new TextBox();
            btnCotizar = new Button();
            txtCotizacion = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 75);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 2;
            label1.Text = " ";
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(26, 75);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(56, 20);
            lblSeguro.TabIndex = 3;
            lblSeguro.Text = "Seguro";
            // 
            // rbnBasico
            // 
            rbnBasico.AutoSize = true;
            rbnBasico.Checked = true;
            rbnBasico.Location = new Point(60, 36);
            rbnBasico.Name = "rbnBasico";
            rbnBasico.Size = new Size(73, 24);
            rbnBasico.TabIndex = 4;
            rbnBasico.TabStop = true;
            rbnBasico.Text = "Basico";
            rbnBasico.UseVisualStyleBackColor = true;
            // 
            // rbnTerceros
            // 
            rbnTerceros.AutoSize = true;
            rbnTerceros.Location = new Point(60, 66);
            rbnTerceros.Name = "rbnTerceros";
            rbnTerceros.Size = new Size(97, 24);
            rbnTerceros.TabIndex = 5;
            rbnTerceros.Text = "A terceros";
            rbnTerceros.UseVisualStyleBackColor = true;
            // 
            // rbnTotal
            // 
            rbnTotal.AutoSize = true;
            rbnTotal.Location = new Point(60, 96);
            rbnTotal.Name = "rbnTotal";
            rbnTotal.Size = new Size(63, 24);
            rbnTotal.TabIndex = 6;
            rbnTotal.Text = "Total";
            rbnTotal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnBasico);
            groupBox1.Controls.Add(rbnTotal);
            groupBox1.Controls.Add(rbnTerceros);
            groupBox1.Location = new Point(88, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 157);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro a seleccionar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkAudio);
            groupBox2.Controls.Add(chkAire);
            groupBox2.Controls.Add(lblEquipo);
            groupBox2.Location = new Point(391, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 125);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Equipamiento";
            // 
            // chkAudio
            // 
            chkAudio.AutoSize = true;
            chkAudio.Location = new Point(111, 52);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(148, 24);
            chkAudio.TabIndex = 2;
            chkAudio.Text = "Sistema de Audio";
            chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkAire
            // 
            chkAire.AutoSize = true;
            chkAire.Location = new Point(107, 20);
            chkAire.Name = "chkAire";
            chkAire.Size = new Size(161, 24);
            chkAire.TabIndex = 1;
            chkAire.Text = "Aire acondicionado";
            chkAire.UseVisualStyleBackColor = true;
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(15, 30);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(56, 20);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(393, 204);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(47, 20);
            lblCosto.TabIndex = 9;
            lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(446, 201);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(125, 27);
            txtCosto.TabIndex = 10;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(634, 171);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(94, 29);
            btnCotizar.TabIndex = 11;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // txtCotizacion
            // 
            txtCotizacion.Location = new Point(78, 257);
            txtCotizacion.Multiline = true;
            txtCotizacion.Name = "txtCotizacion";
            txtCotizacion.Size = new Size(493, 126);
            txtCotizacion.TabIndex = 12;
            txtCotizacion.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 395);
            Controls.Add(txtCotizacion);
            Controls.Add(btnCotizar);
            Controls.Add(txtCosto);
            Controls.Add(lblCosto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblSeguro);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label label1;
        private Label lblSeguro;
        private RadioButton rbnBasico;
        private RadioButton rbnTerceros;
        private RadioButton rbnTotal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkAudio;
        private CheckBox chkAire;
        private Label lblEquipo;
        private Label lblCosto;
        private TextBox txtCosto;
        private Button btnCotizar;
        private TextBox txtCotizacion;
    }
}
