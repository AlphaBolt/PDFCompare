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
            this.materialTabSelector1 = new MaterialWinforms.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialWinforms.Controls.MaterialTabControl();
            this.selectFilesTabPage = new MaterialWinforms.Controls.MaterialTabPage();
            this.rdbImageCompare = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdbTextCompare = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text_OR_imageBtn = new MaterialWinforms.Controls.MaterialToggle();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.reviewButton = new MaterialWinforms.Controls.MaterialFlatButton();
            this.btnbrwTarget = new System.Windows.Forms.Button();
            this.btnbrwSource = new System.Windows.Forms.Button();
            this.reviewTabPage = new MaterialWinforms.Controls.MaterialTabPage();
            this.reviewContentPanel = new MaterialWinforms.Controls.MaterialPanel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.resultTabPage = new MaterialWinforms.Controls.MaterialTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.previousResult = new System.Windows.Forms.Button();
            this.nextResult = new System.Windows.Forms.Button();
            this.resultContentPanel = new MaterialWinforms.Controls.MaterialPanel();
            this.labelErrorMessage = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.selectFilesTabPage.SuspendLayout();
            this.reviewTabPage.SuspendLayout();
            this.resultTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.materialTabSelector1.MaxTabWidht = -1;
            this.materialTabSelector1.MouseState = MaterialWinforms.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialTabSelector1.ShadowBorder = graphicsPath1;
            this.materialTabSelector1.Size = new System.Drawing.Size(1034, 35);
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
            this.materialTabControl1.SelectedIndex = 2;
            this.materialTabControl1.Size = new System.Drawing.Size(1034, 473);
            this.materialTabControl1.TabIndex = 4;
            this.materialTabControl1.TabsAreClosable = true;
            // 
            // selectFilesTabPage
            // 
            this.selectFilesTabPage.Closable = false;
            this.selectFilesTabPage.Controls.Add(this.rdbImageCompare);
            this.selectFilesTabPage.Controls.Add(this.textBox2);
            this.selectFilesTabPage.Controls.Add(this.rdbTextCompare);
            this.selectFilesTabPage.Controls.Add(this.textBox1);
            this.selectFilesTabPage.Controls.Add(this.text_OR_imageBtn);
            this.selectFilesTabPage.Controls.Add(this.txtTarget);
            this.selectFilesTabPage.Controls.Add(this.txtSource);
            this.selectFilesTabPage.Controls.Add(this.reviewButton);
            this.selectFilesTabPage.Controls.Add(this.btnbrwTarget);
            this.selectFilesTabPage.Controls.Add(this.btnbrwSource);
            this.selectFilesTabPage.Depth = 0;
            this.selectFilesTabPage.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFilesTabPage.Location = new System.Drawing.Point(4, 29);
            this.selectFilesTabPage.MouseState = MaterialWinforms.MouseState.HOVER;
            this.selectFilesTabPage.Name = "selectFilesTabPage";
            this.selectFilesTabPage.Size = new System.Drawing.Size(1026, 440);
            this.selectFilesTabPage.TabIndex = 0;
            this.selectFilesTabPage.Text = "Select File(s)";
            // 
            // rdbImageCompare
            // 
            this.rdbImageCompare.AutoSize = true;
            this.rdbImageCompare.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImageCompare.Location = new System.Drawing.Point(589, 82);
            this.rdbImageCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbImageCompare.Name = "rdbImageCompare";
            this.rdbImageCompare.Size = new System.Drawing.Size(136, 23);
            this.rdbImageCompare.TabIndex = 10;
            this.rdbImageCompare.Text = "Image Compare";
            this.rdbImageCompare.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(453, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 27);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Image Compare";
            // 
            // rdbTextCompare
            // 
            this.rdbTextCompare.AutoSize = true;
            this.rdbTextCompare.Checked = true;
            this.rdbTextCompare.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTextCompare.Location = new System.Drawing.Point(211, 77);
            this.rdbTextCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTextCompare.Name = "rdbTextCompare";
            this.rdbTextCompare.Size = new System.Drawing.Size(123, 23);
            this.rdbTextCompare.TabIndex = 9;
            this.rdbTextCompare.TabStop = true;
            this.rdbTextCompare.Text = "Text Compare";
            this.rdbTextCompare.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Text Compare";
            // 
            // text_OR_imageBtn
            // 
            this.text_OR_imageBtn.AutoSize = true;
            this.text_OR_imageBtn.Depth = 0;
            this.text_OR_imageBtn.EllipseBorderColor = "#3b73d1";
            this.text_OR_imageBtn.EllipseColor = "#508ef5";
            this.text_OR_imageBtn.Location = new System.Drawing.Point(372, 42);
            this.text_OR_imageBtn.MouseState = MaterialWinforms.MouseState.HOVER;
            this.text_OR_imageBtn.Name = "text_OR_imageBtn";
            this.text_OR_imageBtn.Size = new System.Drawing.Size(47, 19);
            this.text_OR_imageBtn.TabIndex = 5;
            this.text_OR_imageBtn.UseVisualStyleBackColor = true;
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.Location = new System.Drawing.Point(545, 183);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(100, 27);
            this.txtTarget.TabIndex = 4;
            this.txtTarget.Visible = false;
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(191, 183);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 27);
            this.txtSource.TabIndex = 3;
            this.txtSource.Visible = false;
            // 
            // reviewButton
            // 
            this.reviewButton.Accent = false;
            this.reviewButton.AutoSize = true;
            this.reviewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reviewButton.Capitalized = true;
            this.reviewButton.Depth = 0;
            this.reviewButton.IconImage = null;
            this.reviewButton.Location = new System.Drawing.Point(349, 252);
            this.reviewButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reviewButton.MouseState = MaterialWinforms.MouseState.HOVER;
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Primary = false;
            this.reviewButton.Selected = false;
            this.reviewButton.Size = new System.Drawing.Size(88, 36);
            this.reviewButton.TabIndex = 2;
            this.reviewButton.Text = "Review";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // btnbrwTarget
            // 
            this.btnbrwTarget.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrwTarget.Location = new System.Drawing.Point(517, 118);
            this.btnbrwTarget.Name = "btnbrwTarget";
            this.btnbrwTarget.Size = new System.Drawing.Size(149, 59);
            this.btnbrwTarget.TabIndex = 1;
            this.btnbrwTarget.Text = "Select Target File(s)";
            this.btnbrwTarget.UseVisualStyleBackColor = true;
            this.btnbrwTarget.Click += new System.EventHandler(this.btnbrwTarget_Click);
            // 
            // btnbrwSource
            // 
            this.btnbrwSource.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrwSource.Location = new System.Drawing.Point(160, 118);
            this.btnbrwSource.Name = "btnbrwSource";
            this.btnbrwSource.Size = new System.Drawing.Size(163, 59);
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
            this.reviewTabPage.Controls.Add(this.btnCompare);
            this.reviewTabPage.Depth = 0;
            this.reviewTabPage.Location = new System.Drawing.Point(4, 29);
            this.reviewTabPage.MouseState = MaterialWinforms.MouseState.HOVER;
            this.reviewTabPage.Name = "reviewTabPage";
            this.reviewTabPage.Size = new System.Drawing.Size(1026, 440);
            this.reviewTabPage.TabIndex = 1;
            this.reviewTabPage.Text = "Review";
            // 
            // reviewContentPanel
            // 
            this.reviewContentPanel.AutoScroll = true;
            this.reviewContentPanel.Depth = 0;
            this.reviewContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reviewContentPanel.Location = new System.Drawing.Point(0, 0);
            this.reviewContentPanel.MouseState = MaterialWinforms.MouseState.HOVER;
            this.reviewContentPanel.Name = "reviewContentPanel";
            this.reviewContentPanel.Size = new System.Drawing.Size(1026, 338);
            this.reviewContentPanel.TabIndex = 1;
            this.reviewContentPanel.Text = "materialPanel1";
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(33, 344);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(939, 63);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
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
            this.resultTabPage.Size = new System.Drawing.Size(1026, 440);
            this.resultTabPage.TabIndex = 2;
            this.resultTabPage.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previousResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 440);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelErrorMessage);
            this.panel2.Controls.Add(this.nextResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(976, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 440);
            this.panel2.TabIndex = 7;
            // 
            // previousResult
            // 
            this.previousResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.previousResult.Location = new System.Drawing.Point(9, 204);
            this.previousResult.Name = "previousResult";
            this.previousResult.Size = new System.Drawing.Size(38, 43);
            this.previousResult.TabIndex = 0;
            this.previousResult.Text = "<";
            this.previousResult.UseVisualStyleBackColor = true;
            this.previousResult.Click += new System.EventHandler(this.previousResult_Click);
            // 
            // nextResult
            // 
            this.nextResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nextResult.Location = new System.Drawing.Point(6, 204);
            this.nextResult.Name = "nextResult";
            this.nextResult.Size = new System.Drawing.Size(39, 43);
            this.nextResult.TabIndex = 0;
            this.nextResult.Text = ">";
            this.nextResult.UseVisualStyleBackColor = true;
            this.nextResult.Click += new System.EventHandler(this.nextResult_Click);
            // 
            // resultContentPanel
            // 
            this.resultContentPanel.AutoScroll = true;
            this.resultContentPanel.Depth = 0;
            this.resultContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultContentPanel.Location = new System.Drawing.Point(50, 0);
            this.resultContentPanel.MouseState = MaterialWinforms.MouseState.HOVER;
            this.resultContentPanel.Name = "resultContentPanel";
            this.resultContentPanel.Size = new System.Drawing.Size(926, 440);
            this.resultContentPanel.TabIndex = 8;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.Location = new System.Drawing.Point(-25, 98);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(100, 26);
            this.labelErrorMessage.TabIndex = 6;
            // 
            // comparePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1034, 508);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "comparePDF";
            this.Text = "Compare PDF";
            this.materialTabControl1.ResumeLayout(false);
            this.selectFilesTabPage.ResumeLayout(false);
            this.selectFilesTabPage.PerformLayout();
            this.reviewTabPage.ResumeLayout(false);
            this.resultTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialWinforms.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialWinforms.Controls.MaterialTabControl materialTabControl1;
        private MaterialWinforms.Controls.MaterialTabPage selectFilesTabPage;
        private System.Windows.Forms.RadioButton rdbImageCompare;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdbTextCompare;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialWinforms.Controls.MaterialToggle text_OR_imageBtn;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtSource;
        private MaterialWinforms.Controls.MaterialFlatButton reviewButton;
        private System.Windows.Forms.Button btnbrwTarget;
        private System.Windows.Forms.Button btnbrwSource;
        private MaterialWinforms.Controls.MaterialTabPage reviewTabPage;
        private MaterialWinforms.Controls.MaterialTabPage resultTabPage;
        private System.Windows.Forms.Button btnCompare;
        private MaterialWinforms.Controls.MaterialPanel reviewContentPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialWinforms.Controls.MaterialPanel resultContentPanel;
        private System.Windows.Forms.TextBox labelErrorMessage;
        private System.Windows.Forms.Button nextResult;
        private System.Windows.Forms.Button previousResult;
    }
}