namespace Lab1
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
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            фильтрыToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            оттенкиСерогоToolStripMenuItem = new ToolStripMenuItem();
            бинаризацияПоПорогуToolStripMenuItem = new ToolStripMenuItem();
            повышениеЯркостиToolStripMenuItem = new ToolStripMenuItem();
            сепияToolStripMenuItem = new ToolStripMenuItem();
            идеальныйОтражательToolStripMenuItem = new ToolStripMenuItem();
            растяжениеГистограмыToolStripMenuItem = new ToolStripMenuItem();
            коррекцияСОпорнымЦветомToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            размытиеToolStripMenuItem = new ToolStripMenuItem();
            матрицаГауссаToolStripMenuItem = new ToolStripMenuItem();
            фильтрСобеляToolStripMenuItem = new ToolStripMenuItem();
            повышениеРезкостиToolStripMenuItem = new ToolStripMenuItem();
            медианныйФильтрToolStripMenuItem = new ToolStripMenuItem();
            тиснениеToolStripMenuItem = new ToolStripMenuItem();
            выделениеГраницToolStripMenuItem = new ToolStripMenuItem();
            щарраToolStripMenuItem = new ToolStripMenuItem();
            прюитToolStripMenuItem = new ToolStripMenuItem();
            переносToolStripMenuItem = new ToolStripMenuItem();
            светящиесяКраяToolStripMenuItem = new ToolStripMenuItem();
            матморфологияToolStripMenuItem = new ToolStripMenuItem();
            расширениеToolStripMenuItem = new ToolStripMenuItem();
            сужениеToolStripMenuItem = new ToolStripMenuItem();
            открытиеToolStripMenuItem = new ToolStripMenuItem();
            закрытиеToolStripMenuItem = new ToolStripMenuItem();
            gradToolStripMenuItem = new ToolStripMenuItem();
            topHatToolStripMenuItem = new ToolStripMenuItem();
            действиеToolStripMenuItem = new ToolStripMenuItem();
            назадToolStripMenuItem = new ToolStripMenuItem();
            вперёдToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            blackHatToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтрыToolStripMenuItem, действиеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(850, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // фильтрыToolStripMenuItem
            // 
            фильтрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem, матморфологияToolStripMenuItem });
            фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            фильтрыToolStripMenuItem.Size = new Size(69, 20);
            фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, оттенкиСерогоToolStripMenuItem, бинаризацияПоПорогуToolStripMenuItem, повышениеЯркостиToolStripMenuItem, сепияToolStripMenuItem, идеальныйОтражательToolStripMenuItem, растяжениеГистограмыToolStripMenuItem, коррекцияСОпорнымЦветомToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(180, 22);
            точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(242, 22);
            инверсияToolStripMenuItem.Text = "Инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            оттенкиСерогоToolStripMenuItem.Size = new Size(242, 22);
            оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
            оттенкиСерогоToolStripMenuItem.Click += оттенкиСерогоToolStripMenuItem_Click;
            // 
            // бинаризацияПоПорогуToolStripMenuItem
            // 
            бинаризацияПоПорогуToolStripMenuItem.Name = "бинаризацияПоПорогуToolStripMenuItem";
            бинаризацияПоПорогуToolStripMenuItem.Size = new Size(242, 22);
            бинаризацияПоПорогуToolStripMenuItem.Text = "Бинаризация по порогу";
            бинаризацияПоПорогуToolStripMenuItem.Click += бинаризацияПоПорогуToolStripMenuItem_Click;
            // 
            // повышениеЯркостиToolStripMenuItem
            // 
            повышениеЯркостиToolStripMenuItem.Name = "повышениеЯркостиToolStripMenuItem";
            повышениеЯркостиToolStripMenuItem.Size = new Size(242, 22);
            повышениеЯркостиToolStripMenuItem.Text = "Повышение яркости";
            повышениеЯркостиToolStripMenuItem.Click += повышениеЯркостиToolStripMenuItem_Click;
            // 
            // сепияToolStripMenuItem
            // 
            сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            сепияToolStripMenuItem.Size = new Size(242, 22);
            сепияToolStripMenuItem.Text = "Сепия";
            сепияToolStripMenuItem.Click += сепияToolStripMenuItem_Click;
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            идеальныйОтражательToolStripMenuItem.Size = new Size(242, 22);
            идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
            идеальныйОтражательToolStripMenuItem.Click += идеальныйОтражательToolStripMenuItem_Click;
            // 
            // растяжениеГистограмыToolStripMenuItem
            // 
            растяжениеГистограмыToolStripMenuItem.Name = "растяжениеГистограмыToolStripMenuItem";
            растяжениеГистограмыToolStripMenuItem.Size = new Size(242, 22);
            растяжениеГистограмыToolStripMenuItem.Text = "Растяжение гистограмы";
            растяжениеГистограмыToolStripMenuItem.Click += растяжениеГистограмыToolStripMenuItem_Click;
            // 
            // коррекцияСОпорнымЦветомToolStripMenuItem
            // 
            коррекцияСОпорнымЦветомToolStripMenuItem.Name = "коррекцияСОпорнымЦветомToolStripMenuItem";
            коррекцияСОпорнымЦветомToolStripMenuItem.Size = new Size(242, 22);
            коррекцияСОпорнымЦветомToolStripMenuItem.Text = "Коррекция с опорным цветом";
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размытиеToolStripMenuItem, матрицаГауссаToolStripMenuItem, фильтрСобеляToolStripMenuItem, повышениеРезкостиToolStripMenuItem, медианныйФильтрToolStripMenuItem, тиснениеToolStripMenuItem, выделениеГраницToolStripMenuItem, переносToolStripMenuItem, светящиесяКраяToolStripMenuItem });
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(180, 22);
            матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            размытиеToolStripMenuItem.Size = new Size(194, 22);
            размытиеToolStripMenuItem.Text = "Размытие";
            размытиеToolStripMenuItem.Click += размытиеToolStripMenuItem_Click;
            // 
            // матрицаГауссаToolStripMenuItem
            // 
            матрицаГауссаToolStripMenuItem.Name = "матрицаГауссаToolStripMenuItem";
            матрицаГауссаToolStripMenuItem.Size = new Size(194, 22);
            матрицаГауссаToolStripMenuItem.Text = "Матрица Гаусса";
            матрицаГауссаToolStripMenuItem.Click += матрицаГауссаToolStripMenuItem_Click;
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            фильтрСобеляToolStripMenuItem.Size = new Size(194, 22);
            фильтрСобеляToolStripMenuItem.Text = "Фильтр Собеля";
            фильтрСобеляToolStripMenuItem.Click += фильтрСобеляToolStripMenuItem_Click;
            // 
            // повышениеРезкостиToolStripMenuItem
            // 
            повышениеРезкостиToolStripMenuItem.Name = "повышениеРезкостиToolStripMenuItem";
            повышениеРезкостиToolStripMenuItem.Size = new Size(194, 22);
            повышениеРезкостиToolStripMenuItem.Text = "Повышение резкости";
            повышениеРезкостиToolStripMenuItem.Click += повышениеРезкостиToolStripMenuItem_Click;
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            медианныйФильтрToolStripMenuItem.Size = new Size(194, 22);
            медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            медианныйФильтрToolStripMenuItem.Click += медианныйФильтрToolStripMenuItem_Click;
            // 
            // тиснениеToolStripMenuItem
            // 
            тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            тиснениеToolStripMenuItem.Size = new Size(194, 22);
            тиснениеToolStripMenuItem.Text = "Тиснение";
            тиснениеToolStripMenuItem.Click += тиснениеToolStripMenuItem_Click;
            // 
            // выделениеГраницToolStripMenuItem
            // 
            выделениеГраницToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { щарраToolStripMenuItem, прюитToolStripMenuItem });
            выделениеГраницToolStripMenuItem.Name = "выделениеГраницToolStripMenuItem";
            выделениеГраницToolStripMenuItem.Size = new Size(194, 22);
            выделениеГраницToolStripMenuItem.Text = "Выделение границ";
            // 
            // щарраToolStripMenuItem
            // 
            щарраToolStripMenuItem.Name = "щарраToolStripMenuItem";
            щарраToolStripMenuItem.Size = new Size(117, 22);
            щарраToolStripMenuItem.Text = "Щарра";
            щарраToolStripMenuItem.Click += щарраToolStripMenuItem_Click;
            // 
            // прюитToolStripMenuItem
            // 
            прюитToolStripMenuItem.Name = "прюитToolStripMenuItem";
            прюитToolStripMenuItem.Size = new Size(117, 22);
            прюитToolStripMenuItem.Text = "Прюитт";
            прюитToolStripMenuItem.Click += прюитToolStripMenuItem_Click;
            // 
            // переносToolStripMenuItem
            // 
            переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            переносToolStripMenuItem.Size = new Size(194, 22);
            переносToolStripMenuItem.Text = "Перенос";
            // 
            // светящиесяКраяToolStripMenuItem
            // 
            светящиесяКраяToolStripMenuItem.Name = "светящиесяКраяToolStripMenuItem";
            светящиесяКраяToolStripMenuItem.Size = new Size(194, 22);
            светящиесяКраяToolStripMenuItem.Text = "Светящиеся края";
            светящиесяКраяToolStripMenuItem.Click += светящиесяКраяToolStripMenuItem_Click;
            // 
            // матморфологияToolStripMenuItem
            // 
            матморфологияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { расширениеToolStripMenuItem, сужениеToolStripMenuItem, открытиеToolStripMenuItem, закрытиеToolStripMenuItem, gradToolStripMenuItem, topHatToolStripMenuItem, blackHatToolStripMenuItem });
            матморфологияToolStripMenuItem.Name = "матморфологияToolStripMenuItem";
            матморфологияToolStripMenuItem.Size = new Size(180, 22);
            матморфологияToolStripMenuItem.Text = "Матморфология";
            // 
            // расширениеToolStripMenuItem
            // 
            расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            расширениеToolStripMenuItem.Size = new Size(180, 22);
            расширениеToolStripMenuItem.Text = "Расширение";
            расширениеToolStripMenuItem.Click += расширениеToolStripMenuItem_Click;
            // 
            // сужениеToolStripMenuItem
            // 
            сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            сужениеToolStripMenuItem.Size = new Size(180, 22);
            сужениеToolStripMenuItem.Text = "Сужение";
            сужениеToolStripMenuItem.Click += сужениеToolStripMenuItem_Click;
            // 
            // открытиеToolStripMenuItem
            // 
            открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            открытиеToolStripMenuItem.Size = new Size(180, 22);
            открытиеToolStripMenuItem.Text = "Открытие";
            открытиеToolStripMenuItem.Click += открытиеToolStripMenuItem_Click;
            // 
            // закрытиеToolStripMenuItem
            // 
            закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            закрытиеToolStripMenuItem.Size = new Size(180, 22);
            закрытиеToolStripMenuItem.Text = "Закрытие";
            закрытиеToolStripMenuItem.Click += закрытиеToolStripMenuItem_Click;
            // 
            // gradToolStripMenuItem
            // 
            gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            gradToolStripMenuItem.Size = new Size(180, 22);
            gradToolStripMenuItem.Text = "Grad";
            gradToolStripMenuItem.Click += gradToolStripMenuItem_Click;
            // 
            // topHatToolStripMenuItem
            // 
            topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            topHatToolStripMenuItem.Size = new Size(180, 22);
            topHatToolStripMenuItem.Text = "TopHat";
            topHatToolStripMenuItem.Click += topHatToolStripMenuItem_Click;
            // 
            // действиеToolStripMenuItem
            // 
            действиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { назадToolStripMenuItem, вперёдToolStripMenuItem });
            действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            действиеToolStripMenuItem.Size = new Size(70, 20);
            действиеToolStripMenuItem.Text = "Действие";
            // 
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(113, 22);
            назадToolStripMenuItem.Text = "Назад";
            назадToolStripMenuItem.Click += назадToolStripMenuItem_Click;
            // 
            // вперёдToolStripMenuItem
            // 
            вперёдToolStripMenuItem.Name = "вперёдToolStripMenuItem";
            вперёдToolStripMenuItem.Size = new Size(113, 22);
            вперёдToolStripMenuItem.Text = "Вперёд";
            вперёдToolStripMenuItem.Click += вперёдToolStripMenuItem_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressBar1.Location = new Point(0, 433);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(735, 25);
            progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(741, 433);
            button1.Name = "button1";
            button1.Size = new Size(97, 25);
            button1.TabIndex = 3;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // blackHatToolStripMenuItem
            // 
            blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            blackHatToolStripMenuItem.Size = new Size(180, 22);
            blackHatToolStripMenuItem.Text = "BlackHat";
            blackHatToolStripMenuItem.Click += blackHatToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 458);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button button1;
        private ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private ToolStripMenuItem бинаризацияПоПорогуToolStripMenuItem;
        private ToolStripMenuItem повышениеЯркостиToolStripMenuItem;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem матрицаГауссаToolStripMenuItem;
        private ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private ToolStripMenuItem повышениеРезкостиToolStripMenuItem;
        private ToolStripMenuItem медианныйФильтрToolStripMenuItem;
        private ToolStripMenuItem тиснениеToolStripMenuItem;
        private ToolStripMenuItem выделениеГраницToolStripMenuItem;
        private ToolStripMenuItem щарраToolStripMenuItem;
        private ToolStripMenuItem прюитToolStripMenuItem;
        private ToolStripMenuItem переносToolStripMenuItem;
        private ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private ToolStripMenuItem светящиесяКраяToolStripMenuItem;
        private ToolStripMenuItem растяжениеГистограмыToolStripMenuItem;
        private ToolStripMenuItem коррекцияСОпорнымЦветомToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem действиеToolStripMenuItem;
        private ToolStripMenuItem назадToolStripMenuItem;
        private ToolStripMenuItem вперёдToolStripMenuItem;
        private ToolStripMenuItem матморфологияToolStripMenuItem;
        private ToolStripMenuItem расширениеToolStripMenuItem;
        private ToolStripMenuItem сужениеToolStripMenuItem;
        private ToolStripMenuItem открытиеToolStripMenuItem;
        private ToolStripMenuItem закрытиеToolStripMenuItem;
        private ToolStripMenuItem gradToolStripMenuItem;
        private ToolStripMenuItem topHatToolStripMenuItem;
        private ToolStripMenuItem blackHatToolStripMenuItem;
    }
}