namespace Блокнот_лабораторная_1_
{
    partial class AboutProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = " Работу выполнила:\r\n Арзамасова Виктория\r\n 09-022(1)\r\n\r\n\r\n 27.02.2021";
            // 
            // AboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Блокнот_лабораторная_1_.Properties.Resources.depositphotos_161789908_stock_photo_border_from_pink_almond_and;
            this.ClientSize = new System.Drawing.Size(602, 326);
            this.Controls.Add(this.label1);
            this.Name = "AboutProgram";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}