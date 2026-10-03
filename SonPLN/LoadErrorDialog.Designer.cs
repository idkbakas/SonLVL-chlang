namespace SonicRetro.SonLVL.SonPLN
{
    partial class LoadErrorDialog
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
            System.Windows.Forms.Button cancelButton;
            System.Windows.Forms.Button reportButton;
            this.label1 = new System.Windows.Forms.Label();
            cancelButton = new System.Windows.Forms.Button();
            reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(197, 210);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 21);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "取消(&C)";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reportButton
            // 
            reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            reportButton.Location = new System.Drawing.Point(116, 210);
            reportButton.Name = "reportButton";
            reportButton.Size = new System.Drawing.Size(75, 21);
            reportButton.TabIndex = 2;
            reportButton.Text = "报告(&R)";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 198);
            this.label1.TabIndex = 0;
            this.label1.Text = "我是说你的SonPLN加载时出错了\r\n如果你坚信这是一个bug，给我点报告来\r\n如果这是你自己造成的或者其他东西点取消\r\n错误报告如下:\r\n";
            // 
            // LoadErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(reportButton);
            this.Controls.Add(cancelButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadErrorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "加载错误";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}