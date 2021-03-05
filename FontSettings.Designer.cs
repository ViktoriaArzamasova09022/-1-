namespace Блокнот_лабораторная_1_
{
    partial class FontSettings
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(12, 125);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(74, 20);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Образец";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleText.Location = new System.Drawing.Point(12, 145);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(272, 59);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBbYyZz";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "20",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.comboBox2.Location = new System.Drawing.Point(12, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 28);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "полужирный",
            "подчеркивание"});
            this.comboBox1.Location = new System.Drawing.Point(123, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Начертание:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}