using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Laborat4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();

        private void ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch timer1 = new Stopwatch();
                timer1.Start();
                string text = File.ReadAllText(fd.FileName, Encoding.GetEncoding(1251));
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();
                    if (!list.Contains(str)) list.Add(str);
                }
                timer1.Stop();
                this.LoadTime.Text = timer1.Elapsed.ToString();
                MessageBox.Show("Чтение файла завершено.");
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл!");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string word = this.SearchText.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();

                Stopwatch timer1 = new Stopwatch();
                timer1.Start();
                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                timer1.Stop();
                this.SearchTime.Text = timer1.Elapsed.ToString();
                this.ListSearch.BeginUpdate();
                this.ListSearch.Items.Clear();
                foreach (string str in tempList)
                {
                    this.ListSearch.Items.Add(str);
                }
                this.ListSearch.EndUpdate();
            }
            else
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
    }
}
