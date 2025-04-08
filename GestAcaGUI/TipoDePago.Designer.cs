namespace GestAcaGUI
{
    partial class TipoDePago
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
            radioButton = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 53);
            label1.Name = "label1";
            label1.Size = new Size(225, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el tipo de pago:";
            // 
            // radioButton
            // 
            radioButton.AutoSize = true;
            radioButton.Location = new Point(216, 103);
            radioButton.Name = "radioButton";
            radioButton.Size = new Size(116, 29);
            radioButton.TabIndex = 3;
            radioButton.TabStop = true;
            radioButton.Text = "Completo";
            radioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(216, 138);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mensual";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(351, 196);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Inscribir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TipoDePago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 304);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton);
            Controls.Add(label1);
            Name = "TipoDePago";
            Text = "TipoDePago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton;
        private RadioButton radioButton2;
        private Button button1;
    }
}