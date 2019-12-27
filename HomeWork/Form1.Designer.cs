namespace HomeWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExactSearch = new System.Windows.Forms.Button();
            this.ApproxSearch = new System.Windows.Forms.Button();
            this.SaveReport = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UniqueWords = new System.Windows.Forms.TextBox();
            this.WordForSearch = new System.Windows.Forms.TextBox();
            this.ExactSearchTime = new System.Windows.Forms.TextBox();
            this.MaxDistBox = new System.Windows.Forms.TextBox();
            this.ThreadCountBox = new System.Windows.Forms.TextBox();
            this.ApproxTime = new System.Windows.Forms.TextBox();
            this.CalaulatedThreadCount = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ListSearchResults = new System.Windows.Forms.ListBox();
            this.ReadFile = new System.Windows.Forms.Button();
            this.LoadTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExactSearch
            // 
            this.ExactSearch.Location = new System.Drawing.Point(30, 140);
            this.ExactSearch.Name = "ExactSearch";
            this.ExactSearch.Size = new System.Drawing.Size(344, 36);
            this.ExactSearch.TabIndex = 1;
            this.ExactSearch.Text = "Четкий поиск";
            this.ExactSearch.UseVisualStyleBackColor = true;
            this.ExactSearch.Click += new System.EventHandler(this.ExactSearch_Click);
            // 
            // ApproxSearch
            // 
            this.ApproxSearch.Location = new System.Drawing.Point(30, 197);
            this.ApproxSearch.Name = "ApproxSearch";
            this.ApproxSearch.Size = new System.Drawing.Size(345, 74);
            this.ApproxSearch.TabIndex = 2;
            this.ApproxSearch.Text = "Параллельный нечеткий поиск";
            this.ApproxSearch.UseVisualStyleBackColor = true;
            this.ApproxSearch.Click += new System.EventHandler(this.ApproxSearch_Click);
            // 
            // SaveReport
            // 
            this.SaveReport.Location = new System.Drawing.Point(29, 582);
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(227, 53);
            this.SaveReport.TabIndex = 3;
            this.SaveReport.Text = "Сохранение отчета";
            this.SaveReport.UseVisualStyleBackColor = true;
            this.SaveReport.Click += new System.EventHandler(this.SaveReport_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(768, 582);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(233, 53);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время чтения из файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество уникальных слов в файле:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Слово для поиска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Время четкого поиска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Максимальное расстояние для нечеткого поиска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество потоков:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вычисленное количество потоков:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Время нечеткого поиска:";
            // 
            // UniqueWords
            // 
            this.UniqueWords.Location = new System.Drawing.Point(805, 58);
            this.UniqueWords.Name = "UniqueWords";
            this.UniqueWords.ReadOnly = true;
            this.UniqueWords.Size = new System.Drawing.Size(196, 26);
            this.UniqueWords.TabIndex = 14;
            // 
            // WordForSearch
            // 
            this.WordForSearch.Location = new System.Drawing.Point(202, 99);
            this.WordForSearch.Name = "WordForSearch";
            this.WordForSearch.Size = new System.Drawing.Size(363, 26);
            this.WordForSearch.TabIndex = 15;
            // 
            // ExactSearchTime
            // 
            this.ExactSearchTime.Location = new System.Drawing.Point(805, 145);
            this.ExactSearchTime.Name = "ExactSearchTime";
            this.ExactSearchTime.ReadOnly = true;
            this.ExactSearchTime.Size = new System.Drawing.Size(196, 26);
            this.ExactSearchTime.TabIndex = 16;
            // 
            // MaxDistBox
            // 
            this.MaxDistBox.Location = new System.Drawing.Point(805, 197);
            this.MaxDistBox.Name = "MaxDistBox";
            this.MaxDistBox.Size = new System.Drawing.Size(196, 26);
            this.MaxDistBox.TabIndex = 17;
            // 
            // ThreadCountBox
            // 
            this.ThreadCountBox.Location = new System.Drawing.Point(805, 238);
            this.ThreadCountBox.Name = "ThreadCountBox";
            this.ThreadCountBox.Size = new System.Drawing.Size(196, 26);
            this.ThreadCountBox.TabIndex = 18;
            // 
            // ApproxTime
            // 
            this.ApproxTime.Location = new System.Drawing.Point(805, 318);
            this.ApproxTime.Name = "ApproxTime";
            this.ApproxTime.ReadOnly = true;
            this.ApproxTime.Size = new System.Drawing.Size(196, 26);
            this.ApproxTime.TabIndex = 19;
            // 
            // CalaulatedThreadCount
            // 
            this.CalaulatedThreadCount.Location = new System.Drawing.Point(805, 280);
            this.CalaulatedThreadCount.Name = "CalaulatedThreadCount";
            this.CalaulatedThreadCount.ReadOnly = true;
            this.CalaulatedThreadCount.Size = new System.Drawing.Size(196, 26);
            this.CalaulatedThreadCount.TabIndex = 20;
            // 
            // ListSearchResults
            // 
            this.ListSearchResults.FormattingEnabled = true;
            this.ListSearchResults.ItemHeight = 20;
            this.ListSearchResults.Location = new System.Drawing.Point(30, 359);
            this.ListSearchResults.Name = "ListSearchResults";
            this.ListSearchResults.Size = new System.Drawing.Size(971, 204);
            this.ListSearchResults.TabIndex = 21;
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(29, 12);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(345, 64);
            this.ReadFile.TabIndex = 22;
            this.ReadFile.Text = "Чтение файла";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // LoadTime
            // 
            this.LoadTime.Location = new System.Drawing.Point(806, 21);
            this.LoadTime.Name = "LoadTime";
            this.LoadTime.ReadOnly = true;
            this.LoadTime.Size = new System.Drawing.Size(195, 26);
            this.LoadTime.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 644);
            this.Controls.Add(this.LoadTime);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.ListSearchResults);
            this.Controls.Add(this.CalaulatedThreadCount);
            this.Controls.Add(this.ApproxTime);
            this.Controls.Add(this.ThreadCountBox);
            this.Controls.Add(this.MaxDistBox);
            this.Controls.Add(this.ExactSearchTime);
            this.Controls.Add(this.WordForSearch);
            this.Controls.Add(this.UniqueWords);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveReport);
            this.Controls.Add(this.ApproxSearch);
            this.Controls.Add(this.ExactSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExactSearch;
        private System.Windows.Forms.Button ApproxSearch;
        private System.Windows.Forms.Button SaveReport;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UniqueWords;
        private System.Windows.Forms.TextBox WordForSearch;
        private System.Windows.Forms.TextBox ExactSearchTime;
        private System.Windows.Forms.TextBox MaxDistBox;
        private System.Windows.Forms.TextBox ThreadCountBox;
        private System.Windows.Forms.TextBox ApproxTime;
        private System.Windows.Forms.TextBox CalaulatedThreadCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox ListSearchResults;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.TextBox LoadTime;
    }
}

