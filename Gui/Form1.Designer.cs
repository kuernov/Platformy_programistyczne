namespace Gui
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Results = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(346, 245);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(166, 60);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(650, 90);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 90);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 90);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 31);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 4;
            label1.Text = "Number of items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 5;
            label2.Text = "Seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(656, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 6;
            label3.Text = "Capacity";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(71, 378);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(358, 629);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(450, 378);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(364, 629);
            textBox5.TabIndex = 8;
            // 
            // Results
            // 
            Results.AutoSize = true;
            Results.Location = new Point(71, 348);
            Results.Margin = new Padding(4, 0, 4, 0);
            Results.Name = "Results";
            Results.Size = new Size(67, 25);
            Results.TabIndex = 9;
            Results.Text = "Results";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 348);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 10;
            label4.Text = "Instance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(857, 1050);
            Controls.Add(label4);
            Controls.Add(Results);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label Results;
        private Label label4;
    }
}
