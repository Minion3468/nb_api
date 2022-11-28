namespace nb_api
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
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.USDRateTextBox = new System.Windows.Forms.TextBox();
            this.CHFRateTextBox = new System.Windows.Forms.TextBox();
            this.EURRateTextBox = new System.Windows.Forms.TextBox();
            this.PLNtextBox = new System.Windows.Forms.TextBox();
            this.PLNlabel = new System.Windows.Forms.Label();
            this.USDradioButton = new System.Windows.Forms.RadioButton();
            this.EURradioButton = new System.Windows.Forms.RadioButton();
            this.CHFradioButton = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WYmianalabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "pobierz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 282);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(767, 156);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurs USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kurs EURO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kurs CHF";
            // 
            // USDRateTextBox
            // 
            this.USDRateTextBox.Location = new System.Drawing.Point(86, 12);
            this.USDRateTextBox.Name = "USDRateTextBox";
            this.USDRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.USDRateTextBox.TabIndex = 6;
            // 
            // CHFRateTextBox
            // 
            this.CHFRateTextBox.Location = new System.Drawing.Point(87, 101);
            this.CHFRateTextBox.Name = "CHFRateTextBox";
            this.CHFRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.CHFRateTextBox.TabIndex = 7;
            // 
            // EURRateTextBox
            // 
            this.EURRateTextBox.Location = new System.Drawing.Point(87, 57);
            this.EURRateTextBox.Name = "EURRateTextBox";
            this.EURRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.EURRateTextBox.TabIndex = 8;
            // 
            // PLNtextBox
            // 
            this.PLNtextBox.Location = new System.Drawing.Point(12, 172);
            this.PLNtextBox.Name = "PLNtextBox";
            this.PLNtextBox.Size = new System.Drawing.Size(100, 23);
            this.PLNtextBox.TabIndex = 9;
            // 
            // PLNlabel
            // 
            this.PLNlabel.AutoSize = true;
            this.PLNlabel.Location = new System.Drawing.Point(18, 154);
            this.PLNlabel.Name = "PLNlabel";
            this.PLNlabel.Size = new System.Drawing.Size(64, 15);
            this.PLNlabel.TabIndex = 10;
            this.PLNlabel.Text = "kwota PLN";
            // 
            // USDradioButton
            // 
            this.USDradioButton.AutoSize = true;
            this.USDradioButton.Location = new System.Drawing.Point(118, 173);
            this.USDradioButton.Name = "USDradioButton";
            this.USDradioButton.Size = new System.Drawing.Size(47, 19);
            this.USDradioButton.TabIndex = 11;
            this.USDradioButton.TabStop = true;
            this.USDradioButton.Text = "USD";
            this.USDradioButton.UseVisualStyleBackColor = true;
            this.USDradioButton.Click += new System.EventHandler(this.Exchange);
            // 
            // EURradioButton
            // 
            this.EURradioButton.AutoSize = true;
            this.EURradioButton.Location = new System.Drawing.Point(118, 198);
            this.EURradioButton.Name = "EURradioButton";
            this.EURradioButton.Size = new System.Drawing.Size(46, 19);
            this.EURradioButton.TabIndex = 12;
            this.EURradioButton.TabStop = true;
            this.EURradioButton.Text = "EUR";
            this.EURradioButton.UseVisualStyleBackColor = true;
            this.EURradioButton.Click += new System.EventHandler(this.Exchange);
            // 
            // CHFradioButton
            // 
            this.CHFradioButton.AutoSize = true;
            this.CHFradioButton.Location = new System.Drawing.Point(118, 223);
            this.CHFradioButton.Name = "CHFradioButton";
            this.CHFradioButton.Size = new System.Drawing.Size(48, 19);
            this.CHFradioButton.TabIndex = 13;
            this.CHFradioButton.TabStop = true;
            this.CHFradioButton.Text = "CHF";
            this.CHFradioButton.UseVisualStyleBackColor = true;
            this.CHFradioButton.Click += new System.EventHandler(this.Exchange);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // WYmianalabel
            // 
            this.WYmianalabel.AutoSize = true;
            this.WYmianalabel.Location = new System.Drawing.Point(191, 154);
            this.WYmianalabel.Name = "WYmianalabel";
            this.WYmianalabel.Size = new System.Drawing.Size(110, 15);
            this.WYmianalabel.TabIndex = 17;
            this.WYmianalabel.Text = "kwota po wymianie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WYmianalabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CHFradioButton);
            this.Controls.Add(this.EURradioButton);
            this.Controls.Add(this.USDradioButton);
            this.Controls.Add(this.PLNlabel);
            this.Controls.Add(this.PLNtextBox);
            this.Controls.Add(this.EURRateTextBox);
            this.Controls.Add(this.CHFRateTextBox);
            this.Controls.Add(this.USDRateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox USDRateTextBox;
        private TextBox CHFRateTextBox;
        private TextBox EURORateTextBox;
        private TextBox EURRateTextBox;
        private TextBox PLNtextBox;
        private Label PLNlabel;
        private RadioButton USDradioButton;
        private RadioButton EURradioButton;
        private RadioButton CHFradioButton;
        private TextBox textBox2;
        private Label WYmianalabel;
    }
}