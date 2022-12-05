
namespace WeatherApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbAreaCode = new System.Windows.Forms.PictureBox();
            this.pbDayAfterTomorrow = new System.Windows.Forms.PictureBox();
            this.pbTomorrow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAreaCode = new System.Windows.Forms.ListBox();
            this.cbAreaCode = new System.Windows.Forms.ComboBox();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAreaCode
            // 
            this.pbAreaCode.BackColor = System.Drawing.Color.Transparent;
            this.pbAreaCode.ErrorImage = null;
            this.pbAreaCode.Image = ((System.Drawing.Image)(resources.GetObject("pbAreaCode.Image")));
            this.pbAreaCode.ImageLocation = "";
            this.pbAreaCode.Location = new System.Drawing.Point(12, 12);
            this.pbAreaCode.Name = "pbAreaCode";
            this.pbAreaCode.Size = new System.Drawing.Size(482, 508);
            this.pbAreaCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAreaCode.TabIndex = 0;
            this.pbAreaCode.TabStop = false;
            // 
            // pbDayAfterTomorrow
            // 
            this.pbDayAfterTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.pbDayAfterTomorrow.ErrorImage = null;
            this.pbDayAfterTomorrow.Image = ((System.Drawing.Image)(resources.GetObject("pbDayAfterTomorrow.Image")));
            this.pbDayAfterTomorrow.Location = new System.Drawing.Point(800, 12);
            this.pbDayAfterTomorrow.Name = "pbDayAfterTomorrow";
            this.pbDayAfterTomorrow.Size = new System.Drawing.Size(144, 134);
            this.pbDayAfterTomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDayAfterTomorrow.TabIndex = 2;
            this.pbDayAfterTomorrow.TabStop = false;
            // 
            // pbTomorrow
            // 
            this.pbTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.pbTomorrow.ErrorImage = null;
            this.pbTomorrow.Image = ((System.Drawing.Image)(resources.GetObject("pbTomorrow.Image")));
            this.pbTomorrow.Location = new System.Drawing.Point(650, 12);
            this.pbTomorrow.Name = "pbTomorrow";
            this.pbTomorrow.Size = new System.Drawing.Size(144, 134);
            this.pbTomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTomorrow.TabIndex = 4;
            this.pbTomorrow.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(512, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "今日の天気";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(660, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "明日の天気";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(796, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "明後日の天気";
            // 
            // lbAreaCode
            // 
            this.lbAreaCode.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAreaCode.FormattingEnabled = true;
            this.lbAreaCode.ItemHeight = 24;
            this.lbAreaCode.Location = new System.Drawing.Point(500, 267);
            this.lbAreaCode.Name = "lbAreaCode";
            this.lbAreaCode.Size = new System.Drawing.Size(444, 244);
            this.lbAreaCode.TabIndex = 8;
            this.lbAreaCode.SelectedIndexChanged += new System.EventHandler(this.lbAreaCode_SelectedIndexChanged);
            // 
            // cbAreaCode
            // 
            this.cbAreaCode.BackColor = System.Drawing.Color.White;
            this.cbAreaCode.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAreaCode.FormattingEnabled = true;
            this.cbAreaCode.Location = new System.Drawing.Point(500, 229);
            this.cbAreaCode.Name = "cbAreaCode";
            this.cbAreaCode.Size = new System.Drawing.Size(265, 32);
            this.cbAreaCode.TabIndex = 9;
            this.cbAreaCode.SelectedIndexChanged += new System.EventHandler(this.cbAreaCode_SelectedIndexChanged);
            // 
            // pbToday
            // 
            this.pbToday.BackColor = System.Drawing.Color.Transparent;
            this.pbToday.ErrorImage = null;
            this.pbToday.Image = ((System.Drawing.Image)(resources.GetObject("pbToday.Image")));
            this.pbToday.InitialImage = null;
            this.pbToday.Location = new System.Drawing.Point(500, 12);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(144, 134);
            this.pbToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbToday.TabIndex = 3;
            this.pbToday.TabStop = false;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(874, 229);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(70, 32);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 532);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.cbAreaCode);
            this.Controls.Add(this.lbAreaCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTomorrow);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.pbDayAfterTomorrow);
            this.Controls.Add(this.pbAreaCode);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAreaCode;
        private System.Windows.Forms.PictureBox pbDayAfterTomorrow;
        private System.Windows.Forms.PictureBox pbTomorrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAreaCode;
        private System.Windows.Forms.ComboBox cbAreaCode;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.Button btClear;
    }
}

