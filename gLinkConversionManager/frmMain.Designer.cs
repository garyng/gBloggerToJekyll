namespace gLinkConversionManager
{
	partial class frmMain
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
			this.lbLog = new System.Windows.Forms.ListBox();
			this.lblDes = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbLog
			// 
			this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbLog.FormattingEnabled = true;
			this.lbLog.HorizontalScrollbar = true;
			this.lbLog.ItemHeight = 15;
			this.lbLog.Location = new System.Drawing.Point(14, 13);
			this.lbLog.Name = "lbLog";
			this.lbLog.Size = new System.Drawing.Size(312, 79);
			this.lbLog.TabIndex = 0;
			// 
			// lblDes
			// 
			this.lblDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDes.Location = new System.Drawing.Point(11, 94);
			this.lblDes.Name = "lblDes";
			this.lblDes.Size = new System.Drawing.Size(314, 132);
			this.lblDes.TabIndex = 1;
			this.lblDes.Tag = "";
			this.lblDes.Text = "Just a simple app to convert link to {% post_url %}\r\nExample : \r\n\r\nhttp://xxx.com" +
    "/2012/12/test.html\r\nto\r\n{% post_url test %}\r\n\r\n(Will auto convert when you copy " +
    "a link to the clipboard)";
			this.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 239);
			this.Controls.Add(this.lblDes);
			this.Controls.Add(this.lbLog);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(350, 270);
			this.Name = "frmMain";
			this.Text = "gBloggerToJekyll - Blog Link Conversion Helper";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbLog;
		private System.Windows.Forms.Label lblDes;
	}
}

