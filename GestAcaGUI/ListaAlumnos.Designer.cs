namespace GestAcaGUI
{
    partial class ListaAlumnos
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
            bindingSourceListaAlumnos = new BindingSource(components);
            dataGridViewlistaAlumnos = new DataGridView();
            tc_Nombre = new DataGridViewTextBoxColumn();
            tc_Tipo_Pago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewlistaAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewlistaAlumnos
            // 
            dataGridViewlistaAlumnos.AllowUserToAddRows = false;
            dataGridViewlistaAlumnos.AllowUserToDeleteRows = false;
            dataGridViewlistaAlumnos.AutoGenerateColumns = false;
            dataGridViewlistaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewlistaAlumnos.Columns.AddRange(new DataGridViewColumn[] { tc_Nombre, tc_Tipo_Pago });
            dataGridViewlistaAlumnos.DataSource = bindingSourceListaAlumnos;
            dataGridViewlistaAlumnos.Location = new Point(242, 54);
            dataGridViewlistaAlumnos.Margin = new Padding(2);
            dataGridViewlistaAlumnos.Name = "dataGridViewlistaAlumnos";
            dataGridViewlistaAlumnos.ReadOnly = true;
            dataGridViewlistaAlumnos.RowHeadersWidth = 62;
            dataGridViewlistaAlumnos.Size = new Size(386, 276);
            dataGridViewlistaAlumnos.TabIndex = 0;
            // 
            // tc_Nombre
            // 
            tc_Nombre.DataPropertyName = "s_Nombre";
            tc_Nombre.HeaderText = "Nombre";
            tc_Nombre.MinimumWidth = 6;
            tc_Nombre.Name = "tc_Nombre";
            tc_Nombre.ReadOnly = true;
            tc_Nombre.Width = 125;
            // 
            // tc_Tipo_Pago
            // 
            tc_Tipo_Pago.DataPropertyName = "s_Pago";
            tc_Tipo_Pago.HeaderText = "Tipo de pago";
            tc_Tipo_Pago.MinimumWidth = 6;
            tc_Tipo_Pago.Name = "tc_Tipo_Pago";
            tc_Tipo_Pago.ReadOnly = true;
            tc_Tipo_Pago.Width = 200;
            // 
            // ListaAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewlistaAlumnos);
            Margin = new Padding(2);
            Name = "ListaAlumnos";
            Text = "ListaAlumnos";
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewlistaAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceListaAlumnos;
        private DataGridView dataGridViewlistaAlumnos;
        private DataGridViewTextBoxColumn tc_Nombre;
        private DataGridViewTextBoxColumn tc_Tipo_Pago;
    }
}