namespace SonicRetro.SonLVL
{
	partial class ReplaceChunksDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileList1 = new SonicRetro.SonLVL.API.TileList();
            this.findChunk = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tileList2 = new SonicRetro.SonLVL.API.TileList();
            this.replaceChunk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findChunk)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceChunk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tileList1);
            this.panel1.Controls.Add(this.findChunk);
            this.panel1.Location = new System.Drawing.Point(48, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 270);
            this.panel1.TabIndex = 13;
            // 
            // tileList1
            // 
            this.tileList1.BackColor = System.Drawing.SystemColors.Window;
            this.tileList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileList1.Location = new System.Drawing.Point(0, 0);
            this.tileList1.Name = "tileList1";
            this.tileList1.ScrollValue = 0;
            this.tileList1.SelectedIndex = -1;
            this.tileList1.Size = new System.Drawing.Size(293, 249);
            this.tileList1.TabIndex = 6;
            this.tileList1.SelectedIndexChanged += new System.EventHandler(this.tileList1_SelectedIndexChanged);
            // 
            // findChunk
            // 
            this.findChunk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.findChunk.Hexadecimal = true;
            this.findChunk.Location = new System.Drawing.Point(0, 249);
            this.findChunk.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.findChunk.Name = "findChunk";
            this.findChunk.Size = new System.Drawing.Size(293, 21);
            this.findChunk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "查找:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(617, 296);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "取消(&C)";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(536, 296);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "确定(&O)";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tileList2);
            this.panel2.Controls.Add(this.replaceChunk);
            this.panel2.Location = new System.Drawing.Point(399, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 270);
            this.panel2.TabIndex = 15;
            // 
            // tileList2
            // 
            this.tileList2.BackColor = System.Drawing.SystemColors.Window;
            this.tileList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileList2.Location = new System.Drawing.Point(0, 0);
            this.tileList2.Name = "tileList2";
            this.tileList2.ScrollValue = 0;
            this.tileList2.SelectedIndex = -1;
            this.tileList2.Size = new System.Drawing.Size(293, 249);
            this.tileList2.TabIndex = 6;
            this.tileList2.SelectedIndexChanged += new System.EventHandler(this.tileList2_SelectedIndexChanged);
            // 
            // replaceChunk
            // 
            this.replaceChunk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.replaceChunk.Hexadecimal = true;
            this.replaceChunk.Location = new System.Drawing.Point(0, 249);
            this.replaceChunk.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.replaceChunk.Name = "replaceChunk";
            this.replaceChunk.Size = new System.Drawing.Size(293, 21);
            this.replaceChunk.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "替换:";
            // 
            // ReplaceChunksDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(704, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceChunksDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "替换区块";
            this.VisibleChanged += new System.EventHandler(this.ReplaceChunksDialog_VisibleChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.findChunk)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.replaceChunk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		internal System.Windows.Forms.NumericUpDown findChunk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private API.TileList tileList1;
		private System.Windows.Forms.Panel panel2;
		private API.TileList tileList2;
		internal System.Windows.Forms.NumericUpDown replaceChunk;
		private System.Windows.Forms.Label label2;

	}
}

