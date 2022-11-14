
namespace WeatherApp
{
    partial class btWeatherGet
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
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbAreaCode = new System.Windows.Forms.ComboBox();
            this.lbAreaCode = new System.Windows.Forms.ListBox();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(12, 443);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(614, 181);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "取得";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAreaCode
            // 
            this.cbAreaCode.FormattingEnabled = true;
            this.cbAreaCode.Location = new System.Drawing.Point(457, 275);
            this.cbAreaCode.Name = "cbAreaCode";
            this.cbAreaCode.Size = new System.Drawing.Size(169, 20);
            this.cbAreaCode.TabIndex = 2;
            this.cbAreaCode.SelectedIndexChanged += new System.EventHandler(this.cbAreaCode_SelectedIndexChanged);
            // 
            // lbAreaCode
            // 
            this.lbAreaCode.FormattingEnabled = true;
            this.lbAreaCode.ItemHeight = 12;
            this.lbAreaCode.Location = new System.Drawing.Point(457, 301);
            this.lbAreaCode.Name = "lbAreaCode";
            this.lbAreaCode.Size = new System.Drawing.Size(169, 136);
            this.lbAreaCode.TabIndex = 3;
            this.lbAreaCode.SelectedIndexChanged += new System.EventHandler(this.lbAreaCode_SelectedIndexChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(457, 246);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(38, 23);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btWeatherGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 636);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbAreaCode);
            this.Controls.Add(this.cbAreaCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "btWeatherGet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbAreaCode;
        private System.Windows.Forms.ListBox lbAreaCode;
        private System.Windows.Forms.Button btClear;
    }
}

