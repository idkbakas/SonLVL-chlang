namespace SonicRetro.SonLVL.GUI
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
            System.Windows.Forms.Button button1;
            this.label1 = new System.Windows.Forms.Label();
            cancelButton = new System.Windows.Forms.Button();
            reportButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            button1.Location = new System.Drawing.Point(35, 210);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 21);
            button1.TabIndex = 3;
            button1.Text = "指南&(G)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.Text = "SonLVL尝试加载你的关卡时遇到了错误\r\n\r\n如果你不知道你在干啥，点击\'指南\'\r\n如果你坚信这是SonLVL的问题，点击\'报告\'\r\n如果这是你搞的错误或者其他" +
    "玩意，点击\'取消\'\r\n错误报告：";
            // 
            // LoadErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(button1);
            this.Controls.Add(reportButton);
            this.Controls.Add(cancelButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadErrorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "错误:加载关卡";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}