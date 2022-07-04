
namespace RSSReader
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btRssGet = new System.Windows.Forms.Button();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.wvBrouser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrouser)).BeginInit();
            this.SuspendLayout();
            // 
            // btRssGet
            // 
            this.btRssGet.Location = new System.Drawing.Point(916, 8);
            this.btRssGet.Name = "btRssGet";
            this.btRssGet.Size = new System.Drawing.Size(60, 23);
            this.btRssGet.TabIndex = 1;
            this.btRssGet.Text = "取得";
            this.btRssGet.UseVisualStyleBackColor = true;
            this.btRssGet.Click += new System.EventHandler(this.btRssGet_Click);
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(12, 10);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(898, 20);
            this.cbRssUrl.TabIndex = 2;
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(13, 37);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(195, 568);
            this.lbRssTitle.TabIndex = 5;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(998, 8);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(54, 23);
            this.btReturn.TabIndex = 6;
            this.btReturn.Text = "戻る";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1058, 7);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(54, 23);
            this.btNext.TabIndex = 7;
            this.btNext.Text = "次へ";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // wvBrouser
            // 
            this.wvBrouser.Location = new System.Drawing.Point(214, 37);
            this.wvBrouser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrouser.Name = "wvBrouser";
            this.wvBrouser.Size = new System.Drawing.Size(898, 568);
            this.wvBrouser.Source = new System.Uri("https://www.yahoo.co.jp/", System.UriKind.Absolute);
            this.wvBrouser.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 610);
            this.Controls.Add(this.wvBrouser);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.btRssGet);
            this.Name = "Form1";
            this.Text = "RSSReader";
            ((System.ComponentModel.ISupportInitialize)(this.wvBrouser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRssGet;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btNext;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrouser;
    }
}

