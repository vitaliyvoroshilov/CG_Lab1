using System.ComponentModel;
namespace Lab1
{
    public partial class Form1 : Form
    {
        Bitmap img;
        Bitmap[] imgs;
        int imgState, imgSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Width = (int)(pictureBox1.Width * 0.85);
            button1.Width = (int)(pictureBox1.Width * 0.15);
            button1.Left = progressBar1.Left + progressBar1.Width;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            progressBar1.Width = (int)(pictureBox1.Width * 0.85);
            button1.Width = (int)(pictureBox1.Width * 0.15);
            button1.Left = progressBar1.Left + progressBar1.Width;
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgState = 0;
                imgSize = 1;
                imgs = new Bitmap[100];
                img = new Bitmap(dialog.FileName);
                imgs[imgState] = img;
                pictureBox1.Image = imgs[imgState];
                pictureBox1.Refresh();
            }
        }

        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != null)
                imgs[imgState].Save(saveFileDialog.FileName);
        }
        private void íàçàäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgState > 0)
            {
                imgState -= 1;
                pictureBox1.Image = imgs[imgState];
                pictureBox1.Refresh();
            }
        }

        private void âïåğ¸äToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgState < imgSize - 1)
            {
                imgState += 1;
                pictureBox1.Image = imgs[imgState];
                pictureBox1.Refresh();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(imgs[imgState], backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                imgState += 1;
                imgSize += 1;
                imgs[imgState] = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = imgs[imgState];
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void èíâåğñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            //Bitmap resultimage = filter.processImage(img);
            //pictureBox1.Image = resultimage;
            //pictureBox1.Refresh();
        }

        private void îòòåíêèÑåğîãîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grayfilterscs filter = new Grayfilterscs();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void áèíàğèçàöèÿÏîÏîğîãóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binary filter = new Binary();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîâûøåíèåßğêîñòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brightness filter = new Brightness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlureFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepia filter = new Sepia();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ìàòğèöàÃàóññàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new CreateGausskernel();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ôèëüòğÑîáåëÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobel filter = new Sobel();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîâûøåíèåĞåçêîñòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clarityimage filter = new Clarityimage();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ìåäèàííûéÔèëüòğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Median filter = new Median();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingray filter = new Ingray();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ùàğğàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sharra filter = new Sharra();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïğşèòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prewitt filter = new Prewitt();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void èäåàëüíûéÎòğàæàòåëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfectReflector filter = new PerfectReflector();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñâåòÿùèåñÿÊğàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ğàñòÿæåíèåÃèñòîãğàìûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gistogram filter = new Gistogram();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğàñøèğåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation filter = new Dilation();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñóæåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion filter = new Erosion();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void îòêğûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion filter1 = new Erosion();
            imgs[imgState] = filter1.processImage(imgs[imgState], null);
            Dilation filter2 = new Dilation();
            backgroundWorker1.RunWorkerAsync(filter2);
        }

        private void çàêğûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation filter1 = new Dilation();
            imgs[imgState] = filter1.processImage(imgs[imgState], null);
            Erosion filter2 = new Erosion();
            backgroundWorker1.RunWorkerAsync(filter2);
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation filter1 = new Dilation();
            imgs[imgState + 1] = filter1.processImage(imgs[imgState], null);
            imgState += 1;
            imgSize += 1;
            Erosion filter2 = new Erosion();
            imgs[imgState + 1] = filter2.processImage(imgs[imgState - 1], null);
            imgState += 1;
            imgSize += 1;
            ImageSubtraction filter3 = new ImageSubtraction();
            imgs[imgState + 1] = filter3.processImage(imgs[imgState - 1], imgs[imgState], null);
            imgState += 1;
            imgSize += 1;
            pictureBox1.Image = imgs[imgState];
            pictureBox1.Refresh();
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation filter1 = new Dilation();
            imgs[imgState + 1] = filter1.processImage(imgs[imgState], null);
            imgState += 1;
            imgSize += 1;
            Erosion filter2 = new Erosion();
            imgs[imgState] = filter2.processImage(imgs[imgState], null);
            ImageSubtraction filter3 = new ImageSubtraction();
            imgs[imgState + 1] = filter3.processImage(imgs[imgState - 1], imgs[imgState], null);
            imgState += 1;
            imgSize += 1;
            pictureBox1.Image = imgs[imgState];
            pictureBox1.Refresh();
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion filter1 = new Erosion();
            imgs[imgState + 1] = filter1.processImage(imgs[imgState], null);
            imgState += 1;
            imgSize += 1;
            Dilation filter2 = new Dilation();
            imgs[imgState] = filter2.processImage(imgs[imgState], null);
            ImageSubtraction filter3 = new ImageSubtraction();
            imgs[imgState + 1] = filter3.processImage(imgs[imgState], imgs[imgState - 1], null);
            imgState += 1;
            imgSize += 1;
            pictureBox1.Image = imgs[imgState];
            pictureBox1.Refresh();
        }
    }
}