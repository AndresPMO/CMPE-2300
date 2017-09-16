namespace Lab01_AndresMOuellette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSLoadImgButton = new System.Windows.Forms.ToolStripButton();
            this.TSImgOrTxtComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.TSRGBComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.TSGoButton = new System.Windows.Forms.ToolStripButton();
            this.TSProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLoadImgButton,
            this.TSImgOrTxtComboBox,
            this.TSRGBComboBox,
            this.TSGoButton,
            this.TSProgressBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(406, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSLoadImgButton
            // 
            this.TSLoadImgButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSLoadImgButton.Image = ((System.Drawing.Image)(resources.GetObject("TSLoadImgButton.Image")));
            this.TSLoadImgButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSLoadImgButton.Name = "TSLoadImgButton";
            this.TSLoadImgButton.Size = new System.Drawing.Size(23, 22);
            this.TSLoadImgButton.Text = "TSLoadImgButton";
            this.TSLoadImgButton.Click += new System.EventHandler(this.TSLoadImgButton_Click);
            // 
            // TSImgOrTxtComboBox
            // 
            this.TSImgOrTxtComboBox.Name = "TSImgOrTxtComboBox";
            this.TSImgOrTxtComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // TSRGBComboBox
            // 
            this.TSRGBComboBox.Name = "TSRGBComboBox";
            this.TSRGBComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // TSGoButton
            // 
            this.TSGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSGoButton.Image = ((System.Drawing.Image)(resources.GetObject("TSGoButton.Image")));
            this.TSGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSGoButton.Name = "TSGoButton";
            this.TSGoButton.Size = new System.Drawing.Size(23, 22);
            this.TSGoButton.Text = "TSGoButton";
            this.TSGoButton.Click += new System.EventHandler(this.TSGoButton_Click);
            // 
            // TSProgressBar
            // 
            this.TSProgressBar.Name = "TSProgressBar";
            this.TSProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(13, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(398, 339);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(13, 375);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(398, 97);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 484);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(439, 523);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton TSLoadImgButton;
		private System.Windows.Forms.ToolStripComboBox TSImgOrTxtComboBox;
		private System.Windows.Forms.ToolStripComboBox TSRGBComboBox;
		private System.Windows.Forms.ToolStripButton TSGoButton;
		private System.Windows.Forms.ToolStripProgressBar TSProgressBar;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

