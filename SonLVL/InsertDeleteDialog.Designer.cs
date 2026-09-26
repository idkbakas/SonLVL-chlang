namespace SonicRetro.SonLVL
{
	partial class InsertDeleteDialog
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.shiftH = new System.Windows.Forms.RadioButton();
            this.shiftV = new System.Windows.Forms.RadioButton();
            this.entireRow = new System.Windows.Forms.RadioButton();
            this.entireColumn = new System.Windows.Forms.RadioButton();
            this.moveObjects = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(7, 150);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(88, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "&取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // shiftH
            // 
            this.shiftH.AutoSize = true;
            this.shiftH.Checked = true;
            this.shiftH.Location = new System.Drawing.Point(12, 11);
            this.shiftH.Name = "shiftH";
            this.shiftH.Size = new System.Drawing.Size(107, 16);
            this.shiftH.TabIndex = 2;
            this.shiftH.TabStop = true;
            this.shiftH.Text = "移动单元格(右)";
            this.shiftH.UseVisualStyleBackColor = true;
            // 
            // shiftV
            // 
            this.shiftV.AutoSize = true;
            this.shiftV.Location = new System.Drawing.Point(12, 32);
            this.shiftV.Name = "shiftV";
            this.shiftV.Size = new System.Drawing.Size(107, 16);
            this.shiftV.TabIndex = 3;
            this.shiftV.Text = "移动单元格(下)";
            this.shiftV.UseVisualStyleBackColor = true;
            // 
            // entireRow
            // 
            this.entireRow.AutoSize = true;
            this.entireRow.Location = new System.Drawing.Point(12, 67);
            this.entireRow.Name = "entireRow";
            this.entireRow.Size = new System.Drawing.Size(47, 16);
            this.entireRow.TabIndex = 4;
            this.entireRow.Text = "整行";
            this.entireRow.UseVisualStyleBackColor = true;
            // 
            // entireColumn
            // 
            this.entireColumn.AutoSize = true;
            this.entireColumn.Location = new System.Drawing.Point(12, 89);
            this.entireColumn.Name = "entireColumn";
            this.entireColumn.Size = new System.Drawing.Size(47, 16);
            this.entireColumn.TabIndex = 5;
            this.entireColumn.Text = "整列";
            this.entireColumn.UseVisualStyleBackColor = true;
            // 
            // moveObjects
            // 
            this.moveObjects.AutoSize = true;
            this.moveObjects.Checked = true;
            this.moveObjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moveObjects.Location = new System.Drawing.Point(12, 121);
            this.moveObjects.Name = "moveObjects";
            this.moveObjects.Size = new System.Drawing.Size(72, 16);
            this.moveObjects.TabIndex = 6;
            this.moveObjects.Text = "移动物体";
            this.moveObjects.UseVisualStyleBackColor = true;
            // 
            // InsertDeleteDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 182);
            this.Controls.Add(this.moveObjects);
            this.Controls.Add(this.entireColumn);
            this.Controls.Add(this.entireRow);
            this.Controls.Add(this.shiftV);
            this.Controls.Add(this.shiftH);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertDeleteDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		internal System.Windows.Forms.RadioButton shiftH;
		internal System.Windows.Forms.RadioButton shiftV;
		internal System.Windows.Forms.RadioButton entireRow;
		internal System.Windows.Forms.RadioButton entireColumn;
		internal System.Windows.Forms.CheckBox moveObjects;
	}
}

