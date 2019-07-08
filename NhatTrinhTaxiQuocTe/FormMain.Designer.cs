namespace NhatTrinhTaxiQuocTe
{
    partial class FormMain
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtEndLineOfFile = new System.Windows.Forms.TextBox();
            this.lblEndLine = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleName = "";
            this.btnBrowse.Location = new System.Drawing.Point(295, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(72, 30);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(217, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 33);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "File Name";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(295, 57);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 43);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "Auto Copy Patse";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 106);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(355, 23);
            this.progressBar.TabIndex = 4;
            // 
            // txtEndLineOfFile
            // 
            this.txtEndLineOfFile.Location = new System.Drawing.Point(72, 69);
            this.txtEndLineOfFile.Name = "txtEndLineOfFile";
            this.txtEndLineOfFile.Size = new System.Drawing.Size(217, 20);
            this.txtEndLineOfFile.TabIndex = 5;
            // 
            // lblEndLine
            // 
            this.lblEndLine.AutoSize = true;
            this.lblEndLine.Location = new System.Drawing.Point(12, 65);
            this.lblEndLine.Name = "lblEndLine";
            this.lblEndLine.Size = new System.Drawing.Size(53, 26);
            this.lblEndLine.TabIndex = 6;
            this.lblEndLine.Text = "Line END\r\nof file";
            this.lblEndLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadeBy.Location = new System.Drawing.Point(161, 147);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(55, 13);
            this.lblMadeBy.TabIndex = 7;
            this.lblMadeBy.Text = "Made by";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(141, 164);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(95, 15);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Huỳnh Tấn Thịnh";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 188);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.lblEndLine);
            this.Controls.Add(this.txtEndLineOfFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnBrowse);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "AUTO COPY PATSE EXCEL TAXI QT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtEndLineOfFile;
        private System.Windows.Forms.Label lblEndLine;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.Label lblAuthor;

    }
}

