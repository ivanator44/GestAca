namespace GestAcaGUI
{
    partial class ListaCursos
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
            bindingSourceListaCursos = new BindingSource(components);
            dataGridViewListaCursos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaCursos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaCursos
            // 
            dataGridViewListaCursos.AllowUserToAddRows = false;
            dataGridViewListaCursos.AllowUserToDeleteRows = false;
            dataGridViewListaCursos.AutoGenerateColumns = false;
            dataGridViewListaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaCursos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripción });
            dataGridViewListaCursos.DataSource = bindingSourceListaCursos;
            dataGridViewListaCursos.Location = new Point(-15, 134);
            dataGridViewListaCursos.Margin = new Padding(2);
            dataGridViewListaCursos.Name = "dataGridViewListaCursos";
            dataGridViewListaCursos.ReadOnly = true;
            dataGridViewListaCursos.RowHeadersWidth = 62;
            dataGridViewListaCursos.Size = new Size(811, 279);
            dataGridViewListaCursos.TabIndex = 0;
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
            Nombre.Width = 200;
            // 
            // Descripción
            // 
            Descripción.DataPropertyName = "tc_Descripcion";
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 8;
            Descripción.Name = "Descripción";
            Descripción.ReadOnly = true;
            Descripción.Width = 400;
            // 
            // button1
            // 
            button1.Location = new Point(672, 419);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += seleccionar_Click;
            // 
            // ListaCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 511);
            Controls.Add(button1);
            Controls.Add(dataGridViewListaCursos);
            Margin = new Padding(2);
            Name = "ListaCursos";
            Text = "Lista de cursos a impartir";
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceListaCursos;
        private DataGridView dataGridViewListaCursos;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripción;
    }
}