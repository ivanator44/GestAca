namespace GestAcaGUI
{
    partial class AltaEstudiante
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
            label1 = new Label();
            labeldir = new Label();
            labelnombre = new Label();
            labelcp = new Label();
            labeliban = new Label();
            textBoxdireccion = new TextBox();
            textBoxnombre = new TextBox();
            textBoxcp = new TextBox();
            textBoxiban = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 45);
            label1.Name = "label1";
            label1.Size = new Size(461, 25);
            label1.TabIndex = 0;
            label1.Text = "El estudiante no se ha encontrado, ¿Quiere darlo de alta?";
            // 
            // labeldir
            // 
            labeldir.AutoSize = true;
            labeldir.Location = new Point(116, 103);
            labeldir.Name = "labeldir";
            labeldir.Size = new Size(89, 25);
            labeldir.TabIndex = 1;
            labeldir.Text = "Dirección:";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(123, 138);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(82, 25);
            labelnombre.TabIndex = 2;
            labelnombre.Text = "Nombre:";
            // 
            // labelcp
            // 
            labelcp.AutoSize = true;
            labelcp.Location = new Point(76, 177);
            labelcp.Name = "labelcp";
            labelcp.Size = new Size(129, 25);
            labelcp.TabIndex = 3;
            labelcp.Text = "Código postal:";
            // 
            // labeliban
            // 
            labeliban.AutoSize = true;
            labeliban.Location = new Point(149, 217);
            labeliban.Name = "labeliban";
            labeliban.Size = new Size(56, 25);
            labeliban.TabIndex = 4;
            labeliban.Text = "IBAN:";
            // 
            // textBoxdireccion
            // 
            textBoxdireccion.Location = new Point(223, 103);
            textBoxdireccion.Name = "textBoxdireccion";
            textBoxdireccion.Size = new Size(150, 31);
            textBoxdireccion.TabIndex = 5;
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(223, 140);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(150, 31);
            textBoxnombre.TabIndex = 6;
            // 
            // textBoxcp
            // 
            textBoxcp.Location = new Point(223, 177);
            textBoxcp.Name = "textBoxcp";
            textBoxcp.Size = new Size(150, 31);
            textBoxcp.TabIndex = 7;
            // 
            // textBoxiban
            // 
            textBoxiban.Location = new Point(223, 214);
            textBoxiban.Name = "textBoxiban";
            textBoxiban.Size = new Size(150, 31);
            textBoxiban.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(438, 265);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Inscribir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AltaEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 337);
            Controls.Add(button1);
            Controls.Add(textBoxiban);
            Controls.Add(textBoxcp);
            Controls.Add(textBoxnombre);
            Controls.Add(textBoxdireccion);
            Controls.Add(labeliban);
            Controls.Add(labelcp);
            Controls.Add(labelnombre);
            Controls.Add(labeldir);
            Controls.Add(label1);
            Name = "AltaEstudiante";
            Text = "AltaEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labeldir;
        private Label labelnombre;
        private Label labelcp;
        private Label labeliban;
        private TextBox textBoxdireccion;
        private TextBox textBoxnombre;
        private TextBox textBoxcp;
        private TextBox textBoxiban;
        private Button button1;
    }
}