namespace ColorPicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colorPreview = new System.Windows.Forms.Panel();
            this.openColorDialog = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.rDisplay = new System.Windows.Forms.TextBox();
            this.rLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.gDisplay = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.bDisplay = new System.Windows.Forms.TextBox();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexDisplay = new System.Windows.Forms.TextBox();
            this.randomColor = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.saveColor = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.rSlider = new System.Windows.Forms.TrackBar();
            this.gSlider = new System.Windows.Forms.TrackBar();
            this.bSlider = new System.Windows.Forms.TrackBar();
            this.colorPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPreview
            // 
            this.colorPreview.BackColor = System.Drawing.Color.Black;
            this.colorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPreview.Controls.Add(this.openColorDialog);
            this.colorPreview.Location = new System.Drawing.Point(24, 23);
            this.colorPreview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(572, 210);
            this.colorPreview.TabIndex = 0;
            // 
            // openColorDialog
            // 
            this.openColorDialog.BackColor = System.Drawing.Color.Transparent;
            this.openColorDialog.FlatAppearance.BorderSize = 0;
            this.openColorDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openColorDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openColorDialog.ForeColor = System.Drawing.Color.Transparent;
            this.openColorDialog.Location = new System.Drawing.Point(0, 0);
            this.openColorDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openColorDialog.Name = "openColorDialog";
            this.openColorDialog.Size = new System.Drawing.Size(574, 212);
            this.openColorDialog.TabIndex = 0;
            this.openColorDialog.UseVisualStyleBackColor = false;
            this.openColorDialog.Click += new System.EventHandler(this.openColorDialog_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // rDisplay
            // 
            this.rDisplay.Location = new System.Drawing.Point(64, 240);
            this.rDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rDisplay.Name = "rDisplay";
            this.rDisplay.Size = new System.Drawing.Size(194, 31);
            this.rDisplay.TabIndex = 1;
            this.rDisplay.Text = "0";
            this.rDisplay.TextChanged += new System.EventHandler(this.rDisplay_TextChanged);
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(18, 246);
            this.rLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(33, 25);
            this.rLabel.TabIndex = 2;
            this.rLabel.Text = "R:";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(18, 296);
            this.gLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(34, 25);
            this.gLabel.TabIndex = 4;
            this.gLabel.Text = "G:";
            // 
            // gDisplay
            // 
            this.gDisplay.Location = new System.Drawing.Point(64, 290);
            this.gDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gDisplay.Name = "gDisplay";
            this.gDisplay.Size = new System.Drawing.Size(194, 31);
            this.gDisplay.TabIndex = 3;
            this.gDisplay.Text = "0";
            this.gDisplay.TextChanged += new System.EventHandler(this.gDisplay_TextChanged);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(18, 346);
            this.bLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(32, 25);
            this.bLabel.TabIndex = 6;
            this.bLabel.Text = "B:";
            // 
            // bDisplay
            // 
            this.bDisplay.Location = new System.Drawing.Point(64, 340);
            this.bDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bDisplay.Name = "bDisplay";
            this.bDisplay.Size = new System.Drawing.Size(194, 31);
            this.bDisplay.TabIndex = 5;
            this.bDisplay.Text = "0";
            this.bDisplay.TextChanged += new System.EventHandler(this.bDisplay_TextChanged);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(332, 246);
            this.hexLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(56, 25);
            this.hexLabel.TabIndex = 8;
            this.hexLabel.Text = "Hex:";
            // 
            // hexDisplay
            // 
            this.hexDisplay.Location = new System.Drawing.Point(400, 240);
            this.hexDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hexDisplay.Name = "hexDisplay";
            this.hexDisplay.Size = new System.Drawing.Size(194, 31);
            this.hexDisplay.TabIndex = 7;
            this.hexDisplay.Text = "#";
            this.hexDisplay.TextChanged += new System.EventHandler(this.hexDisplay_TextChanged);
            // 
            // randomColor
            // 
            this.randomColor.Location = new System.Drawing.Point(400, 287);
            this.randomColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.randomColor.Name = "randomColor";
            this.randomColor.Size = new System.Drawing.Size(198, 44);
            this.randomColor.TabIndex = 11;
            this.randomColor.Text = "Random Color";
            this.randomColor.UseVisualStyleBackColor = true;
            this.randomColor.Click += new System.EventHandler(this.randomColor_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(400, 337);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(198, 44);
            this.aboutButton.TabIndex = 12;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // saveColor
            // 
            this.saveColor.BackgroundImage = global::ColorPicker.Properties.Resources.floppy_disk;
            this.saveColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveColor.Location = new System.Drawing.Point(296, 327);
            this.saveColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveColor.Name = "saveColor";
            this.saveColor.Size = new System.Drawing.Size(64, 62);
            this.saveColor.TabIndex = 13;
            this.toolTip.SetToolTip(this.saveColor, "Save current color to file");
            this.saveColor.UseVisualStyleBackColor = true;
            this.saveColor.Click += new System.EventHandler(this.saveColor_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(614, 23);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(344, 50);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Press F1 to select the color where \r\nyour cursor is pointed.";
            // 
            // rSlider
            // 
            this.rSlider.Location = new System.Drawing.Point(620, 106);
            this.rSlider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rSlider.Maximum = 255;
            this.rSlider.Name = "rSlider";
            this.rSlider.Size = new System.Drawing.Size(314, 90);
            this.rSlider.TabIndex = 15;
            this.rSlider.TabStop = false;
            this.rSlider.Scroll += new System.EventHandler(this.rSlider_Scroll);
            // 
            // gSlider
            // 
            this.gSlider.Location = new System.Drawing.Point(620, 198);
            this.gSlider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gSlider.Maximum = 255;
            this.gSlider.Name = "gSlider";
            this.gSlider.Size = new System.Drawing.Size(314, 90);
            this.gSlider.TabIndex = 16;
            this.gSlider.TabStop = false;
            this.gSlider.Scroll += new System.EventHandler(this.gSlider_Scroll);
            // 
            // bSlider
            // 
            this.bSlider.Location = new System.Drawing.Point(620, 290);
            this.bSlider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bSlider.Maximum = 255;
            this.bSlider.Name = "bSlider";
            this.bSlider.Size = new System.Drawing.Size(314, 90);
            this.bSlider.TabIndex = 17;
            this.bSlider.TabStop = false;
            this.bSlider.Scroll += new System.EventHandler(this.bSlider_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 394);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.saveColor);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.randomColor);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.hexDisplay);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.bDisplay);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.gDisplay);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.rDisplay);
            this.Controls.Add(this.colorPreview);
            this.Controls.Add(this.bSlider);
            this.Controls.Add(this.gSlider);
            this.Controls.Add(this.rSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Tool";
            this.colorPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorPreview;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox rDisplay;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.TextBox gDisplay;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox bDisplay;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.TextBox hexDisplay;
        private System.Windows.Forms.Button randomColor;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button openColorDialog;
        private System.Windows.Forms.Button saveColor;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TrackBar rSlider;
        private System.Windows.Forms.TrackBar gSlider;
        private System.Windows.Forms.TrackBar bSlider;
    }
}

