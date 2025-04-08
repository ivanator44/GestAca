namespace GestAcaGUI
{
    partial class GestAcaAPP
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
            menuStrip1 = new MenuStrip();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            listaDeCursosAImpartirToolStripMenuItem = new ToolStripMenuItem();
            listaDeCursosFuturosAImpartirToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            inicializarBDToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { visualizarToolStripMenuItem, sistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeCursosAImpartirToolStripMenuItem, listaDeCursosFuturosAImpartirToolStripMenuItem });
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(101, 29);
            visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // listaDeCursosAImpartirToolStripMenuItem
            // 
            listaDeCursosAImpartirToolStripMenuItem.Name = "listaDeCursosAImpartirToolStripMenuItem";
            listaDeCursosAImpartirToolStripMenuItem.Size = new Size(373, 34);
            listaDeCursosAImpartirToolStripMenuItem.Text = "Lista de cursos a impartir";
            listaDeCursosAImpartirToolStripMenuItem.Click += menuCursos_click;
            // 
            // listaDeCursosFuturosAImpartirToolStripMenuItem
            // 
            listaDeCursosFuturosAImpartirToolStripMenuItem.Name = "listaDeCursosFuturosAImpartirToolStripMenuItem";
            listaDeCursosFuturosAImpartirToolStripMenuItem.Size = new Size(373, 34);
            listaDeCursosFuturosAImpartirToolStripMenuItem.Text = "Lista de cursos futuros a impartir";
            listaDeCursosFuturosAImpartirToolStripMenuItem.Click += menuCursosFuturos_click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inicializarBDToolStripMenuItem, salirToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(90, 29);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // inicializarBDToolStripMenuItem
            // 
            inicializarBDToolStripMenuItem.Name = "inicializarBDToolStripMenuItem";
            inicializarBDToolStripMenuItem.Size = new Size(302, 34);
            inicializarBDToolStripMenuItem.Text = "Inicializar base de datos";
            inicializarBDToolStripMenuItem.Click += inicializarBD_click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(302, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += menuSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(645, 382);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += botonSalir_click;
            // 
            // GestAcaAPP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GestAcaAPP";
            Text = "GestAcaAPP";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem listaDeCursosAImpartirToolStripMenuItem;
        private ToolStripMenuItem listaDeCursosFuturosAImpartirToolStripMenuItem;
        private ToolStripMenuItem inicializarBDToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button button1;
    }
}
