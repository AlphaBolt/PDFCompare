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
            labelErrorMessage.Visible = false;            
            //label4.Text = $"© {DateTime.Now.Year} COFORGE | www.Coforge.com";
        }

        
        private Dictionary<string, ComboBox> multipleSourceComboBox= new Dictionary<string, ComboBox>();
        private Dictionary<string, ComboBox> multipleTargetComboBox = new Dictionary<string, ComboBox>();

        private Dictionary<string, WebBrowser> multipleWebResults = new Dictionary<string, WebBrowser>();
        private Dictionary<string, DataGridView> multipleDatagridViews = new Dictionary<string, DataGridView>();

        private int currentResultIndex = 0;

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // Start comparing only if there is some file selected
            if (!string.IsNullOrEmpty(txtSource.Text) && !string.IsNullOrEmpty(txtTarget.Text))
            {
                btnCompare.Enabled = false;

                multipleWebResults.Clear();
                multipleDatagridViews.Clear();
                resultContentPanel.Controls.Clear();
                // Set whether it will use webresult or image



                //string[] sourceFiles = txtSource.Text.Split(';');
                //string[] targetFiles = txtTarget.Text.Split(';');


                for (int i = 0; i < multipleSourceComboBox.Count; i++)
                {
                    // Image comparison
                    if (text_OR_imageBtn.Checked)    
                    {
                        DataGridView datagridview = new DataGridView
                        {
                            Name = $"datagridview_{i}",
                            AllowUserToAddRows = false,
                            AllowUserToDeleteRows = false,
                            AllowUserToResizeColumns = false,
                            AllowUserToResizeRows = false,
                            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                            Dock = DockStyle.Top,
                            //Location = new Point(0, i * 300),
                            MinimumSize = new Size(30, 31),
                            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5),
                            Size = new Size(300, 300),
                            ReadOnly = true,
                            ShowCellErrors = false,
                            ShowCellToolTips = false,
                            ShowEditingIcon = false,
                            ShowRowErrors = false,

                        };

                        resultContentPanel.Controls.Add(datagridview);
                        datagridview.Dock = DockStyle.Fill;
                        // Store the DataGridView in the Dictionary with its unique name
                        multipleDatagridViews.Add(datagridview.Name, datagridview);
                    }

                    // Text comparison
                    else
                    {
                        WebBrowser webResult = new WebBrowser
                        {
                            Name = $"webResult_{i}",
                            Dock = DockStyle.Top,
                            //Location = new Point(0, i * 300),
                            MinimumSize = new Size(30, 31),
                            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5),
                            //Size = new Size(300, 300),

                        };

                        resultContentPanel.Controls.Add(webResult);
                        webResult.Dock = DockStyle.Fill;
                        // Store the WebBrowser in the Dictionary with its unique name
                        multipleWebResults.Add(webResult.Name, webResult);
                    }

                    CompareFiles(i);
                }

                ShowResult(0);

            }

            materialTabControl1.SelectedTab = resultTabPage;
            btnCompare.Enabled = true;
        }



        private void CompareFiles(int i)
        { 
            var currentDrive = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location);
            var ComparisonReportFile = Path.Combine(ConfigurationManager.AppSettings["ResultPath"].ToString(), @"ComparisonReport.xls");
            //"Q:\\Automation & Performance\\Functional Automation\\DCRegression\\Results\\Excess-Data\\PDF-Diff_Excel-Reports\\PDF_Comparator_Results\\ComparisonReport.xls";


            string File1diff = multipleSourceComboBox[$"sourceComboBox_{i}"].SelectedItem.ToString();
            string File2diff = multipleTargetComboBox[$"targetComboBox_{i}"].SelectedItem.ToString();


            string sourcePageRange = string.Empty;
            //sourcePageRange = txtComparingPagesNumber.Text;

            string targetPageRange = string.Empty;
            //targetPageRange = targetRangeTextBox.Text;


            //multipleWebResults[$"webResult_{i}"].Visible = false;
            //multipleDatagridViews[$"datagridview_{i}"].Visible = false;
            //multipleDatagridViews[$"datagridview_{i}"].DataSource = null;
            //labelErrorMessage.Text = string.Empty;
            //labelErrorMessage.Visible = false;



            //if (rdbImageCompare.Checked)
            if (text_OR_imageBtn.Checked)
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
                                ShowImages(filePaths, i);                           
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
                        multipleWebResults[$"webResult_{i}"].Visible = true;
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
                            multipleWebResults[$"webResult_{i}"].Visible = false;
                            labelErrorMessage.Text = res;
                            labelErrorMessage.BackColor = Color.Red;
                            labelErrorMessage.Visible = true;
                        }
                        else
                        {
                            multipleWebResults[$"webResult_{i}"].DocumentText = res;
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
                    multipleWebResults[$"webResult_{i}"].Visible = false;
                }
            }
        }

        private void ShowImages(string[] files, int i)
        {
            if (files != null && files.Count() > 0)
            {
                multipleDatagridViews[$"datagridview_{i}"].Visible = true;
                DataTable table = new DataTable();
                table.Columns.Add("Images", typeof(Image));
                for (int j = 0; j < files.Count(); j++)
                {
                    table.Rows.Add(Image.FromFile(files[j]));
                }

                multipleDatagridViews[$"datagridview_{i}"].AutoGenerateColumns = false;


                multipleDatagridViews[$"datagridview_{i}"].ColumnCount = 0;


                multipleDatagridViews[$"datagridview_{i}"].ColumnHeadersVisible = false;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                //imageColumn.Name = "Images";
                imageColumn.DataPropertyName = "Images";
                //imageColumn.HeaderText = "Images";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                multipleDatagridViews[$"datagridview_{i}"].Columns.Insert(0, imageColumn);
                multipleDatagridViews[$"datagridview_{i}"].RowTemplate.Height = 1000;
                //multipleDatagridViews[$"datagridview_{i}"].Columns[0].Width = 900;
                multipleDatagridViews[$"datagridview_{i}"].DataSource = table;
            }
            else {
                multipleDatagridViews[$"datagridview_{i}"].Visible = false;
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

        //private void rdbTextCompare_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (((System.Windows.Forms.RadioButton)(sender)).Checked)
        //    {
        //        webResult.DocumentText = string.Empty;
        //        //picResult.Image = null;
        //        //picResult.Visible = false;
        //        webResult.Visible = false;
        //        labelErrorMessage.Text = string.Empty;
        //        labelErrorMessage.Visible = false;
        //        dataGridView1.Visible = false;
        //        dataGridView1.DataSource = null;
        //    }
        //}

        //private void rdbImageCompare_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (((System.Windows.Forms.RadioButton)(sender)).Checked)
        //    {
        //        webResult.DocumentText = string.Empty;
        //        //picResult.Image = null;
        //        //picResult.Visible = false;
        //        webResult.Visible = false;
        //        labelErrorMessage.Text = string.Empty;
        //        labelErrorMessage.Visible = false;
        //        dataGridView1.Visible = false;
        //        dataGridView1.DataSource = null;
        //    }
        //}

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

            // Clear existing controls
            reviewContentPanel.Controls.Clear();

            // Clear combobox and range dictionaries
            multipleSourceComboBox.Clear();
            multipleTargetComboBox.Clear();

            // Add panels with comboboxes and labels
            string[] sourceFiles = txtSource.Text.Split(';');
            string[] targetFiles = txtTarget.Text.Split(';');
            int minNoOfComarisons = Math.Min(sourceFiles.Length, targetFiles.Length);

            for (int i = 0; i < minNoOfComarisons; i++)
            {
                Panel panel = new Panel
                {
                    Size = new Size(800, 80),
                    Location = new Point(80, i * 160)
                };

                //************ Source ************//
                Label sourceLabel = new Label
                {
                    Text = "Source:",
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                ComboBox sourceComboBox = new ComboBox
                {
                    Name = $"sourceComboBox_{i}",
                    Location = new Point(100, 10),
                    Size = new Size(250, 21),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                };
                sourceComboBox.Items.AddRange(sourceFiles);
                sourceComboBox.SelectedIndex = i;

                Button sourceButton = new Button
                {
                    Text = "...",
                    Location = new Point(360, 10),
                    Size = new Size(30, 21)
                };
                sourceButton.Click += (s, ev) => OpenFileDialogForComboBox(sourceComboBox);

                Label sourceRangeLabel = new Label
                {
                    Text = "Select Range:",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                TextBox sourceRangeTextBox = new TextBox
                {
                    Location = new Point(100, 40),
                    Size = new Size(250, 21)
                };

                //************ Target ************//
                Label targetLabel = new Label
                {
                    Text = "Target:",
                    Location = new Point(410, 10),
                    AutoSize = true
                };

                ComboBox targetComboBox = new ComboBox
                {
                    Name = $"targetComboBox_{i}",
                    Location = new Point(500, 10),
                    Size = new Size(250, 21),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                targetComboBox.Items.AddRange(targetFiles);
                targetComboBox.SelectedIndex = i;

                Button targetButton = new Button
                {
                    Text = "...",
                    Location = new Point(760, 10),
                    Size = new Size(30, 21)
                };
                targetButton.Click += (s, ev) => OpenFileDialogForComboBox(targetComboBox);

                Label targetRangeLabel = new Label
                {
                    Text = "Select Range:",
                    Location = new Point(410, 40),
                    AutoSize = true
                };

                TextBox targetRangeTextBox = new TextBox
                {
                    Location = new Point(500, 40),
                    Size = new Size(250, 21)
                };

                panel.Controls.Add(sourceLabel);
                panel.Controls.Add(sourceComboBox);
                panel.Controls.Add(sourceButton);
                panel.Controls.Add(sourceRangeLabel);
                panel.Controls.Add(sourceRangeTextBox);
                panel.Controls.Add(targetLabel);
                panel.Controls.Add(targetComboBox);
                panel.Controls.Add(targetButton);
                panel.Controls.Add(targetRangeLabel);
                panel.Controls.Add(targetRangeTextBox);

                reviewContentPanel.Controls.Add(panel);

                // Store the ComboBoxes in the Dictionary with their unique names
                multipleSourceComboBox.Add(sourceComboBox.Name, sourceComboBox);
                multipleTargetComboBox.Add(targetComboBox.Name, targetComboBox);
            }
            
        }

        // Event handler for Select files in reviewtab
        private void OpenFileDialogForComboBox(ComboBox comboBox)
        {
            OpenFileDialog fileChooser = new OpenFileDialog
            {
                Filter = "Pdf Files|*.pdf",
                Multiselect = false,
                Title = "Select File"
            };

            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = fileChooser.FileName;
                if (!comboBox.Items.Contains(selectedFile))
                {
                    comboBox.Items.Add(selectedFile);
                }
                comboBox.SelectedItem = selectedFile;
            }
        }



        //************** Carousel Feature **************//
        private void ShowResult(int index)
        {
            //foreach (var key in multipleErrorLabels.Keys)
            //{
            //    multipleErrorLabels[key].Visible = false;
            //}
            foreach (var key in multipleWebResults.Keys)
            {
                multipleWebResults[key].Visible = false;
            }
            foreach (var key in multipleDatagridViews.Keys)
            {
                multipleDatagridViews[key].Visible = false;
            }

            //if (multipleErrorLabels.ContainsKey($"errorLabel_{index}"))
            //{
            //    multipleErrorLabels[$"errorLabel_{index}"].Visible = true;
            //}
            if (multipleWebResults.ContainsKey($"webResult_{index}"))
            {
                multipleWebResults[$"webResult_{index}"].Visible = true;
            }
            if (multipleDatagridViews.ContainsKey($"datagridview_{index}"))
            {
                multipleDatagridViews[$"datagridview_{index}"].Visible = true;
            }

            currentResultIndex = index;
        }



        private void previousResult_Click(object sender, EventArgs e)
        {
            //Button works only if file is present
            if (multipleSourceComboBox.Count > 1 && multipleTargetComboBox.Count > 1)
            {
                if (currentResultIndex > 0)
                {
                    ShowResult(currentResultIndex - 1);
                }
            }

        }

        private void nextResult_Click(object sender, EventArgs e)
        {
            //Button works only if file is present
            if (multipleSourceComboBox.Count > 1 && multipleTargetComboBox.Count > 1)
            {
                if (currentResultIndex < multipleSourceComboBox.Count - 1)
                {
                    ShowResult(currentResultIndex + 1);
                }
            }
        }
    }
}
