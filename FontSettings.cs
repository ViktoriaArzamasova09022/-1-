using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Блокнот_лабораторная_1_
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public FontStyle fs = FontStyle.Regular;
        public Color fc = Color.Black;
        
        public FontSettings()
        {
            InitializeComponent();
            comboBox2.SelectedItem = comboBox2.Items[0]; // выбранный Item у данного comboBox - это его первый элемент
            comboBox1.SelectedItem = comboBox1.Items[0];
        }     
        private void OnFontChanged(object sender, EventArgs e)
        {
            ExampleText.Font = new Font(ExampleText.Font.FontFamily,int.Parse(comboBox2.SelectedItem.ToString()),ExampleText.Font.Style);
            fontSize = int.Parse(comboBox2.SelectedItem.ToString());

        }
        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "обычный":
                  ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(comboBox2.SelectedItem.ToString()), FontStyle.Regular);
                    break;

                case "курсив":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(comboBox2.SelectedItem.ToString()), FontStyle.Italic);
                    break;

                case "полужирный":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(comboBox2.SelectedItem.ToString()), FontStyle.Bold);
                    break;

                case "подчеркивание":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(comboBox2.SelectedItem.ToString()), FontStyle.Underline);
                    break;
            }

            fs = ExampleText.Font.Style;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
        
    }
}
