
namespace CarReportSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRegistDate = new System.Windows.Forms.DateTimePicker();
            this.cbRecorder = new System.Windows.Forms.ComboBox();
            this.rbToeta = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbOutsideCar = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btOpArticle = new System.Windows.Forms.Button();
            this.btPvArticle = new System.Windows.Forms.Button();
            this.dgvTdrms = new System.Windows.Forms.DataGridView();
            this.btEnd = new System.Windows.Forms.Button();
            this.btDelReport = new System.Windows.Forms.Button();
            this.btCorrReport = new System.Windows.Forms.Button();
            this.btAddReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btOpPicture = new System.Windows.Forms.Button();
            this.btDelPicture = new System.Windows.Forms.Button();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTdrms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(39, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "レポート:";
            // 
            // dtpRegistDate
            // 
            this.dtpRegistDate.Location = new System.Drawing.Point(83, 5);
            this.dtpRegistDate.Name = "dtpRegistDate";
            this.dtpRegistDate.Size = new System.Drawing.Size(164, 19);
            this.dtpRegistDate.TabIndex = 5;
            // 
            // cbRecorder
            // 
            this.cbRecorder.FormattingEnabled = true;
            this.cbRecorder.Location = new System.Drawing.Point(83, 34);
            this.cbRecorder.Name = "cbRecorder";
            this.cbRecorder.Size = new System.Drawing.Size(210, 20);
            this.cbRecorder.TabIndex = 6;
            // 
            // rbToeta
            // 
            this.rbToeta.AutoSize = true;
            this.rbToeta.Location = new System.Drawing.Point(81, 61);
            this.rbToeta.Name = "rbToeta";
            this.rbToeta.Size = new System.Drawing.Size(47, 16);
            this.rbToeta.TabIndex = 7;
            this.rbToeta.TabStop = true;
            this.rbToeta.Text = "トヨタ";
            this.rbToeta.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(134, 61);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 8;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(241, 61);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 9;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            this.rbSubaru.CheckedChanged += new System.EventHandler(this.rbSubaru_CheckedChanged);
            // 
            // rbOutsideCar
            // 
            this.rbOutsideCar.AutoSize = true;
            this.rbOutsideCar.Location = new System.Drawing.Point(299, 61);
            this.rbOutsideCar.Name = "rbOutsideCar";
            this.rbOutsideCar.Size = new System.Drawing.Size(47, 16);
            this.rbOutsideCar.TabIndex = 10;
            this.rbOutsideCar.TabStop = true;
            this.rbOutsideCar.Text = "外車";
            this.rbOutsideCar.UseVisualStyleBackColor = true;
            this.rbOutsideCar.CheckedChanged += new System.EventHandler(this.rbOutsideCar_CheckedChanged);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(352, 61);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 11;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(83, 84);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(210, 20);
            this.cbCarName.TabIndex = 12;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(81, 111);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(353, 103);
            this.tbReport.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(15, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "記事一覧:";
            // 
            // btOpArticle
            // 
            this.btOpArticle.Location = new System.Drawing.Point(18, 245);
            this.btOpArticle.Name = "btOpArticle";
            this.btOpArticle.Size = new System.Drawing.Size(59, 27);
            this.btOpArticle.TabIndex = 15;
            this.btOpArticle.Text = "開く";
            this.btOpArticle.UseVisualStyleBackColor = true;
            // 
            // btPvArticle
            // 
            this.btPvArticle.Location = new System.Drawing.Point(19, 278);
            this.btPvArticle.Name = "btPvArticle";
            this.btPvArticle.Size = new System.Drawing.Size(59, 27);
            this.btPvArticle.TabIndex = 16;
            this.btPvArticle.Text = "保存";
            this.btPvArticle.UseVisualStyleBackColor = true;
            // 
            // dgvTdrms
            // 
            this.dgvTdrms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTdrms.Location = new System.Drawing.Point(81, 219);
            this.dgvTdrms.Name = "dgvTdrms";
            this.dgvTdrms.RowTemplate.Height = 21;
            this.dgvTdrms.Size = new System.Drawing.Size(624, 227);
            this.dgvTdrms.TabIndex = 17;
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(604, 452);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(101, 23);
            this.btEnd.TabIndex = 18;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            // 
            // btDelReport
            // 
            this.btDelReport.Location = new System.Drawing.Point(629, 191);
            this.btDelReport.Name = "btDelReport";
            this.btDelReport.Size = new System.Drawing.Size(76, 23);
            this.btDelReport.TabIndex = 19;
            this.btDelReport.Text = "削除";
            this.btDelReport.UseVisualStyleBackColor = true;
            // 
            // btCorrReport
            // 
            this.btCorrReport.Location = new System.Drawing.Point(547, 191);
            this.btCorrReport.Name = "btCorrReport";
            this.btCorrReport.Size = new System.Drawing.Size(76, 23);
            this.btCorrReport.TabIndex = 20;
            this.btCorrReport.Text = "修正";
            this.btCorrReport.UseVisualStyleBackColor = true;
            // 
            // btAddReport
            // 
            this.btAddReport.Location = new System.Drawing.Point(465, 190);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(76, 23);
            this.btAddReport.TabIndex = 21;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = true;
            this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(473, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "画像:";
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(481, 37);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(214, 148);
            this.pbPicture.TabIndex = 24;
            this.pbPicture.TabStop = false;
            // 
            // btOpPicture
            // 
            this.btOpPicture.Location = new System.Drawing.Point(515, 5);
            this.btOpPicture.Name = "btOpPicture";
            this.btOpPicture.Size = new System.Drawing.Size(92, 23);
            this.btOpPicture.TabIndex = 25;
            this.btOpPicture.Text = "開く";
            this.btOpPicture.UseVisualStyleBackColor = true;
            this.btOpPicture.Click += new System.EventHandler(this.btOpPicture_Click);
            // 
            // btDelPicture
            // 
            this.btDelPicture.Location = new System.Drawing.Point(613, 5);
            this.btDelPicture.Name = "btDelPicture";
            this.btDelPicture.Size = new System.Drawing.Size(92, 23);
            this.btDelPicture.TabIndex = 26;
            this.btDelPicture.Text = "削除";
            this.btDelPicture.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(187, 61);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 27;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 480);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.btDelPicture);
            this.Controls.Add(this.btOpPicture);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.btCorrReport);
            this.Controls.Add(this.btDelReport);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.dgvTdrms);
            this.Controls.Add(this.btPvArticle);
            this.Controls.Add(this.btOpArticle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbOutsideCar);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToeta);
            this.Controls.Add(this.cbRecorder);
            this.Controls.Add(this.dtpRegistDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTdrms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRegistDate;
        private System.Windows.Forms.ComboBox cbRecorder;
        private System.Windows.Forms.RadioButton rbToeta;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbOutsideCar;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOpArticle;
        private System.Windows.Forms.Button btPvArticle;
        private System.Windows.Forms.DataGridView dgvTdrms;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btDelReport;
        private System.Windows.Forms.Button btCorrReport;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btOpPicture;
        private System.Windows.Forms.Button btDelPicture;
        private System.Windows.Forms.RadioButton rbHonda;
    }
}

