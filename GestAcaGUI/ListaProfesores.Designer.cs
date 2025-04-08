namespace GestAcaGUI
{
    partial class ListaProfesores
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
            bindingSourceListaProfesores = new BindingSource(components);
            dataGridViewListaProfesores = new DataGridView();
            t_Id = new DataGridViewTextBoxColumn();
            t_Direccion = new DataGridViewTextBoxColumn();
            t_Nombre = new DataGridViewTextBoxColumn();
            t_CP = new DataGridViewTextBoxColumn();
            t_SSN = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaProfesores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProfesores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaProfesores
            // 
            dataGridViewListaProfesores.AllowUserToAddRows = false;
            dataGridViewListaProfesores.AllowUserToDeleteRows = false;
            dataGridViewListaProfesores.AutoGenerateColumns = false;
            dataGridViewListaProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaProfesores.Columns.AddRange(new DataGridViewColumn[] { t_Id, t_Direccion, t_Nombre, t_CP, t_SSN });
            dataGridViewListaProfesores.DataSource = bindingSourceListaProfesores;
            dataGridViewListaProfesores.Location = new Point(12, 61);
            dataGridViewListaProfesores.Name = "dataGridViewListaProfesores";
            dataGridViewListaProfesores.ReadOnly = true;
            dataGridViewListaProfesores.RowHeadersWidth = 62;
            dataGridViewListaProfesores.Size = new Size(913, 280);
            dataGridViewListaProfesores.TabIndex = 0;
            // 
            // t_Id
            // 
            t_Id.DataPropertyName = "t_Id";
            t_Id.HeaderText = "ID";
            t_Id.MinimumWidth = 8;
            t_Id.Name = "t_Id";
            t_Id.ReadOnly = true;
            t_Id.Width = 150;
            // 
            // t_Direccion
            // 
            t_Direccion.DataPropertyName = "t_Nombre";
            t_Direccion.HeaderText = "Nombre";
            t_Direccion.MinimumWidth = 8;
            t_Direccion.Name = "t_Direccion";
            t_Direccion.ReadOnly = true;
            t_Direccion.Width = 150;
            // 
            // t_Nombre
            // 
            t_Nombre.DataPropertyName = "t_Direccion";
            t_Nombre.HeaderText = "Dirección";
            t_Nombre.MinimumWidth = 8;
            t_Nombre.Name = "t_Nombre";
            t_Nombre.ReadOnly = true;
            t_Nombre.Width = 250;
            // 
            // t_CP
            // 
            t_CP.DataPropertyName = "t_CP";
            t_CP.HeaderText = "Código postal";
            t_CP.MinimumWidth = 8;
            t_CP.Name = "t_CP";
            t_CP.ReadOnly = true;
            t_CP.Width = 150;
            // 
            // t_SSN
            // 
            t_SSN.DataPropertyName = "t_SSN";
            t_SSN.HeaderText = "NSS";
            t_SSN.MinimumWidth = 8;
            t_SSN.Name = "t_SSN";
            t_SSN.ReadOnly = true;
            t_SSN.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(813, 372);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Asignar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += asignar_click;
            // 
            // ListaProfesores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewListaProfesores);
            Name = "ListaProfesores";
            Text = "Lista de profesores compatibles";
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaProfesores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceListaProfesores;
        private DataGridView dataGridViewListaProfesores;
        private Button button1;
        private DataGridViewTextBoxColumn t_Id;
        private DataGridViewTextBoxColumn t_Direccion;
        private DataGridViewTextBoxColumn t_Nombre;
        private DataGridViewTextBoxColumn t_CP;
        private DataGridViewTextBoxColumn t_SSN;
    }
}