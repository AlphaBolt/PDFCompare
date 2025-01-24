using System;
namespace PDFCompare
{
    partial class comparePDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comparePDF));
            this.materialTabSelector1 = new MaterialWinforms.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialWinforms.Controls.MaterialTabControl();
            this.selectFilesTabPage = new MaterialWinforms.Controls.MaterialTabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text_OR_imageBtn = new MaterialWinforms.Controls.MaterialToggle();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnbrwTarget = new System.Windows.Forms.Button();
            this.btnbrwSource = new System.Windows.Forms.Button();
            this.reviewTabPage = new MaterialWinforms.Controls.MaterialTabPage();
            this.reviewContentPanel = new MaterialWinforms.Controls.MaterialPanel();
            this.progressBarPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.resultTabPage = new MaterialWinforms.Controls.MaterialTabPage();
            this.resultContentPanel = new MaterialWinforms.Controls.MaterialPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelErrorMessage = new System.Windows.Forms.TextBox();
            this.nextResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.previousResult = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.selectFilesTabPage.SuspendLayout();
            this.reviewTabPage.SuspendLayout();
            this.progressBarPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.resultTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CenterTabs = false;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Elevation = 10;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.materialTabSelector1.MaxTabWidht = -1;
            this.materialTabSelector1.MouseState = MaterialWinforms.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialTabSelector1.ShadowBorder = graphicsPath1;
            this.materialTabSelector1.Size = new System.Drawing.Size(918, 35);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.TabPadding = 24;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.selectFilesTabPage);
            this.materialTabControl1.Controls.Add(this.reviewTabPage);
            this.materialTabControl1.Controls.Add(this.resultTabPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 35);
            this.materialTabControl1.MouseState = MaterialWinforms.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 1;
            this.materialTabControl1.Size = new System.Drawing.Size(918, 470);
            this.materialTabControl1.TabIndex = 4;
            this.materialTabControl1.TabsAreClosable = true;
            // 
            // selectFilesTabPage
            // 
            this.selectFilesTabPage.Closable = false;
            this.selectFilesTabPage.Controls.Add(this.button1);
            this.selectFilesTabPage.Controls.Add(this.reviewButton);
            this.selectFilesTabPage.Controls.Add(this.textBox2);
            this.selectFilesTabPage.Controls.Add(this.textBox1);
            this.selectFilesTabPage.Controls.Add(this.text_OR_imageBtn);
            this.selectFilesTabPage.Controls.Add(this.txtTarget);
            this.selectFilesTabPage.Controls.Add(this.txtSource);
            this.selectFilesTabPage.Controls.Add(this.btnbrwTarget);
            this.selectFilesTabPage.Controls.Add(this.btnbrwSource);
            this.selectFilesTabPage.Depth = 0;
            this.selectFilesTabPage.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFilesTabPage.Location = new System.Drawing.Point(4, 29);
            this.selectFilesTabPage.MouseState = MaterialWinforms.MouseState.HOVER;
            this.selectFilesTabPage.Name = "selectFilesTabPage";
            this.selectFilesTabPage.Size = new System.Drawing.Size(910, 437);
            this.selectFilesTabPage.TabIndex = 0;
            this.selectFilesTabPage.Text = "Select File(s)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(599, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 54);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Image";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(229, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 49);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Text";
            // 
            // text_OR_imageBtn
            // 
            this.text_OR_imageBtn.AutoSize = true;
            this.text_OR_imageBtn.Depth = 0;
            this.text_OR_imageBtn.EllipseBorderColor = "#3b73d1";
            this.text_OR_imageBtn.EllipseColor = "#508ef5";
            this.text_OR_imageBtn.Location = new System.Drawing.Point(440, 65);
            this.text_OR_imageBtn.MouseState = MaterialWinforms.MouseState.HOVER;
            this.text_OR_imageBtn.Name = "text_OR_imageBtn";
            this.text_OR_imageBtn.Size = new System.Drawing.Size(47, 19);
            this.text_OR_imageBtn.TabIndex = 5;
            this.text_OR_imageBtn.UseVisualStyleBackColor = true;
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.Location = new System.Drawing.Point(635, 238);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(100, 27);
            this.txtTarget.TabIndex = 4;
            this.txtTarget.Visible = false;
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(192, 238);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 27);
            this.txtSource.TabIndex = 3;
            this.txtSource.Visible = false;
            // 
            // btnbrwTarget
            // 
            this.btnbrwTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrwTarget.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrwTarget.Location = new System.Drawing.Point(610, 173);
            this.btnbrwTarget.Name = "btnbrwTarget";
            this.btnbrwTarget.Size = new System.Drawing.Size(148, 58);
            this.btnbrwTarget.TabIndex = 1;
            this.btnbrwTarget.Text = "Select Target File(s)";
            this.btnbrwTarget.UseVisualStyleBackColor = true;
            this.btnbrwTarget.Click += new System.EventHandler(this.btnbrwTarget_Click);
            // 
            // btnbrwSource
            // 
            this.btnbrwSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrwSource.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrwSource.Location = new System.Drawing.Point(160, 173);
            this.btnbrwSource.Name = "btnbrwSource";
            this.btnbrwSource.Size = new System.Drawing.Size(164, 58);
            this.btnbrwSource.TabIndex = 0;
            this.btnbrwSource.Text = "Select Source File(s)";
            this.btnbrwSource.UseVisualStyleBackColor = true;
            this.btnbrwSource.Click += new System.EventHandler(this.btnbrwSource_Click);
            // 
            // reviewTabPage
            // 
            this.reviewTabPage.AutoScroll = true;
            this.reviewTabPage.Closable = false;
            this.reviewTabPage.Controls.Add(this.reviewContentPanel);
            this.reviewTabPage.Controls.Add(this.progressBarPanel);
            this.reviewTabPage.Controls.Add(this.panel3);
            this.reviewTabPage.Depth = 0;
            this.reviewTabPage.Location = new System.Drawing.Point(4, 29);
            this.reviewTabPage.MouseState = MaterialWinforms.MouseState.HOVER;
            this.reviewTabPage.Name = "reviewTabPage";
            this.reviewTabPage.Size = new System.Drawing.Size(910, 437);
            this.reviewTabPage.TabIndex = 1;
            this.reviewTabPage.Text = "Review";
            // 
            // reviewContentPanel
            // 
            this.reviewContentPanel.AutoScroll = true;
            this.reviewContentPanel.Depth = 0;
            this.reviewContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewContentPanel.Location = new System.Drawing.Point(0, 0);
            this.reviewContentPanel.MouseState = MaterialWinforms.MouseState.HOVER;
            this.reviewContentPanel.Name = "reviewContentPanel";
            this.reviewContentPanel.Size = new System.Drawing.Size(910, 264);
            this.reviewContentPanel.TabIndex = 2;
            // 
            // progressBarPanel
            // 
            this.progressBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.progressBarPanel.Controls.Add(this.progressBar1);
            this.progressBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarPanel.Location = new System.Drawing.Point(0, 264);
            this.progressBarPanel.Name = "progressBarPanel";
            this.progressBarPanel.Size = new System.Drawing.Size(910, 45);
            this.progressBarPanel.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(32, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(824, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.btnCompare);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 128);
            this.panel3.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.BackColor = System.Drawing.Color.White;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Location = new System.Drawing.Point(32, 27);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(824, 63);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // resultTabPage
            // 
            this.resultTabPage.Closable = false;
            this.resultTabPage.Controls.Add(this.resultContentPanel);
            this.resultTabPage.Controls.Add(this.panel2);
            this.resultTabPage.Controls.Add(this.panel1);
            this.resultTabPage.Depth = 0;
            this.resultTabPage.Location = new System.Drawing.Point(4, 29);
            this.resultTabPage.MouseState = MaterialWinforms.MouseState.HOVER;
            this.resultTabPage.Name = "resultTabPage";
            this.resultTabPage.Size = new System.Drawing.Size(910, 437);
            this.resultTabPage.TabIndex = 2;
            this.resultTabPage.Text = "Result";
            // 
            // resultContentPanel
            // 
            this.resultContentPanel.AutoScroll = true;
            this.resultContentPanel.Depth = 0;
            this.resultContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultContentPanel.Location = new System.Drawing.Point(50, 0);
            this.resultContentPanel.MouseState = MaterialWinforms.MouseState.HOVER;
            this.resultContentPanel.Name = "resultContentPanel";
            this.resultContentPanel.Size = new System.Drawing.Size(810, 437);
            this.resultContentPanel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelErrorMessage);
            this.panel2.Controls.Add(this.nextResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(860, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 437);
            this.panel2.TabIndex = 7;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.Location = new System.Drawing.Point(-26, 98);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(100, 26);
            this.labelErrorMessage.TabIndex = 6;
            // 
            // nextResult
            // 
            this.nextResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nextResult.FlatAppearance.BorderSize = 0;
            this.nextResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextResult.Location = new System.Drawing.Point(6, 205);
            this.nextResult.Name = "nextResult";
            this.nextResult.Size = new System.Drawing.Size(39, 40);
            this.nextResult.TabIndex = 0;
            this.nextResult.Text = ">";
            this.nextResult.UseVisualStyleBackColor = true;
            this.nextResult.Click += new System.EventHandler(this.nextResult_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previousResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 437);
            this.panel1.TabIndex = 6;
            // 
            // previousResult
            // 
            this.previousResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.previousResult.FlatAppearance.BorderSize = 0;
            this.previousResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousResult.Location = new System.Drawing.Point(9, 205);
            this.previousResult.Name = "previousResult";
            this.previousResult.Size = new System.Drawing.Size(38, 40);
            this.previousResult.TabIndex = 0;
            this.previousResult.Text = "<";
            this.previousResult.UseVisualStyleBackColor = true;
            this.previousResult.Click += new System.EventHandler(this.previousResult_Click);
            // 
            // reviewButton
            // 
            this.reviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewButton.Location = new System.Drawing.Point(405, 325);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(101, 42);
            this.reviewButton.TabIndex = 8;
            this.reviewButton.Text = "Review";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(759, 343);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // comparePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(918, 505);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "comparePDF";
            this.Text = "Compare PDF";
            this.materialTabControl1.ResumeLayout(false);
            this.selectFilesTabPage.ResumeLayout(false);
            this.selectFilesTabPage.PerformLayout();
            this.reviewTabPage.ResumeLayout(false);
            this.progressBarPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.resultTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialWinforms.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialWinforms.Controls.MaterialTabControl materialTabControl1;
        private MaterialWinforms.Controls.MaterialTabPage selectFilesTabPage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialWinforms.Controls.MaterialToggle text_OR_imageBtn;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnbrwTarget;
        private System.Windows.Forms.Button btnbrwSource;
        private MaterialWinforms.Controls.MaterialTabPage reviewTabPage;
        private MaterialWinforms.Controls.MaterialTabPage resultTabPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialWinforms.Controls.MaterialPanel resultContentPanel;
        private System.Windows.Forms.TextBox labelErrorMessage;
        private System.Windows.Forms.Button nextResult;
        private System.Windows.Forms.Button previousResult;
        private System.Windows.Forms.Panel progressBarPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCompare;
        private MaterialWinforms.Controls.MaterialPanel reviewContentPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Button button1;
    }
}