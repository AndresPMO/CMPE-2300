namespace ICA06_AndresMOuellette
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
            this.addButton = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.colourRB = new System.Windows.Forms.RadioButton();
            this.distanceRB = new System.Windows.Forms.RadioButton();
            this.radiusRB = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.sortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(13, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(197, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Exclusive Balls : -50px";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortGroupBox.Controls.Add(this.colourRB);
            this.sortGroupBox.Controls.Add(this.distanceRB);
            this.sortGroupBox.Controls.Add(this.radiusRB);
            this.sortGroupBox.Location = new System.Drawing.Point(13, 52);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(197, 54);
            this.sortGroupBox.TabIndex = 1;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort Type";
            // 
            // colourRB
            // 
            this.colourRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colourRB.AutoSize = true;
            this.colourRB.Location = new System.Drawing.Point(136, 20);
            this.colourRB.Name = "colourRB";
            this.colourRB.Size = new System.Drawing.Size(55, 17);
            this.colourRB.TabIndex = 2;
            this.colourRB.TabStop = true;
            this.colourRB.Text = "Colour";
            this.colourRB.UseVisualStyleBackColor = true;
            this.colourRB.Click += new System.EventHandler(this.radiusRB_Click);
            // 
            // distanceRB
            // 
            this.distanceRB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.distanceRB.AutoSize = true;
            this.distanceRB.Location = new System.Drawing.Point(65, 20);
            this.distanceRB.Name = "distanceRB";
            this.distanceRB.Size = new System.Drawing.Size(67, 17);
            this.distanceRB.TabIndex = 1;
            this.distanceRB.TabStop = true;
            this.distanceRB.Text = "Distance";
            this.distanceRB.UseVisualStyleBackColor = true;
            this.distanceRB.Click += new System.EventHandler(this.radiusRB_Click);
            // 
            // radiusRB
            // 
            this.radiusRB.AutoSize = true;
            this.radiusRB.Location = new System.Drawing.Point(7, 20);
            this.radiusRB.Name = "radiusRB";
            this.radiusRB.Size = new System.Drawing.Size(58, 17);
            this.radiusRB.TabIndex = 0;
            this.radiusRB.TabStop = true;
            this.radiusRB.Text = "Radius";
            this.radiusRB.UseVisualStyleBackColor = true;
            this.radiusRB.Click += new System.EventHandler(this.radiusRB_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 119);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(197, 41);
            this.progressBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 172);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.addButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.RadioButton colourRB;
        private System.Windows.Forms.RadioButton distanceRB;
        private System.Windows.Forms.RadioButton radiusRB;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

