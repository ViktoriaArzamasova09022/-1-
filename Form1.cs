using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Блокнот_лабораторная_1_
{
    public partial class Form1 : Form
    {
        public string filename; //переменная, которая отвечает за название файла
        public bool isFileChanged; //переменная отслеживания изменений в файле
        // изначальные параметры шрифта
        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;

        public FontSettings fontSetts;
        public Form1()
        {
            InitializeComponent();
            Init();
        }     
        public void Init() //метод инициализации
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
           
        }
        public void CreateNewDocument(object sender,EventArgs e) //метод создания нового документа
        {
            SaveUnsavedFile();
            richTextBox1.Text = "";
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }
        public void OpenFile(object sender,EventArgs e) // метод открытия нового файла
        {
            openFileDialog1.FileName = "";
            SaveUnsavedFile();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // создаем переменную класа StreamReader для считывания текста из файла
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    // закидываем все, что мы считали на richTextBox1
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл :с");
                }
                UpdateTextWithTitle();
            }
        }
        public void SaveFile(string _filename) // метод сохранения файла
        {
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                    MessageBox.Show("Все ок");
                }
            }
            else
            {
                try
                {
                    StreamWriter sw = new StreamWriter(_filename + ".txt"); // переменная для записи символов
                    sw.Write(richTextBox1.Text); // записываем текст из richTextBox1
                    sw.Close();
                    filename = _filename;
                    isFileChanged = false; // файл не изменен, т.к. его сохранили
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить данный файл :с");
                }              
            }
            UpdateTextWithTitle();
        }
        public void Save(object sender, EventArgs e) // сохранить 
        {
            SaveFile(filename);
        }
        public void SaveAs(object sender, EventArgs e) // сохранить как...
        {
            SaveFile("");
        }
        private void OnTextChanged(object sender, EventArgs e)
        {          
            if (!isFileChanged) //если файл изменен, в названии появляется *
            {
                this.Text = this.Text.Replace('*', ' '); // меняем * на пустой символ
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
        public void UpdateTextWithTitle() // обновление текста формы
        {
            if (filename != "") this.Text = filename + " - Блокнот";
            else this.Text = "Безымянный - Блокнот";
        }
        public void SaveUnsavedFile() // сохранить изменения при закрытии несохраненного файла
        {
            if (!isFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Сохраниение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

        // функционал для меню "Правка"

        public void CopyText(object sender,EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }
        public void CutText(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text.Substring(richTextBox1.SelectionStart, richTextBox1.SelectionLength));              
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);

        }
        public void PasteText(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart) + Clipboard.GetText() + richTextBox1.Text.Substring(richTextBox1.SelectionStart, richTextBox1.Text.Length - richTextBox1.SelectionStart);
        }
        public void DeleteText(object sender,EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(richTextBox1.SelectedText, "");
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile(); //при закрытии файла приходит запрос на сохраниение
        }

        // работа со шрифтом

        private void OnFontClick(object sender, EventArgs e) // вызов формы настроек шрифта
        {
            fontSetts = new FontSettings();
            fontSetts.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if(fontSetts!=null)  //если форма открыта
            {
                fontSize = fontSetts.fontSize;
                fs = fontSetts.fs;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize, fs); //передаем нашей форме настройки шрифта
                fontSetts.Close();
            }    
        }

        private void ProgramClick(object sender,EventArgs e)
        {
            AboutProgram ab = new AboutProgram(this);
            ab.Show();
        }
    }
}
