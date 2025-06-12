namespace Programa04_01
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
            components = new System.ComponentModel.Container();
            tmrPrueba = new System.Windows.Forms.Timer(components);
            lblValor = new Label();
            btnInicio = new Button();
            btnDetener = new Button();
            tbrIntervalo = new TrackBar();
            lblTValor = new Label();
            pbrTrabajo = new ProgressBar();
            btnCalculo = new Button();
            ((System.ComponentModel.ISupportInitialize)tbrIntervalo).BeginInit();
            SuspendLayout();
            // 
            // tmrPrueba
            // 
            tmrPrueba.Tick += tmrPrueba_Tick;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(16, 25);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(50, 20);
            lblValor.TabIndex = 0;
            lblValor.Text = "label1";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(239, 25);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(239, 60);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tbrIntervalo
            // 
            tbrIntervalo.Location = new Point(76, 122);
            tbrIntervalo.Maximum = 1000;
            tbrIntervalo.Minimum = 100;
            tbrIntervalo.Name = "tbrIntervalo";
            tbrIntervalo.Size = new Size(257, 56);
            tbrIntervalo.TabIndex = 3;
            tbrIntervalo.TickFrequency = 10;
            tbrIntervalo.Value = 100;
            tbrIntervalo.Scroll += tbrIntervalo_Scroll;
            // 
            // lblTValor
            // 
            lblTValor.AutoSize = true;
            lblTValor.Location = new Point(16, 122);
            lblTValor.Name = "lblTValor";
            lblTValor.Size = new Size(50, 20);
            lblTValor.TabIndex = 4;
            lblTValor.Text = "label1";
            // 
            // pbrTrabajo
            // 
            pbrTrabajo.Location = new Point(36, 198);
            pbrTrabajo.Name = "pbrTrabajo";
            pbrTrabajo.Size = new Size(301, 29);
            pbrTrabajo.TabIndex = 5;
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(356, 258);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(94, 29);
            btnCalculo.TabIndex = 6;
            btnCalculo.Text = "Calcular";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 319);
            Controls.Add(btnCalculo);
            Controls.Add(pbrTrabajo);
            Controls.Add(lblTValor);
            Controls.Add(tbrIntervalo);
            Controls.Add(btnDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblValor);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)tbrIntervalo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrPrueba;
        private Label lblValor;
        private Button btnInicio;
        private Button btnDetener;
        private TrackBar tbrIntervalo;
        private Label lblTValor;
        private ProgressBar pbrTrabajo;
        private Button btnCalculo;
    }
}
