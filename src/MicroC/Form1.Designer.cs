namespace MicroC
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
            crownMenuStrip1 = new ReaLTaiizor.Controls.CrownMenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            compilarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            txtCodigo = new RichTextBox();
            txtConsola = new RichTextBox();
            crownMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // crownMenuStrip1
            // 
            crownMenuStrip1.BackColor = Color.FromArgb(60, 63, 65);
            crownMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownMenuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, compilarToolStripMenuItem, ayudaToolStripMenuItem });
            crownMenuStrip1.Location = new Point(0, 0);
            crownMenuStrip1.Name = "crownMenuStrip1";
            crownMenuStrip1.Padding = new Padding(3, 2, 0, 2);
            crownMenuStrip1.Size = new Size(800, 24);
            crownMenuStrip1.TabIndex = 0;
            crownMenuStrip1.Text = "crownMenuStrip1";
            crownMenuStrip1.ItemClicked += crownMenuStrip1_ItemClicked;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            nuevoToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(116, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            abrirToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            guardarToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            salirToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(116, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editarToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // compilarToolStripMenuItem
            // 
            compilarToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            compilarToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            compilarToolStripMenuItem.Size = new Size(68, 20);
            compilarToolStripMenuItem.Text = "Compilar";
            compilarToolStripMenuItem.Click += compilarToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            ayudaToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtCodigo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtConsola);
            splitContainer1.Size = new Size(800, 596);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(60, 63, 65);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Dock = DockStyle.Fill;
            txtCodigo.ForeColor = SystemColors.ControlLight;
            txtCodigo.Location = new Point(0, 0);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(266, 596);
            txtCodigo.TabIndex = 0;
            txtCodigo.Text = "";
            // 
            // txtConsola
            // 
            txtConsola.BackColor = Color.FromArgb(60, 63, 65);
            txtConsola.BorderStyle = BorderStyle.FixedSingle;
            txtConsola.Dock = DockStyle.Fill;
            txtConsola.ForeColor = SystemColors.ControlLight;
            txtConsola.Location = new Point(0, 0);
            txtConsola.Name = "txtConsola";
            txtConsola.ReadOnly = true;
            txtConsola.Size = new Size(530, 596);
            txtConsola.TabIndex = 0;
            txtConsola.Text = "[Compilación en desarrollo]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(splitContainer1);
            Controls.Add(crownMenuStrip1);
            ForeColor = SystemColors.GrayText;
            MainMenuStrip = crownMenuStrip1;
            Name = "Form1";
            Text = "Form1";
            crownMenuStrip1.ResumeLayout(false);
            crownMenuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownMenuStrip crownMenuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem compilarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private SplitContainer splitContainer1;
        private RichTextBox txtCodigo;
        private RichTextBox txtConsola;
    }
}
