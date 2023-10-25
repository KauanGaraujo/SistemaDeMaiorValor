namespace AppRever2.View
{
    partial class TelaForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 28);
            label1.Name = "label1";
            label1.Size = new Size(315, 37);
            label1.TabIndex = 3;
            label1.Text = "Sistema de Maior Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(149, 117);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 4;
            label2.Text = "Primeiro Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(145, 161);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 5;
            label3.Text = "Segundo Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(155, 203);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 6;
            label4.Text = "Terceiro Valor:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(136, 257);
            button1.Name = "button1";
            button1.Size = new Size(519, 38);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Cursor = Cursors.SizeNESW;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(136, 361);
            label5.Name = "label5";
            label5.Size = new Size(519, 217);
            label5.TabIndex = 8;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(136, 310);
            button2.Name = "button2";
            button2.Size = new Size(519, 39);
            button2.TabIndex = 9;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TelaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 600);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MinimizeBox = false;
            Name = "TelaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Button button2;
    }
}