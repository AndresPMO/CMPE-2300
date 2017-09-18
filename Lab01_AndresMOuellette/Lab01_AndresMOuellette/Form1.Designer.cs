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
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLoadImgButton,
            this.TSImgOrTxtComboBox,
            this.TSRGBComboBox,
            this.TSGoButton,
            this.TSProgressBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(581, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSLoadImgButton
            // 
            this.TSLoadImgButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSLoadImgButton.Image = ((System.Drawing.Image)(resources.GetObject("TSLoadImgButton.Image")));
            this.TSLoadImgButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSLoadImgButton.Name = "TSLoadImgButton";
            this.TSLoadImgButton.Size = new System.Drawing.Size(28, 30);
            this.TSLoadImgButton.Text = "TSLoadImgButton";
            this.TSLoadImgButton.Click += new System.EventHandler(this.TSLoadImgButton_Click);
            // 
            // TSImgOrTxtComboBox
            // 
            this.TSImgOrTxtComboBox.Items.AddRange(new object[] {
            "Decode Image",
            "Decode Text"});
            this.TSImgOrTxtComboBox.Name = "TSImgOrTxtComboBox";
            this.TSImgOrTxtComboBox.Size = new System.Drawing.Size(180, 33);
            // 
            // TSRGBComboBox
            // 
            this.TSRGBComboBox.Items.AddRange(new object[] {
            "R",
            "G",
            "B",
            "RGB"});
            this.TSRGBComboBox.Name = "TSRGBComboBox";
            this.TSRGBComboBox.Size = new System.Drawing.Size(180, 33);
            // 
            // TSGoButton
            // 
            this.TSGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSGoButton.Image = ((System.Drawing.Image)(resources.GetObject("TSGoButton.Image")));
            this.TSGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSGoButton.Name = "TSGoButton";
            this.TSGoButton.Size = new System.Drawing.Size(28, 30);
            this.TSGoButton.Text = "TSGoButton";
            this.TSGoButton.Click += new System.EventHandler(this.TSGoButton_Click);
            // 
            // TSProgressBar
            // 
            this.TSProgressBar.Name = "TSProgressBar";
            this.TSProgressBar.Size = new System.Drawing.Size(100, 30);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(20, 45);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(597, 522);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(20, 577);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(595, 147);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 745);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(648, 774);
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

