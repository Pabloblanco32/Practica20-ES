namespace Practica20_ES
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 34);
            label1.TabIndex = 0;
            label1.Text = "Programa que asigna la categoria \r\nque corresponda con la edad";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            button1.Location = new Point(120, 110);
            button1.Name = "button1";
            button1.Size = new Size(91, 26);
            button1.TabIndex = 1;
            button1.Text = "Categoria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            label2.Location = new Point(51, 64);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 2;
            label2.Text = "Edad";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            textBox1.Location = new Point(120, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(335, 337);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}
