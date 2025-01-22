using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompareUtility;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace PDFCompare
{
    public partial class comparePDF : Form
    {
        public comparePDF()
        {
            InitializeComponent();
            dataGridView1.Visible = false;            
            webResult.Visible = false;
            labelErrorMessage.Visible = false;            
            //label4.Text = $"© {DateTime.Now.Year} COFORGE | www.Coforge.com";
        }



        private Dictionary<string, WebBrowser> multipleWebResults = new Dictionary<string, WebBrowser>();
        

        private void btnCompare_Click(object sender, EventArgs e)
        {
            
            multipleWebResults.Clear();

            // Set whether it will use webresult or image


            string[] sourceFiles = txtSource.Text.Split(';');
            string[] targetFiles = txtTarget.Text.Split(';');

            int minNoOfComarisons = Math.Min(sourceFiles.Length, targetFiles.Length);

            for (int i = 0; i < minNoOfComarisons; i++)
            {
                if (text_OR_imageBtn.Checked)    // Image comparison
                {

                }

                else    // Text comparison
                {
                    WebBrowser webResult = new WebBrowser
                    {
                        Dock = DockStyle.Fill,
                        Location = new Point(0, i * 300),
                        MinimumSize = new Size(30, 31),
                        Margin = new System.Windows.Forms.Padding(4, 5, 4, 5),
                        Name = $"webResult_{i}",

                    };

                    resultTabPage.Controls.Add(webResult);
                    // Store the WebBrowser in the Dictionary with its unique name
                    multipleWebResults.Add(webResult.Name, webResult);
                }

                string sourceFile = sourceFiles[i].Trim();
                string targetFile = targetFiles[i].Trim();
                CompareFiles(sourceFile, targetFile, i);
            }



        }



        private void CompareFiles(string File1diff, string File2diff, int i)
        { 
            var currentDrive = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location);
            var ComparisonReportFile = Path.Combine(ConfigurationManager.AppSettings["ResultPath"].ToString(), @"ComparisonReport.xls");
            //"Q:\\Automation & Performance\\Functional Automation\\DCRegression\\Results\\Excess-Data\\PDF-Diff_Excel-Reports\\PDF_Comparator_Results\\ComparisonReport.xls";


            string sourcePageRange = string.Empty;
            //sourcePageRange = txtComparingPagesNumber.Text;

            string targetPageRange = string.Empty;
            //targetPageRange = targetRangeTextBox.Text;

            
            webResult.Visible = false;
            dataGridView1.Visible = false;
            dataGridView1.DataSource = null;
            labelErrorMessage.Text = string.Empty;
            labelErrorMessage.Visible = false;



            //if (text_OR_imageToggle.Checked)
            if (rdbImageCompare.Checked)

                {
                    try
                {
                    if (!string.IsNullOrEmpty(File1diff.Trim()) && !string.IsNullOrEmpty(File2diff.Trim()))
                    {

                        var result = Program.fnPDFDiff_FormTemplate(File1diff, File2diff, ComparisonReportFile, sourcePageRange, targetPageRange, true);

                        if (result.Message.Split('|')[1] != "Page Numbers are Not Same" && result.Message.Split('|')[1] != "Both PDF are same." && result.Message.Split('|')[1]!= "Please provide source and target same range to compare due to different number of pages.")
                        {
                            string resultImage = Path.Combine(ConfigurationManager.AppSettings["ResultPath"].ToString(), @"Reports");
                          //"Q:\\Automation & Performance\\Functional Automation\\DCRegression\\Results\\Excess-Data\\PDF-Diff_Excel-Reports\\PDF_Comparator_Results\\Reports";

                            DirectoryInfo resultfolder = new DirectoryInfo(resultImage);
                            DirectoryInfo latestdir = resultfolder.GetDirectories().OrderByDescending(f => f.CreationTime).FirstOrDefault();

                            ImageList imageList = new ImageList();
                            string imagePath = Path.Combine(latestdir.FullName, "Differences");

                            if (Directory.Exists(imagePath))
                            {
                                    string[] filePaths = Directory.GetFiles(imagePath, "*.jpg").Where(x => x.Contains("CombinedDiff")).ToArray();
                                    ShowImages(filePaths);                                
                            }                           
                        }

                        if (result.Message.Split('|')[1] == "Please provide source and target same range to compare due to different number of pages.") {
                            labelErrorMessage.Text = "Please provide source and target same range to compare due to different number of pages.";
                            labelErrorMessage.BackColor = Color.Red;
                            labelErrorMessage.Visible = true;
                            
                        }                        

                        if (result.Message.Split('|')[2] != string.Empty && result.Message.Split('|')[2] == "True" && result.Message.Split('|')[1] != "Please provide source and target same range to compare due to different number of pages.")
                        {
                            labelErrorMessage.Text = "Pass";
                            labelErrorMessage.BackColor = Color.Green;
                            labelErrorMessage.Visible = true;
                        }
                        else if (result.Message.Split('|')[2] != string.Empty && result.Message.Split('|')[2] == "False" && result.Message.Split('|')[1] != "Please provide source and target same range to compare due to different number of pages.")
                        {
                            labelErrorMessage.Text = "Fail";
                            labelErrorMessage.BackColor = Color.Red;
                            labelErrorMessage.Visible = true;
                        }

                    }
                    else
                    {
                        labelErrorMessage.Text = "Files does not exist.";
                        labelErrorMessage.BackColor = Color.Red;
                        labelErrorMessage.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    //labelErrorMessage.Text = "Failure";
                    //labelErrorMessage.Visible = true;
                }
            }
            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(File1diff.Trim()) && !string.IsNullOrEmpty(File2diff.Trim()))
                    {

                        
                        PDFComaprer pdfcompare = new PDFComaprer();
                        //List<int> list = Common.PagesToCompare(pagesToCompare);

                        var result = Program.fnPDFDiff_FormTemplate(File1diff, File2diff, ComparisonReportFile, sourcePageRange, targetPageRange, false);

                        string res = result.CompareText; //pdfcompare.CompareTwoPDFReport(File1diff, File2diff, list);
                        webResult.Visible = true;
                        if (result.Message.Split('|')[2] != string.Empty && result.Message.Split('|')[2] == "True")
                        {
                            labelErrorMessage.Text = "Pass";
                            labelErrorMessage.BackColor = Color.Green;
                            labelErrorMessage.Visible = true;
                        }
                        else if (result.Message.Split('|')[2] != string.Empty && result.Message.Split('|')[2] == "False")
                        {
                            labelErrorMessage.Text = "Fail";
                            labelErrorMessage.BackColor = Color.Red;
                            labelErrorMessage.Visible = true;
                        }

                        if (res == "Files does not exist." || res == "Fail")
                        {
                            webResult.Visible = false;
                            labelErrorMessage.Text = res;
                            labelErrorMessage.BackColor = Color.Red;
                            labelErrorMessage.Visible = true;
                        }
                        else
                        {
                            webResult.DocumentText = res;
                        }
                    }
                    else {
                        labelErrorMessage.Text = "Files does not exist.";
                        labelErrorMessage.BackColor = Color.Red;
                        labelErrorMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    webResult.Visible = false;
                }
            }
        }

        private void ShowImages(string[] files)
        {
            if (files != null && files.Count() > 0)
            {
                dataGridView1.Visible = true;
                DataTable table = new DataTable();
                table.Columns.Add("Images", typeof(Image));
                for (int i = 0; i < files.Count(); i++)
                {
                    table.Rows.Add(Image.FromFile(files[i]));
                }

                dataGridView1.AutoGenerateColumns = false;


                dataGridView1.ColumnCount = 0;


                dataGridView1.ColumnHeadersVisible = false;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                //imageColumn.Name = "Images";
                imageColumn.DataPropertyName = "Images";
                //imageColumn.HeaderText = "Images";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.Columns.Insert(0, imageColumn);
                dataGridView1.RowTemplate.Height = 1000;
                //dataGridView1.Columns[0].Width = 900;
                dataGridView1.DataSource = table;
            }
            else {
                dataGridView1.Visible = false;
            }

        }

        public Image ResizeImage(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }


        private void CombineImages(string[] files, string imagePath)
        {
            string finalImage = Path.Combine(imagePath, "FinalImage.jpg");

            List<int> imageHeights = new List<int>();

            int nIndex = 0;
            int width = 0;
            int height = 0;

            foreach (var file in files)
            {
                Image img = Image.FromFile(file);

                imageHeights.Add(img.Height);
                width += img.Width;
                img.Dispose();
            }

            imageHeights.Sort();
            height = imageHeights[imageHeights.Count - 1];
            Bitmap img3 = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img3);
            g.Clear(SystemColors.AppWorkspace);

            foreach (var file in files)
            {
                Image img = Image.FromFile(file);
                if (nIndex == 0)
                {
                    g.DrawImage(img, new Point(0, 0));
                    nIndex++;
                    width = img.Width;
                }
                else
                {
                    g.DrawImage(img, new Point(width, 0));
                    width += img.Width;
                }

                img.Dispose();
            }

            g.Dispose();
            img3.Save(finalImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            img3.Dispose();

            //picResult.Image = Image.FromFile(finalImage);

        }

        private void btnbrwSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Pdf Files|*.pdf";
            fileChooser.Multiselect = true;
            fileChooser.Title = "Select Source File(s)";

            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                //txtSource.Text = fileChooser.FileName;
                txtSource.Text = string.Join(";", fileChooser.FileNames);
            }

        }

        private void btnbrwTarget_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Pdf Files|*.pdf";
            fileChooser.Multiselect = true;
            fileChooser.Title = "Select Target File(s)";

            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                //txtTarget.Text = fileChooser.FileName;
                txtTarget.Text = string.Join(";", fileChooser.FileNames);
            }
            Console.WriteLine(txtTarget.Text);
        }

        private void rdbTextCompare_CheckedChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.RadioButton)(sender)).Checked)
            {
                webResult.DocumentText = string.Empty;
                //picResult.Image = null;
                //picResult.Visible = false;
                webResult.Visible = false;
                labelErrorMessage.Text = string.Empty;
                labelErrorMessage.Visible = false;
                dataGridView1.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void rdbImageCompare_CheckedChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.RadioButton)(sender)).Checked)
            {
                webResult.DocumentText = string.Empty;
                //picResult.Image = null;
                //picResult.Visible = false;
                webResult.Visible = false;
                labelErrorMessage.Text = string.Empty;
                labelErrorMessage.Visible = false;
                dataGridView1.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void txtComparingPagesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToPressWithCommaAndDashSeparation(e);
        }

       

        private void targetRangeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToPressWithCommaAndDashSeparation(e);
        }

        private static void AllowOnlyNumbersToPressWithCommaAndDashSeparation(KeyPressEventArgs e)
        {
            for (int h = 58; h <= 127; h++)
            {
                if (e.KeyChar == h)
                {
                    e.Handled = true;
                }
            }
            for (int k = 32; k <= 47; k++)
            {
                if (e.KeyChar != 44 && e.KeyChar != 45)
                {
                    if (e.KeyChar == k && e.KeyChar != 44)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = reviewTabPage;

            // Add no. of source and target dropdowns as selected in SelectTab
            
            

        }
    }
}
