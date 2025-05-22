namespace Calculadoradefi
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
            txtResultado = new TextBox();
            buttonUno = new Button();
            buttonTres = new Button();
            buttonDos = new Button();
            buttonOcho = new Button();
            buttonNueve = new Button();
            buttonSiete = new Button();
            buttonCinco = new Button();
            buttonSeis = new Button();
            buttonCuatro = new Button();
            buttonBorrarTodo = new Button();
            buttonQuitar = new Button();
            buttonBorrar = new Button();
            buttonRaiz = new Button();
            buttonCuadrado = new Button();
            buttonDividir = new Button();
            buttonMulti = new Button();
            buttonResta = new Button();
            buttonSuma = new Button();
            buttonResult = new Button();
            buttonCero = new Button();
            buttonPunto = new Button();
            buttonSigno = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 12);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(287, 76);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonUno
            // 
            buttonUno.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUno.Location = new Point(35, 277);
            buttonUno.Name = "buttonUno";
            buttonUno.Size = new Size(45, 45);
            buttonUno.TabIndex = 1;
            buttonUno.Text = "1";
            buttonUno.UseVisualStyleBackColor = true;
            buttonUno.Click += agregarNumero;
            // 
            // buttonTres
            // 
            buttonTres.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTres.Location = new Point(137, 277);
            buttonTres.Name = "buttonTres";
            buttonTres.Size = new Size(45, 45);
            buttonTres.TabIndex = 2;
            buttonTres.Text = "3";
            buttonTres.UseVisualStyleBackColor = true;
            buttonTres.Click += agregarNumero;
            // 
            // buttonDos
            // 
            buttonDos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDos.Location = new Point(86, 277);
            buttonDos.Name = "buttonDos";
            buttonDos.Size = new Size(45, 45);
            buttonDos.TabIndex = 3;
            buttonDos.Text = "2";
            buttonDos.UseVisualStyleBackColor = true;
            buttonDos.Click += agregarNumero;
            // 
            // buttonOcho
            // 
            buttonOcho.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOcho.Location = new Point(86, 175);
            buttonOcho.Name = "buttonOcho";
            buttonOcho.Size = new Size(45, 45);
            buttonOcho.TabIndex = 6;
            buttonOcho.Text = "8";
            buttonOcho.UseVisualStyleBackColor = true;
            buttonOcho.Click += agregarNumero;
            // 
            // buttonNueve
            // 
            buttonNueve.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNueve.Location = new Point(137, 175);
            buttonNueve.Name = "buttonNueve";
            buttonNueve.Size = new Size(45, 45);
            buttonNueve.TabIndex = 5;
            buttonNueve.Text = "9";
            buttonNueve.UseVisualStyleBackColor = true;
            buttonNueve.Click += agregarNumero;
            // 
            // buttonSiete
            // 
            buttonSiete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSiete.Location = new Point(35, 175);
            buttonSiete.Name = "buttonSiete";
            buttonSiete.Size = new Size(45, 45);
            buttonSiete.TabIndex = 4;
            buttonSiete.Text = "7";
            buttonSiete.UseVisualStyleBackColor = true;
            buttonSiete.Click += agregarNumero;
            // 
            // buttonCinco
            // 
            buttonCinco.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCinco.Location = new Point(86, 226);
            buttonCinco.Name = "buttonCinco";
            buttonCinco.Size = new Size(45, 45);
            buttonCinco.TabIndex = 9;
            buttonCinco.Text = "5";
            buttonCinco.UseVisualStyleBackColor = true;
            buttonCinco.Click += agregarNumero;
            // 
            // buttonSeis
            // 
            buttonSeis.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSeis.Location = new Point(137, 226);
            buttonSeis.Name = "buttonSeis";
            buttonSeis.Size = new Size(45, 45);
            buttonSeis.TabIndex = 8;
            buttonSeis.Text = "6";
            buttonSeis.UseVisualStyleBackColor = true;
            buttonSeis.Click += agregarNumero;
            // 
            // buttonCuatro
            // 
            buttonCuatro.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCuatro.Location = new Point(35, 226);
            buttonCuatro.Name = "buttonCuatro";
            buttonCuatro.Size = new Size(45, 45);
            buttonCuatro.TabIndex = 7;
            buttonCuatro.Text = "4";
            buttonCuatro.UseVisualStyleBackColor = true;
            buttonCuatro.Click += agregarNumero;
            // 
            // buttonBorrarTodo
            // 
            buttonBorrarTodo.Font = new Font("Segoe UI", 12F);
            buttonBorrarTodo.Location = new Point(86, 118);
            buttonBorrarTodo.Name = "buttonBorrarTodo";
            buttonBorrarTodo.Size = new Size(45, 45);
            buttonBorrarTodo.TabIndex = 12;
            buttonBorrarTodo.Text = "C";
            buttonBorrarTodo.UseVisualStyleBackColor = true;
            buttonBorrarTodo.Click += buttonBorrarTodo_Click;
            // 
            // buttonQuitar
            // 
            buttonQuitar.Font = new Font("Segoe UI", 12F);
            buttonQuitar.Location = new Point(136, 118);
            buttonQuitar.Name = "buttonQuitar";
            buttonQuitar.Size = new Size(45, 45);
            buttonQuitar.TabIndex = 11;
            buttonQuitar.Text = "<-";
            buttonQuitar.UseVisualStyleBackColor = true;
            buttonQuitar.Click += buttonQuitar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Font = new Font("Segoe UI", 12F);
            buttonBorrar.Location = new Point(35, 118);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(45, 45);
            buttonBorrar.TabIndex = 10;
            buttonBorrar.Text = "CE";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonRaiz
            // 
            buttonRaiz.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRaiz.Location = new Point(200, 119);
            buttonRaiz.Name = "buttonRaiz";
            buttonRaiz.Size = new Size(45, 45);
            buttonRaiz.TabIndex = 14;
            buttonRaiz.Tag = "√";
            buttonRaiz.Text = "√";
            buttonRaiz.UseVisualStyleBackColor = true;
            buttonRaiz.Click += clickoperador;
            // 
            // buttonCuadrado
            // 
            buttonCuadrado.Font = new Font("Segoe UI", 12F);
            buttonCuadrado.Location = new Point(251, 119);
            buttonCuadrado.Name = "buttonCuadrado";
            buttonCuadrado.Size = new Size(45, 45);
            buttonCuadrado.TabIndex = 13;
            buttonCuadrado.Tag = "²";
            buttonCuadrado.Text = "x²";
            buttonCuadrado.UseVisualStyleBackColor = true;
            buttonCuadrado.Click += clickoperador;
            // 
            // buttonDividir
            // 
            buttonDividir.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDividir.Location = new Point(200, 179);
            buttonDividir.Name = "buttonDividir";
            buttonDividir.Size = new Size(45, 45);
            buttonDividir.TabIndex = 16;
            buttonDividir.Tag = "/";
            buttonDividir.Text = "/";
            buttonDividir.UseVisualStyleBackColor = true;
            buttonDividir.Click += clickoperador;
            // 
            // buttonMulti
            // 
            buttonMulti.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMulti.Location = new Point(251, 179);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(45, 45);
            buttonMulti.TabIndex = 15;
            buttonMulti.Tag = "X";
            buttonMulti.Text = "X";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += clickoperador;
            // 
            // buttonResta
            // 
            buttonResta.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonResta.Location = new Point(251, 240);
            buttonResta.Name = "buttonResta";
            buttonResta.Size = new Size(45, 45);
            buttonResta.TabIndex = 18;
            buttonResta.Tag = "−";
            buttonResta.Text = "−";
            buttonResta.UseVisualStyleBackColor = true;
            buttonResta.Click += clickoperador;
            // 
            // buttonSuma
            // 
            buttonSuma.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuma.Location = new Point(200, 240);
            buttonSuma.Name = "buttonSuma";
            buttonSuma.Size = new Size(45, 45);
            buttonSuma.TabIndex = 17;
            buttonSuma.Tag = "+";
            buttonSuma.Text = "+";
            buttonSuma.UseVisualStyleBackColor = true;
            buttonSuma.Click += clickoperador;
            // 
            // buttonResult
            // 
            buttonResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonResult.Location = new Point(188, 291);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(126, 44);
            buttonResult.TabIndex = 19;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonCero
            // 
            buttonCero.Font = new Font("Segoe UI", 16F);
            buttonCero.Location = new Point(86, 328);
            buttonCero.Name = "buttonCero";
            buttonCero.Size = new Size(45, 45);
            buttonCero.TabIndex = 22;
            buttonCero.Text = "0";
            buttonCero.UseVisualStyleBackColor = true;
            buttonCero.Click += agregarNumero;
            // 
            // buttonPunto
            // 
            buttonPunto.Font = new Font("Segoe UI", 16F);
            buttonPunto.Location = new Point(137, 328);
            buttonPunto.Name = "buttonPunto";
            buttonPunto.Size = new Size(45, 45);
            buttonPunto.TabIndex = 21;
            buttonPunto.Text = ".";
            buttonPunto.UseVisualStyleBackColor = true;
            buttonPunto.Click += buttonPunto_Click;
            // 
            // buttonSigno
            // 
            buttonSigno.Font = new Font("Segoe UI", 10F);
            buttonSigno.Location = new Point(35, 328);
            buttonSigno.Name = "buttonSigno";
            buttonSigno.Size = new Size(45, 45);
            buttonSigno.TabIndex = 20;
            buttonSigno.Text = "+/-";
            buttonSigno.UseVisualStyleBackColor = true;
            buttonSigno.Click += buttonSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(buttonCero);
            Controls.Add(buttonPunto);
            Controls.Add(buttonSigno);
            Controls.Add(buttonResult);
            Controls.Add(buttonResta);
            Controls.Add(buttonSuma);
            Controls.Add(buttonDividir);
            Controls.Add(buttonMulti);
            Controls.Add(buttonRaiz);
            Controls.Add(buttonCuadrado);
            Controls.Add(buttonBorrarTodo);
            Controls.Add(buttonQuitar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonCinco);
            Controls.Add(buttonSeis);
            Controls.Add(buttonCuatro);
            Controls.Add(buttonOcho);
            Controls.Add(buttonNueve);
            Controls.Add(buttonSiete);
            Controls.Add(buttonDos);
            Controls.Add(buttonTres);
            Controls.Add(buttonUno);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button buttonUno;
        private Button buttonTres;
        private Button buttonDos;
        private Button buttonOcho;
        private Button buttonNueve;
        private Button buttonSiete;
        private Button buttonCinco;
        private Button buttonSeis;
        private Button buttonCuatro;
        private Button buttonBorrarTodo;
        private Button buttonQuitar;
        private Button buttonBorrar;
        private Button buttonRaiz;
        private Button buttonCuadrado;
        private Button buttonDividir;
        private Button buttonMulti;
        private Button buttonResta;
        private Button buttonSuma;
        private Button buttonResult;
        private Button buttonCero;
        private Button buttonPunto;
        private Button buttonSigno;
    }
}
