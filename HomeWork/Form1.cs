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

namespace HomeWork
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
                this.UniqueWords.Text = list.Count.ToString();
                MessageBox.Show("Чтение файла завершено.");
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл!");
            }
        }

        private void ExactSearch_Click(object sender, EventArgs e)
        {
            string word = this.WordForSearch.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            { //Слово для поиска в верхнем регистре 
                string wordUpper = word.ToUpper();
              //Временные результаты поиска
                List<string> tempList = new List<string>();
                Stopwatch t = new Stopwatch(); t.Start();
                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                t.Stop();
                this.ExactSearchTime.Text = t.Elapsed.ToString();
                this.ListSearchResults.BeginUpdate();
                //Очистка списка 
                this.ListSearchResults.Items.Clear();
                //Вывод результатов поиска
                foreach (string str in tempList)
                {
                    this.ListSearchResults.Items.Add(str);
                }
                this.ListSearchResults.EndUpdate();
            }
            else {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
                 }
            }

        private void ApproxSearch_Click(object sender, EventArgs e)
        {
            //Слово для поиска
            string word = this.WordForSearch.Text.Trim();
            //Если слово для поиска не пусто 
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if (!int.TryParse(this.MaxDistBox.Text.Trim(), out maxDist))
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }
                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
                    return;
                }
                int ThreadCount;
                if (!int.TryParse(this.ThreadCountBox.Text.Trim(), out ThreadCount))
                {
                    MessageBox.Show("Необходимо указать количество потоков");
                    return;
                }
                Stopwatch timer = new Stopwatch();
                timer.Start();
                // Начало параллельного поиска //
                //Результирующий список 
                List<ParallelSearchResult> Result = new List<ParallelSearchResult>();
                //Деление списка на фрагменты для параллельного запуска в потоках
                List<MinMax> arrayDivList = SubArrays.DivideSubArrays(0, list.Count, ThreadCount);
                int count = arrayDivList.Count;
                //Количество потоков соответствует количеству фрагментов массива 
                Task<List<ParallelSearchResult>>[] tasks = new Task<List<ParallelSearchResult>>[count];
                //Запуск потоков 
                for (int i = 0; i < count; i++)
                { //Создание временного списка, чтобы потоки не работали параллельно с одной коллекцией
                    List<string> tempTaskList = list.GetRange(arrayDivList[i].Min, arrayDivList[i].Max - arrayDivList[i].Min);
                    tasks[i] = new Task<List<ParallelSearchResult>>(
                        //Метод, который будет выполняться в потоке
                        ArrayThreadTask,
                        //Параметры потока 
                        new ParallelSearchThreadParam()
                        {
                            tempList = tempTaskList,
                            maxDist = maxDist,
                            ThreadNum = i,
                            wordPattern = word
                        });
                    //Запуск потока
                    tasks[i].Start();
                }
                Task.WaitAll(tasks);
                timer.Stop();
                //Объединение результатов 
                for (int i = 0; i < count; i++)
                {
                    Result.AddRange(tasks[i].Result);
                }
                // Завершение параллельного поиска
                timer.Stop();

                //Вывод результатов
                //Время поиска 
                this.ApproxTime.Text = timer.Elapsed.ToString();
                //Вычисленное количество потоков
                this.CalaulatedThreadCount.Text = count.ToString();
                //Начало обновления списка результатов 
                this.ListSearchResults.BeginUpdate();
                //Очистка списка 
                this.ListSearchResults.Items.Clear();
                //Вывод результатов поиска
                foreach (var x in Result)
                {
                    string temp = x.word + "(расстояние=" + x.dist.ToString() + " поток=" + x.ThreadNum.ToString() + ")";
                    this.ListSearchResults.Items.Add(temp);
                }
                //Окончание обновления списка результатов 
                this.ListSearchResults.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
                }
        public static List<ParallelSearchResult> ArrayThreadTask(object paramObj)
        {
            ParallelSearchThreadParam param = (ParallelSearchThreadParam)paramObj;
            //Слово для поиска в верхнем регистре 
            string wordUpper = param.wordPattern.Trim().ToUpper();
            //Результаты поиска в одном потоке 
            List<ParallelSearchResult> Result = new List<ParallelSearchResult>();
            //Перебор всех слов во временном списке данного потока 
            foreach (string str in param.tempList)
            { //Вычисление расстояния Дамерау-Левенштейна 
                int dist = DamerauLevenshtein.Distance(str.ToUpper(), wordUpper);
                //Если расстояние меньше порогового, то слово добавляется в результат 
                if (dist <= param.maxDist) { ParallelSearchResult temp = new ParallelSearchResult()
                { word = str, dist = dist, ThreadNum = param.ThreadNum };
                    Result.Add(temp);
                }
            }
            return Result;
        }

        private void SaveReport_Click(object sender, EventArgs e)
        {
            //Имя файла отчета 
            string TempReportFileName = "Report_" + DateTime.Now.ToString("dd_MM_yyyy_hhmmss");
            //Диалог сохранения файла отчета
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileName = TempReportFileName;
            fd.DefaultExt = ".html";
            fd.Filter = "HTML Reports|*.html";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string ReportFileName = fd.FileName;
                //Формирование отчета 
                StringBuilder b = new StringBuilder();
                b.AppendLine("<html>");
                b.AppendLine("<head>");
                b.AppendLine("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>"); b.AppendLine("<title>" + "Отчет: " + ReportFileName + "</title>"); b.AppendLine("</head>");
                b.AppendLine("<body>");
                b.AppendLine("<h1>" + "Отчет: " + ReportFileName + "</h1>");
                b.AppendLine("<table border='1'>");
                b.AppendLine("<tr>"); b.AppendLine("<td>Время чтения из файла</td>");
                b.AppendLine("<td>" + this.LoadTime.Text + "</td>");
                b.AppendLine("</tr>");
                b.AppendLine("<tr>");
                b.AppendLine("<td>Количество уникальных слов в файле</td>");
                b.AppendLine("<td>" + this.UniqueWords.Text + "</td>");
                b.AppendLine("</tr>");
                b.AppendLine("<tr>");
                b.AppendLine("<td>Слово для поиска</td>");
                b.AppendLine("<td>" + this.WordForSearch.Text + "</td>");
                b.AppendLine("</tr>");
                b.AppendLine("<tr>");
                b.AppendLine("<td>Максимальное расстояние для нечеткого поиска</td>");
                b.AppendLine("<td>" + this.MaxDistBox.Text + "</td>");
                b.AppendLine("</tr>");
                b.AppendLine("<tr>");
                b.AppendLine("<td>Время четкого поиска</td>");
                b.AppendLine("<td>" + this.ExactSearchTime.Text + "</td>");
                b.AppendLine("</tr>");
                b.AppendLine("<tr>");
                b.AppendLine("<td>Время нечеткого поиска</td>");
                b.AppendLine("<td>" + this.ApproxTime.Text + "</td>");
                b.AppendLine("</tr>");
                b.AppendLine("<tr valign='top'>");
                b.AppendLine("<td>Результаты поиска</td>");
                b.AppendLine("<td>"); b.AppendLine("<ul>");
                foreach (var x in this.ListSearchResults.Items)
                {
                    b.AppendLine("<li>" + x.ToString() + "</li>");
                }
                b.AppendLine("</ul>");
                b.AppendLine("</td>");
                b.AppendLine("</tr>");
                b.AppendLine("</table>");
                b.AppendLine("</body>");
                b.AppendLine("</html>");
                //Сохранение файла 
                File.AppendAllText(ReportFileName, b.ToString());
                MessageBox.Show("Отчет сформирован. Файл: " + ReportFileName);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

       
   

