namespace Programa03_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            sumaToolStripMenuItem = new ToolStripMenuItem();
            restaToolStripMenuItem = new ToolStripMenuItem();
            multiToolStripMenuItem = new ToolStripMenuItem();
            diviToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            habilitarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            txtA = new TextBox();
            cmuTxtA = new ContextMenuStrip(components);
            borrarToolStripMenuItem = new ToolStripMenuItem();
            aleatorioToolStripMenuItem = new ToolStripMenuItem();
            txtB = new TextBox();
            lblResultado = new Label();
            tstOperacionees = new ToolStrip();
            tstSuma = new ToolStripButton();
            tsbtResta = new ToolStripButton();
            tsbtMulti = new ToolStripButton();
            tsbtDivi = new ToolStripButton();
            stsInformacion = new StatusStrip();
            slblValores = new ToolStripStatusLabel();
            sblOperacion = new ToolStripStatusLabel();
            sblResultado = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            cmuTxtA.SuspendLayout();
            tstOperacionees.SuspendLayout();
            stsInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, operacionesToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(479, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.AutoToolTip = true;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.ToolTipText = "Quitar la aplicacion";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumaToolStripMenuItem, restaToolStripMenuItem, multiToolStripMenuItem, diviToolStripMenuItem, toolStripSeparator1, habilitarToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(106, 24);
            operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            sumaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            sumaToolStripMenuItem.Size = new Size(179, 26);
            sumaToolStripMenuItem.Text = "Suma";
            sumaToolStripMenuItem.Click += sumaToolStripMenuItem_Click;
            // 
            // restaToolStripMenuItem
            // 
            restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            restaToolStripMenuItem.Size = new Size(179, 26);
            restaToolStripMenuItem.Text = "resta";
            restaToolStripMenuItem.Click += restaToolStripMenuItem_Click;
            // 
            // multiToolStripMenuItem
            // 
            multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            multiToolStripMenuItem.Size = new Size(179, 26);
            multiToolStripMenuItem.Text = "Multi";
            multiToolStripMenuItem.Click += multiToolStripMenuItem_Click;
            // 
            // diviToolStripMenuItem
            // 
            diviToolStripMenuItem.Name = "diviToolStripMenuItem";
            diviToolStripMenuItem.Size = new Size(179, 26);
            diviToolStripMenuItem.Text = "Divi";
            diviToolStripMenuItem.Click += diviToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            habilitarToolStripMenuItem.Checked = true;
            habilitarToolStripMenuItem.CheckOnClick = true;
            habilitarToolStripMenuItem.CheckState = CheckState.Checked;
            habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            habilitarToolStripMenuItem.Size = new Size(179, 26);
            habilitarToolStripMenuItem.Text = "Habilitar";
            habilitarToolStripMenuItem.CheckedChanged += habilitarToolStripMenuItem_CheckedChanged;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(167, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = cmuTxtA;
            txtA.Location = new Point(34, 46);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // cmuTxtA
            // 
            cmuTxtA.ImageScalingSize = new Size(20, 20);
            cmuTxtA.Items.AddRange(new ToolStripItem[] { borrarToolStripMenuItem, aleatorioToolStripMenuItem });
            cmuTxtA.Name = "cmuTxtA";
            cmuTxtA.Size = new Size(141, 52);
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(140, 24);
            borrarToolStripMenuItem.Text = "Borrar";
            borrarToolStripMenuItem.Click += borrarToolStripMenuItem_Click;
            // 
            // aleatorioToolStripMenuItem
            // 
            aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            aleatorioToolStripMenuItem.Size = new Size(140, 24);
            aleatorioToolStripMenuItem.Text = "Aleatorio";
            aleatorioToolStripMenuItem.Click += aleatorioToolStripMenuItem_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(34, 79);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 2;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(207, 53);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // tstOperacionees
            // 
            tstOperacionees.ImageScalingSize = new Size(20, 20);
            tstOperacionees.Items.AddRange(new ToolStripItem[] { tstSuma, tsbtResta, tsbtMulti, tsbtDivi });
            tstOperacionees.Location = new Point(0, 28);
            tstOperacionees.Name = "tstOperacionees";
            tstOperacionees.Size = new Size(479, 27);
            tstOperacionees.TabIndex = 4;
            tstOperacionees.Text = "toolStrip1";
            // 
            // tstSuma
            // 
            tstSuma.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstSuma.Image = (Image)resources.GetObject("tstSuma.Image");
            tstSuma.ImageTransparentColor = Color.Magenta;
            tstSuma.Name = "tstSuma";
            tstSuma.Size = new Size(29, 24);
            tstSuma.Text = "SUMA";
            tstSuma.Click += sumaToolStripMenuItem_Click;
            // 
            // tsbtResta
            // 
            tsbtResta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtResta.Image = (Image)resources.GetObject("tsbtResta.Image");
            tsbtResta.ImageTransparentColor = Color.Magenta;
            tsbtResta.Name = "tsbtResta";
            tsbtResta.Size = new Size(29, 24);
            tsbtResta.Text = "Resta";
            tsbtResta.Click += restaToolStripMenuItem_Click;
            // 
            // tsbtMulti
            // 
            tsbtMulti.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtMulti.Image = (Image)resources.GetObject("tsbtMulti.Image");
            tsbtMulti.ImageTransparentColor = Color.Magenta;
            tsbtMulti.Name = "tsbtMulti";
            tsbtMulti.Size = new Size(29, 24);
            tsbtMulti.Text = "Multiplicacion";
            tsbtMulti.Click += multiToolStripMenuItem_Click;
            // 
            // tsbtDivi
            // 
            tsbtDivi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtDivi.Image = (Image)resources.GetObject("tsbtDivi.Image");
            tsbtDivi.ImageTransparentColor = Color.Magenta;
            tsbtDivi.Name = "tsbtDivi";
            tsbtDivi.Size = new Size(29, 24);
            tsbtDivi.Text = "Divi";
            tsbtDivi.Click += diviToolStripMenuItem_Click;
            // 
            // stsInformacion
            // 
            stsInformacion.ImageScalingSize = new Size(20, 20);
            stsInformacion.Items.AddRange(new ToolStripItem[] { slblValores, sblOperacion, sblResultado });
            stsInformacion.Location = new Point(0, 289);
            stsInformacion.Name = "stsInformacion";
            stsInformacion.Size = new Size(479, 30);
            stsInformacion.TabIndex = 5;
            stsInformacion.Text = "statusStrip1";
            // 
            // slblValores
            // 
            slblValores.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            slblValores.BorderStyle = Border3DStyle.Sunken;
            slblValores.Name = "slblValores";
            slblValores.Size = new Size(75, 24);
            slblValores.Text = "A=0, B=0";
            // 
            // sblOperacion
            // 
            sblOperacion.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            sblOperacion.BorderStyle = Border3DStyle.Bump;
            sblOperacion.Name = "sblOperacion";
            sblOperacion.Size = new Size(111, 24);
            sblOperacion.Text = "Sin seleccionar";
            // 
            // sblResultado
            // 
            sblResultado.BorderSides = ToolStripStatusLabelBorderSides.Left;
            sblResultado.BorderStyle = Border3DStyle.Raised;
            sblResultado.Name = "sblResultado";
            sblResultado.Size = new Size(40, 24);
            sblResultado.Text = "R=0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 319);
            Controls.Add(stsInformacion);
            Controls.Add(tstOperacionees);
            Controls.Add(lblResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            cmuTxtA.ResumeLayout(false);
            tstOperacionees.ResumeLayout(false);
            tstOperacionees.PerformLayout();
            stsInformacion.ResumeLayout(false);
            stsInformacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem sumaToolStripMenuItem;
        private ToolStripMenuItem restaToolStripMenuItem;
        private ToolStripMenuItem multiToolStripMenuItem;
        private ToolStripMenuItem diviToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblResultado;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem habilitarToolStripMenuItem;
        private ContextMenuStrip cmuTxtA;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem aleatorioToolStripMenuItem;
        private ToolStrip tstOperacionees;
        private ToolStripButton tstSuma;
        private ToolStripButton tsbtResta;
        private ToolStripButton tsbtMulti;
        private ToolStripButton tsbtDivi;
        private StatusStrip stsInformacion;
        private ToolStripStatusLabel slblValores;
        private ToolStripStatusLabel sblOperacion;
        private ToolStripStatusLabel sblResultado;
    }
}
