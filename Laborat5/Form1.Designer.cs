namespace Laborat5
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
            this.SearchTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadTime = new System.Windows.Forms.TextBox();
            this.ListSearch = new System.Windows.Forms.ListBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxDist = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SearchTime
            // 
            this.SearchTime.Location = new System.Drawing.Point(650, 118);
            this.SearchTime.Name = "SearchTime";
            this.SearchTime.ReadOnly = true;
            this.SearchTime.Size = new System.Drawing.Size(195, 26);
            this.SearchTime.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Время поиска:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Время загрузки в список:";
            // 
            // LoadTime
            // 
            this.LoadTime.Location = new System.Drawing.Point(650, 42);
            this.LoadTime.Name = "LoadTime";
            this.LoadTime.ReadOnly = true;
            this.LoadTime.Size = new System.Drawing.Size(195, 26);
            this.LoadTime.TabIndex = 14;
            // 
            // ListSearch
            // 
            this.ListSearch.FormattingEnabled = true;
            this.ListSearch.ItemHeight = 20;
            this.ListSearch.Location = new System.Drawing.Point(35, 262);
            this.ListSearch.Name = "ListSearch";
            this.ListSearch.Size = new System.Drawing.Size(553, 244);
            this.ListSearch.TabIndex = 13;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(35, 211);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(348, 26);
            this.SearchText.TabIndex = 12;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(650, 450);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(195, 56);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(399, 207);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(189, 34);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(114, 73);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(321, 51);
            this.ReadFile.TabIndex = 9;
            this.ReadFile.Text = "Чтение файла";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Максимальное расстояние:";
            // 
            // MaxDist
            // 
            this.MaxDist.Location = new System.Drawing.Point(650, 285);
            this.MaxDist.Name = "MaxDist";
            this.MaxDist.Size = new System.Drawing.Size(195, 26);
            this.MaxDist.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 548);
            this.Controls.Add(this.MaxDist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadTime);
            this.Controls.Add(this.ListSearch);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoadTime;
        private System.Windows.Forms.ListBox ListSearch;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxDist;
        private System.Windows.Forms.Timer timer1;
    }
}

