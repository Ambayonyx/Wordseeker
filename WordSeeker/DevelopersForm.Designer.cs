namespace WordSeeker
{
    partial class DevelopersForm
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
            this.txtWords = new System.Windows.Forms.TextBox();
            this.fileBrowserWords = new WordSeeker.FileBrowser();
            this.fileBrowserFields = new WordSeeker.FileBrowser();
            this.btnSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWords.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords.Location = new System.Drawing.Point(12, 110);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWords.Size = new System.Drawing.Size(507, 139);
            this.txtWords.TabIndex = 1;
            // 
            // fileBrowserWords
            // 
            this.fileBrowserWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowserWords.Label = "Word file";
            this.fileBrowserWords.Location = new System.Drawing.Point(12, 12);
            this.fileBrowserWords.Name = "fileBrowserWords";
            this.fileBrowserWords.Size = new System.Drawing.Size(507, 30);
            this.fileBrowserWords.TabIndex = 0;
            this.fileBrowserWords.FileNameChanged += new System.EventHandler<WordSeeker.FileNameChangedEventArgs>(this.fileBrowser1_FileNameChanged);
            // 
            // fileBrowserFields
            // 
            this.fileBrowserFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowserFields.Label = "Field file";
            this.fileBrowserFields.Location = new System.Drawing.Point(12, 44);
            this.fileBrowserFields.Name = "fileBrowserFields";
            this.fileBrowserFields.Size = new System.Drawing.Size(507, 29);
            this.fileBrowserFields.TabIndex = 2;
            this.fileBrowserFields.FileNameChanged += new System.EventHandler<WordSeeker.FileNameChangedEventArgs>(this.fileBrowserFields_FileNameChanged);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(12, 79);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "&Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // DevelopersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.fileBrowserFields);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.fileBrowserWords);
            this.Name = "DevelopersForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileBrowser fileBrowserWords;
        private System.Windows.Forms.TextBox txtWords;
        private FileBrowser fileBrowserFields;
        private System.Windows.Forms.Button btnSolve;
    }
}

