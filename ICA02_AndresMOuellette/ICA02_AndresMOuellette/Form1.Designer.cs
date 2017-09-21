namespace ICA02_AndresMOuellette
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
            this.components = new System.ComponentModel.Container();
            this.OpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.XSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.YSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.XSpeedLabel = new System.Windows.Forms.Label();
            this.YSpeedLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XSpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YSpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OpacityTrackBar
            // 
            this.OpacityTrackBar.Location = new System.Drawing.Point(146, 20);
            this.OpacityTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpacityTrackBar.Maximum = 255;
            this.OpacityTrackBar.Name = "OpacityTrackBar";
            this.OpacityTrackBar.Size = new System.Drawing.Size(544, 69);
            this.OpacityTrackBar.TabIndex = 0;
            this.OpacityTrackBar.TickFrequency = 15;
            this.OpacityTrackBar.Value = 255;
            this.OpacityTrackBar.Scroll += new System.EventHandler(this.OpacityTrackBar_Scroll);
            // 
            // XSpeedTrackBar
            // 
            this.XSpeedTrackBar.Location = new System.Drawing.Point(146, 100);
            this.XSpeedTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.XSpeedTrackBar.Maximum = 15;
            this.XSpeedTrackBar.Minimum = -15;
            this.XSpeedTrackBar.Name = "XSpeedTrackBar";
            this.XSpeedTrackBar.Size = new System.Drawing.Size(544, 69);
            this.XSpeedTrackBar.TabIndex = 1;
            this.XSpeedTrackBar.Scroll += new System.EventHandler(this.XSpeedTrackBar_Scroll);
            // 
            // YSpeedTrackBar
            // 
            this.YSpeedTrackBar.Location = new System.Drawing.Point(146, 180);
            this.YSpeedTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YSpeedTrackBar.Maximum = 15;
            this.YSpeedTrackBar.Minimum = -15;
            this.YSpeedTrackBar.Name = "YSpeedTrackBar";
            this.YSpeedTrackBar.Size = new System.Drawing.Size(544, 69);
            this.YSpeedTrackBar.TabIndex = 2;
            this.YSpeedTrackBar.Scroll += new System.EventHandler(this.YSpeedTrackBar_Scroll);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(294, 258);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(52, 24);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "All";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "X Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y Speed:";
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.AutoSize = true;
            this.OpacityLabel.Location = new System.Drawing.Point(99, 20);
            this.OpacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(36, 20);
            this.OpacityLabel.TabIndex = 7;
            this.OpacityLabel.Text = "255";
            // 
            // XSpeedLabel
            // 
            this.XSpeedLabel.AutoSize = true;
            this.XSpeedLabel.Location = new System.Drawing.Point(111, 100);
            this.XSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XSpeedLabel.Name = "XSpeedLabel";
            this.XSpeedLabel.Size = new System.Drawing.Size(18, 20);
            this.XSpeedLabel.TabIndex = 8;
            this.XSpeedLabel.Text = "0";
            // 
            // YSpeedLabel
            // 
            this.YSpeedLabel.AutoSize = true;
            this.YSpeedLabel.Location = new System.Drawing.Point(106, 180);
            this.YSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YSpeedLabel.Name = "YSpeedLabel";
            this.YSpeedLabel.Size = new System.Drawing.Size(18, 20);
            this.YSpeedLabel.TabIndex = 9;
            this.YSpeedLabel.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 297);
            this.Controls.Add(this.YSpeedLabel);
            this.Controls.Add(this.XSpeedLabel);
            this.Controls.Add(this.OpacityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.YSpeedTrackBar);
            this.Controls.Add(this.XSpeedTrackBar);
            this.Controls.Add(this.OpacityTrackBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OpacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XSpeedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YSpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar OpacityTrackBar;
        private System.Windows.Forms.TrackBar XSpeedTrackBar;
        private System.Windows.Forms.TrackBar YSpeedTrackBar;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.Label XSpeedLabel;
        private System.Windows.Forms.Label YSpeedLabel;
        private System.Windows.Forms.Timer timer;
    }
}

