namespace GestAcaGUI
{
    partial class ListaAulas
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
            bindingSourceListaAulas = new BindingSource(components);
            dataGridViewListaAulas = new DataGridView();
            tc_Max_Cap = new DataGridViewTextBoxColumn();
            tc_Nombre = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaAulas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaAulas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaAulas
            // 
            dataGridViewListaAulas.AllowUserToAddRows = false;
            dataGridViewListaAulas.AllowUserToDeleteRows = false;
            dataGridViewListaAulas.AutoGenerateColumns = false;
            dataGridViewListaAulas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaAulas.Columns.AddRange(new DataGridViewColumn[] { tc_Max_Cap, tc_Nombre });
            dataGridViewListaAulas.DataSource = bindingSourceListaAulas;
            dataGridViewListaAulas.Location = new Point(200, 72);
            dataGridViewListaAulas.Margin = new Padding(2);
            dataGridViewListaAulas.Name = "dataGridViewListaAulas";
            dataGridViewListaAulas.ReadOnly = true;
            dataGridViewListaAulas.RowHeadersWidth = 62;
            dataGridViewListaAulas.Size = new Size(313, 225);
            dataGridViewListaAulas.TabIndex = 0;
            // 
            // tc_Max_Cap
            // 
            tc_Max_Cap.DataPropertyName = "c_Max_Cap";
            tc_Max_Cap.HeaderText = "Máxima capacidad";
            tc_Max_Cap.MinimumWidth = 6;
            tc_Max_Cap.Name = "tc_Max_Cap";
            tc_Max_Cap.ReadOnly = true;
            tc_Max_Cap.Width = 125;
            // 
            // tc_Nombre
            // 
            tc_Nombre.DataPropertyName = "c_Nombre";
            tc_Nombre.HeaderText = "Nombre";
            tc_Nombre.MinimumWidth = 6;
            tc_Nombre.Name = "tc_Nombre";
            tc_Nombre.ReadOnly = true;
            tc_Nombre.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(659, 390);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Asignar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += asignar_click;
            // 
            // ListaAulas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewListaAulas);
            Margin = new Padding(2);
            Name = "ListaAulas";
            Text = "ListaAulas";
            ((System.ComponentModel.ISupportInitialize)bindingSourceListaAulas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaAulas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceListaAulas;
        private DataGridView dataGridViewListaAulas;
        private Button button1;
        private DataGridViewTextBoxColumn tc_Max_Cap;
        private DataGridViewTextBoxColumn tc_Nombre;
    }
}