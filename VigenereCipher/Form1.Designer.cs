namespace VigenereCipher
{
    partial class Form1
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EncodeBtn = new System.Windows.Forms.Button();
            this.DecodeBtn = new System.Windows.Forms.Button();
            this.lcm = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.msgLengthLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keywordList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cipherFormat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InputBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(0, 0);
            this.InputBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputBox.Size = new System.Drawing.Size(670, 600);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.CalculateStats);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(678, 0);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(664, 600);
            this.OutputBox.TabIndex = 7;
            // 
            // LoadFileBtn
            // 
            this.LoadFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFileBtn.Location = new System.Drawing.Point(983, 792);
            this.LoadFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadFileBtn.Name = "LoadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(119, 50);
            this.LoadFileBtn.TabIndex = 5;
            this.LoadFileBtn.Text = "Load File";
            this.LoadFileBtn.UseVisualStyleBackColor = true;
            this.LoadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileBtn.Location = new System.Drawing.Point(983, 849);
            this.SaveFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(119, 50);
            this.SaveFileBtn.TabIndex = 6;
            this.SaveFileBtn.Text = "Save File";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "test message.txt";
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EncodeBtn.Location = new System.Drawing.Point(856, 792);
            this.EncodeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(119, 50);
            this.EncodeBtn.TabIndex = 3;
            this.EncodeBtn.Text = "Encode";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DecodeBtn.Location = new System.Drawing.Point(856, 849);
            this.DecodeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.Size = new System.Drawing.Size(119, 50);
            this.DecodeBtn.TabIndex = 4;
            this.DecodeBtn.Text = "Decode";
            this.DecodeBtn.UseVisualStyleBackColor = true;
            this.DecodeBtn.Click += new System.EventHandler(this.DecodeBtn_Click);
            // 
            // lcm
            // 
            this.lcm.AutoSize = true;
            this.lcm.Location = new System.Drawing.Point(262, 31);
            this.lcm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lcm.Name = "lcm";
            this.lcm.Size = new System.Drawing.Size(23, 25);
            this.lcm.TabIndex = 10;
            this.lcm.Text = "1";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(9, 59);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 33);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // msgLengthLbl
            // 
            this.msgLengthLbl.AutoSize = true;
            this.msgLengthLbl.Location = new System.Drawing.Point(262, 68);
            this.msgLengthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgLengthLbl.Name = "msgLengthLbl";
            this.msgLengthLbl.Size = new System.Drawing.Size(23, 25);
            this.msgLengthLbl.TabIndex = 12;
            this.msgLengthLbl.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cipher Strength:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.InputBox);
            this.panel1.Controls.Add(this.OutputBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 604);
            this.panel1.TabIndex = 14;
            // 
            // keywordList
            // 
            this.keywordList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.keywordList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordList.BackColor = System.Drawing.SystemColors.Window;
            this.keywordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.keywordList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keywordList.GridLines = true;
            this.keywordList.HideSelection = false;
            this.keywordList.LabelEdit = true;
            this.keywordList.Location = new System.Drawing.Point(0, 613);
            this.keywordList.Margin = new System.Windows.Forms.Padding(4);
            this.keywordList.Name = "keywordList";
            this.keywordList.Size = new System.Drawing.Size(670, 399);
            this.keywordList.TabIndex = 14;
            this.keywordList.UseCompatibleStateImageBehavior = false;
            this.keywordList.View = System.Windows.Forms.View.Details;
            this.keywordList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.keywordList_AfterLabelEdit);
            this.keywordList.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.keywordList_BeforeLabelEdit);
            this.keywordList.ItemActivate += new System.EventHandler(this.keywordList_ItemActivate);
            this.keywordList.SelectedIndexChanged += new System.EventHandler(this.keywordList_SelectedIndexChanged);
            this.keywordList.Leave += new System.EventHandler(this.keywordList_SelectedIndexChanged);
            this.keywordList.Validating += new System.ComponentModel.CancelEventHandler(this.keywordList_Validating);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Keyword";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Length";
            this.columnHeader2.Width = 100;
            // 
            // cipherFormat
            // 
            this.cipherFormat.AutoSize = true;
            this.cipherFormat.Location = new System.Drawing.Point(62, 96);
            this.cipherFormat.Margin = new System.Windows.Forms.Padding(6);
            this.cipherFormat.Name = "cipherFormat";
            this.cipherFormat.Size = new System.Drawing.Size(193, 29);
            this.cipherFormat.TabIndex = 15;
            this.cipherFormat.Text = "Ciphertext Format";
            this.cipherFormat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.cipherFormat);
            this.groupBox1.Controls.Add(this.lcm);
            this.groupBox1.Controls.Add(this.msgLengthLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(816, 641);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(301, 142);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 1036);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.keywordList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.LoadFileBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1355, 1054);
            this.Name = "Form1";
            this.Text = "Vigenere Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;       
        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button EncodeBtn;
        private System.Windows.Forms.Button DecodeBtn;
        private System.Windows.Forms.Label lcm;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label msgLengthLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView keywordList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox cipherFormat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

