namespace SonicRetro.SonLVL
{
	partial class BackgroundColorDialog
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
            this.useLevelColor = new System.Windows.Forms.RadioButton();
            this.useCustomColor = new System.Windows.Forms.RadioButton();
            this.palettePanel = new System.Windows.Forms.Panel();
            this.indexLabel = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customColorBox = new System.Windows.Forms.PictureBox();
            this.colorChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customColorOverlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customColorOverlay)).BeginInit();
            this.SuspendLayout();
            // 
            // useLevelColor
            // 
            this.useLevelColor.AutoSize = true;
            this.useLevelColor.Location = new System.Drawing.Point(14, 14);
            this.useLevelColor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.useLevelColor.Name = "useLevelColor";
            this.useLevelColor.Size = new System.Drawing.Size(95, 16);
            this.useLevelColor.TabIndex = 3;
            this.useLevelColor.Text = "使用关卡颜色";
            this.useLevelColor.UseVisualStyleBackColor = true;
            this.useLevelColor.CheckedChanged += new System.EventHandler(this.useLevelColor_CheckedChanged);
            // 
            // useCustomColor
            // 
            this.useCustomColor.AutoSize = true;
            this.useCustomColor.Location = new System.Drawing.Point(14, 116);
            this.useCustomColor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.useCustomColor.Name = "useCustomColor";
            this.useCustomColor.Size = new System.Drawing.Size(107, 16);
            this.useCustomColor.TabIndex = 4;
            this.useCustomColor.Text = "使用自定义颜色";
            this.useCustomColor.UseVisualStyleBackColor = true;
            this.useCustomColor.CheckedChanged += new System.EventHandler(this.useCustomColor_CheckedChanged);
            // 
            // palettePanel
            // 
            this.palettePanel.Location = new System.Drawing.Point(14, 41);
            this.palettePanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.palettePanel.Name = "palettePanel";
            this.palettePanel.Size = new System.Drawing.Size(256, 59);
            this.palettePanel.TabIndex = 5;
            this.palettePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.palettePanel_Paint);
            this.palettePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.palettePanel_MouseDown);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(162, 14);
            this.indexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(23, 12);
            this.indexLabel.TabIndex = 6;
            this.indexLabel.Text = "值:";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(198, 13);
            this.index.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.index.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(60, 21);
            this.index.TabIndex = 7;
            this.index.ValueChanged += new System.EventHandler(this.index_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(102, 167);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(82, 22);
            this.okButton.TabIndex = 20;
            this.okButton.Text = "确定(&O)";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(186, 167);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 22);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "取消(&C)";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // customColorBox
            // 
            this.customColorBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.customColorBox.Location = new System.Drawing.Point(14, 133);
            this.customColorBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customColorBox.Name = "customColorBox";
            this.customColorBox.Size = new System.Drawing.Size(170, 17);
            this.customColorBox.TabIndex = 10;
            this.customColorBox.TabStop = false;
            this.customColorBox.Click += new System.EventHandler(this.customColor_Click);
            // 
            // colorChange
            // 
            this.colorChange.AutoSize = true;
            this.colorChange.Location = new System.Drawing.Point(194, 131);
            this.colorChange.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.colorChange.Name = "colorChange";
            this.colorChange.Size = new System.Drawing.Size(74, 22);
            this.colorChange.TabIndex = 11;
            this.colorChange.Text = "更改(&C)";
            this.colorChange.UseVisualStyleBackColor = true;
            this.colorChange.Click += new System.EventHandler(this.customColor_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 1);
            this.label1.TabIndex = 12;
            // 
            // customColorOverlay
            // 
            this.customColorOverlay.BackColor = System.Drawing.Color.Gray;
            this.customColorOverlay.Location = new System.Drawing.Point(14, 133);
            this.customColorOverlay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customColorOverlay.Name = "customColorOverlay";
            this.customColorOverlay.Size = new System.Drawing.Size(170, 17);
            this.customColorOverlay.TabIndex = 13;
            this.customColorOverlay.TabStop = false;
            this.customColorOverlay.Visible = false;
            // 
            // BackgroundColorDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(283, 192);
            this.Controls.Add(this.customColorOverlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorChange);
            this.Controls.Add(this.customColorBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.index);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.palettePanel);
            this.Controls.Add(this.useCustomColor);
            this.Controls.Add(this.useLevelColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackgroundColorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "背景颜色";
            ((System.ComponentModel.ISupportInitialize)(this.index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customColorOverlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.RadioButton useLevelColor;
		internal System.Windows.Forms.RadioButton useCustomColor;
		private System.Windows.Forms.Panel palettePanel;
		private System.Windows.Forms.Label indexLabel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		internal System.Windows.Forms.NumericUpDown index;
		internal System.Windows.Forms.PictureBox customColorBox;
		private System.Windows.Forms.Button colorChange;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.PictureBox customColorOverlay;
	}
}