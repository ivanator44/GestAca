namespace GestAcaGUI
{
    partial class IntroducirDni
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
            button1 = new Button();
            dnitextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 83);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // button1
            // 
            button1.Location = new Point(304, 166);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Aceptar_click;
            // 
            // dnitextBox
            // 
            dnitextBox.Location = new Point(130, 80);
            dnitextBox.Name = "dnitextBox";
            dnitextBox.Size = new Size(241, 31);
            dnitextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(240, 25);
            label2.TabIndex = 3;
            label2.Text = "Introduce el DNI del alumno:";
            // 
            // IntroducirDni
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 244);
            Controls.Add(label2);
            Controls.Add(dnitextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "IntroducirDni";
            Text = "IntroducirDni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox dnitextBox;
        private Label label2;
    }
}