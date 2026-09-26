namespace SonicRetro.SonLVL.GUI
{
	partial class ResizeLevelDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.levelWidth = new System.Windows.Forms.NumericUpDown();
            this.levelHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.levelWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(133, 37);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "取消(&C)";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(52, 37);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "确定(&O)";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "宽";
            // 
            // levelWidth
            // 
            this.levelWidth.Location = new System.Drawing.Point(56, 11);
            this.levelWidth.Name = "levelWidth";
            this.levelWidth.Size = new System.Drawing.Size(53, 21);
            this.levelWidth.TabIndex = 3;
            // 
            // levelHeight
            // 
            this.levelHeight.Location = new System.Drawing.Point(162, 11);
            this.levelHeight.Name = "levelHeight";
            this.levelHeight.Size = new System.Drawing.Size(53, 21);
            this.levelHeight.TabIndex = 5;
            this.levelHeight.ValueChanged += new System.EventHandler(this.levelHeight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "高";
            // 
            // ResizeLevelDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(220, 69);
            this.Controls.Add(this.levelHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levelWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeLevelDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "调整关卡大小";
            ((System.ComponentModel.ISupportInitialize)(this.levelWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.NumericUpDown levelWidth;
		internal System.Windows.Forms.NumericUpDown levelHeight;
	}
}
