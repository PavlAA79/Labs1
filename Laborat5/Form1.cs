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

namespace Laborat5
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string word = this.SearchText.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if (!int.TryParse(this.MaxDist.Text.Trim(), out maxDist))
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }
                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
                    return;
                }
                //Слово для поиска в верхнем регистре
                string wordUpper = word.ToUpper();
                //Временные результаты поиска
                List<Tuple<string, int>> tempList = new List<Tuple<string, int>>();
                Stopwatch t = new Stopwatch();
                t.Start();
                foreach (string str in list)
                {
                    //Вычисление расстояния Дамерау-Левенштейна
                    int dist = DamerauLevenshtein.Distance(str.ToUpper(), wordUpper);
                    //Если расстояние меньше порогового, то слово добавляется в результат
                    if (dist <= maxDist)
                    {
                        tempList.Add(new Tuple<string, int>(str, dist));
                    }
                    }
                t.Stop();
                this.SearchTime.Text = t.Elapsed.ToString();
                this.ListSearch.BeginUpdate();
                //Очистка списка
                this.ListSearch.Items.Clear();
                //Вывод результатов поиска
                foreach (var x in tempList)
                {
                    string temp = x.Item1 + "(расстояние=" + x.Item2.ToString() + ")";
                    this.ListSearch.Items.Add(temp);
                }
                this.ListSearch.EndUpdate();
            }
            else
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            
        }
    

        private void ExitButton_Click(object sender, EventArgs e)
        {
           this.Close();
         }
    }
}
