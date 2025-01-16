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
            this.dlgSource = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.targetRangeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.txtComparingPagesNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbImageCompare = new System.Windows.Forms.RadioButton();
            this.rdbTextCompare = new System.Windows.Forms.RadioButton();
            this.btnbrwTarget = new System.Windows.Forms.Button();
            this.btnbrwSource = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webResult = new System.Windows.Forms.WebBrowser();
            this.dlgTarget = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgSource
            // 
            this.dlgSource.FileName = "dlgSource";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.targetRangeTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelErrorMessage);
            this.panel1.Controls.Add(this.txtComparingPagesNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdbImageCompare);
            this.panel1.Controls.Add(this.rdbTextCompare);
            this.panel1.Controls.Add(this.btnbrwTarget);
            this.panel1.Controls.Add(this.btnbrwSource);
            this.panel1.Controls.Add(this.btnCompare);
            this.panel1.Controls.Add(this.txtTarget);
            this.panel1.Controls.Add(this.txtSource);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 177);
            this.panel1.TabIndex = 0;
            // 
            // targetRangeTextBox
            // 
            this.targetRangeTextBox.Location = new System.Drawing.Point(655, 98);
            this.targetRangeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetRangeTextBox.Name = "targetRangeTextBox";
            this.targetRangeTextBox.Size = new System.Drawing.Size(120, 26);
            this.targetRangeTextBox.TabIndex = 13;
            this.targetRangeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.targetRangeTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Target Range";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(1050, 75);
            this.labelErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.labelErrorMessage.TabIndex = 11;
            this.labelErrorMessage.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelErrorMessage.Visible = false;
            // 
            // txtComparingPagesNumber
            // 
            this.txtComparingPagesNumber.Location = new System.Drawing.Point(277, 95);
            this.txtComparingPagesNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComparingPagesNumber.Name = "txtComparingPagesNumber";
            this.txtComparingPagesNumber.Size = new System.Drawing.Size(118, 26);
            this.txtComparingPagesNumber.TabIndex = 10;
            this.txtComparingPagesNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComparingPagesNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Source Range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // rdbImageCompare
            // 
            this.rdbImageCompare.AutoSize = true;
            this.rdbImageCompare.Location = new System.Drawing.Point(655, 148);
            this.rdbImageCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbImageCompare.Name = "rdbImageCompare";
            this.rdbImageCompare.Size = new System.Drawing.Size(148, 24);
            this.rdbImageCompare.TabIndex = 8;
            this.rdbImageCompare.Text = "Image Compare";
            this.rdbImageCompare.UseVisualStyleBackColor = true;
            this.rdbImageCompare.CheckedChanged += new System.EventHandler(this.rdbImageCompare_CheckedChanged);
            // 
            // rdbTextCompare
            // 
            this.rdbTextCompare.AutoSize = true;
            this.rdbTextCompare.Checked = true;
            this.rdbTextCompare.Location = new System.Drawing.Point(277, 143);
            this.rdbTextCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTextCompare.Name = "rdbTextCompare";
            this.rdbTextCompare.Size = new System.Drawing.Size(133, 24);
            this.rdbTextCompare.TabIndex = 7;
            this.rdbTextCompare.TabStop = true;
            this.rdbTextCompare.Text = "Text Compare";
            this.rdbTextCompare.UseVisualStyleBackColor = true;
            this.rdbTextCompare.CheckedChanged += new System.EventHandler(this.rdbTextCompare_CheckedChanged);
            // 
            // btnbrwTarget
            // 
            this.btnbrwTarget.Location = new System.Drawing.Point(807, 45);
            this.btnbrwTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbrwTarget.Name = "btnbrwTarget";
            this.btnbrwTarget.Size = new System.Drawing.Size(180, 35);
            this.btnbrwTarget.TabIndex = 6;
            this.btnbrwTarget.Text = "Browse &Target";
            this.btnbrwTarget.UseVisualStyleBackColor = true;
            this.btnbrwTarget.Click += new System.EventHandler(this.btnbrwTarget_Click);
            // 
            // btnbrwSource
            // 
            this.btnbrwSource.Location = new System.Drawing.Point(807, 5);
            this.btnbrwSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbrwSource.Name = "btnbrwSource";
            this.btnbrwSource.Size = new System.Drawing.Size(180, 35);
            this.btnbrwSource.TabIndex = 5;
            this.btnbrwSource.Text = "Browse &Source";
            this.btnbrwSource.UseVisualStyleBackColor = true;
            this.btnbrwSource.Click += new System.EventHandler(this.btnbrwSource_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(807, 95);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(180, 35);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Co&mpare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(277, 48);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(498, 26);
            this.txtTarget.TabIndex = 3;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(277, 6);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(498, 26);
            this.txtSource.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target File (pdf)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File (pdf)";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.webResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 301);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 301);
            this.dataGridView1.TabIndex = 3;
            // 
            // webResult
            // 
            this.webResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webResult.Location = new System.Drawing.Point(0, 0);
            this.webResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webResult.MinimumSize = new System.Drawing.Size(30, 31);
            this.webResult.Name = "webResult";
            this.webResult.Size = new System.Drawing.Size(1257, 301);
            this.webResult.TabIndex = 0;
            // 
            // dlgTarget
            // 
            this.dlgTarget.FileName = "dlgTarget";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 408);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1257, 70);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDFCompare.Properties.Resources.NIITLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // comparePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1257, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "comparePDF";
            this.Text = "Compare PDF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webResult;
        private System.Windows.Forms.OpenFileDialog dlgTarget;
        private System.Windows.Forms.Button btnbrwTarget;
        private System.Windows.Forms.Button btnbrwSource;
        private System.Windows.Forms.RadioButton rdbImageCompare;
        private System.Windows.Forms.RadioButton rdbTextCompare;
        private System.Windows.Forms.TextBox txtComparingPagesNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErrorMessage;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox targetRangeTextBox;
        private System.Windows.Forms.Label label5;
    }
}