namespace Probando_forms
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
            suma1 = new TextBox();
            button1 = new Button();
            suma2 = new TextBox();
            resultado = new TextBox();
            SuspendLayout();
            // 
            // suma1
            // 
            suma1.Location = new Point(12, 41);
            suma1.Name = "suma1";
            suma1.Size = new Size(179, 27);
            suma1.TabIndex = 0;
            suma1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 178);
            button1.Name = "button1";
            button1.Size = new Size(179, 66);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // suma2
            // 
            suma2.Location = new Point(12, 115);
            suma2.Name = "suma2";
            suma2.Size = new Size(179, 27);
            suma2.TabIndex = 2;
            // 
            // resultado
            // 
            resultado.Location = new Point(225, 217);
            resultado.Name = "resultado";
            resultado.ReadOnly = true;
            resultado.Size = new Size(270, 27);
            resultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(suma2);
            Controls.Add(button1);
            Controls.Add(suma1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox suma1;
        private Button button1;
        private TextBox suma2;
        private TextBox resultado;
    }
}
