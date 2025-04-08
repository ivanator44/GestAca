namespace GestAcaGUI
{
    partial class ListaCursosFuturos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSourceListaCursosFuturos = new BindingSource(components);
            dataGridViewListaCursosFuturos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaCursosFuturos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaCursosFuturos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaCursosFuturos
            // 
            dataGridViewListaCursosFuturos.AllowUserToAddRows = false;
            dataGridViewListaCursosFuturos.AllowUserToDeleteRows = false;
            dataGridViewListaCursosFuturos.AutoGenerateColumns = false;
            dataGridViewListaCursosFuturos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaCursosFuturos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion });
            dataGridViewListaCursosFuturos.DataSource = bindingSourceListaCursosFuturos;
            dataGridViewListaCursosFuturos.Location = new Point(24, 74);
            dataGridViewListaCursosFuturos.Name = "dataGridViewListaCursosFuturos";
            dataGridViewListaCursosFuturos.ReadOnly = true;
            dataGridViewListaCursosFuturos.RowHeadersWidth = 62;
            dataGridViewListaCursosFuturos.Size = new Size(709, 225);
            dataGridViewListaCursosFuturos.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "tc_Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "tc_Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "tc_Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 400;
            // 
            // button1
            // 
            button1.Location = new Point(610, 365);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Inscribir alumno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += inscribir_Click;
            // 
            // ListaCursosFuturos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewListaCursosFuturos);
            Name = "ListaCursosFuturos";
            Text = "Lista de cursos futuros a impartir";
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaCursosFuturos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaCursosFuturos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceListaCursosFuturos;
        private DataGridView dataGridViewListaCursosFuturos;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
    }
}