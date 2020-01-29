namespace SplitterDocument
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFileName1 = new System.Windows.Forms.TextBox();
            this.tbFileName2 = new System.Windows.Forms.TextBox();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.tbFileName3 = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnOpenFile3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл_1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файл_2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMerge);
            this.groupBox1.Controls.Add(this.btnOpenFile2);
            this.groupBox1.Controls.Add(this.btnOpenFile1);
            this.groupBox1.Controls.Add(this.tbFileName2);
            this.groupBox1.Controls.Add(this.tbFileName1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Соединить файлы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenFile3);
            this.groupBox2.Controls.Add(this.btnSplit);
            this.groupBox2.Controls.Add(this.tbFileName3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(25, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Разбить файл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Файл:";
            // 
            // tbFileName1
            // 
            this.tbFileName1.Location = new System.Drawing.Point(127, 30);
            this.tbFileName1.Name = "tbFileName1";
            this.tbFileName1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFileName1.Size = new System.Drawing.Size(286, 20);
            this.tbFileName1.TabIndex = 3;
            // 
            // tbFileName2
            // 
            this.tbFileName2.Location = new System.Drawing.Point(127, 63);
            this.tbFileName2.Name = "tbFileName2";
            this.tbFileName2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFileName2.Size = new System.Drawing.Size(286, 20);
            this.tbFileName2.TabIndex = 4;
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Location = new System.Drawing.Point(419, 28);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(34, 23);
            this.btnOpenFile1.TabIndex = 6;
            this.btnOpenFile1.Text = "...";
            this.btnOpenFile1.UseVisualStyleBackColor = true;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click);
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Location = new System.Drawing.Point(419, 63);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(34, 23);
            this.btnOpenFile2.TabIndex = 7;
            this.btnOpenFile2.Text = "...";
            this.btnOpenFile2.UseVisualStyleBackColor = true;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // tbFileName3
            // 
            this.tbFileName3.Location = new System.Drawing.Point(127, 26);
            this.tbFileName3.Name = "tbFileName3";
            this.tbFileName3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFileName3.Size = new System.Drawing.Size(286, 20);
            this.tbFileName3.TabIndex = 6;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(379, 104);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(74, 23);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "Соединить";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(379, 72);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(74, 23);
            this.btnSplit.TabIndex = 10;
            this.btnSplit.Text = "Разбить";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnOpenFile3
            // 
            this.btnOpenFile3.Location = new System.Drawing.Point(419, 25);
            this.btnOpenFile3.Name = "btnOpenFile3";
            this.btnOpenFile3.Size = new System.Drawing.Size(34, 23);
            this.btnOpenFile3.TabIndex = 10;
            this.btnOpenFile3.Text = "...";
            this.btnOpenFile3.UseVisualStyleBackColor = true;
            this.btnOpenFile3.Click += new System.EventHandler(this.btnOpenFile3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с файлами";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.TextBox tbFileName2;
        private System.Windows.Forms.TextBox tbFileName1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpenFile3;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox tbFileName3;
        private System.Windows.Forms.Label label6;
    }
}