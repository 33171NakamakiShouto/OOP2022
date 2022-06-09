
namespace Newber_Game
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
            this.button1 = new System.Windows.Forms.Button();
            this.nudNum1 = new System.Windows.Forms.NumericUpDown();
            this.Bef = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNum2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(424, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "判定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudNum1
            // 
            this.nudNum1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum1.Location = new System.Drawing.Point(156, 180);
            this.nudNum1.Name = "nudNum1";
            this.nudNum1.Size = new System.Drawing.Size(120, 44);
            this.nudNum1.TabIndex = 2;
            // 
            // Bef
            // 
            this.Bef.AutoSize = true;
            this.Bef.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Bef.Location = new System.Drawing.Point(293, 42);
            this.Bef.Name = "Bef";
            this.Bef.Size = new System.Drawing.Size(473, 37);
            this.Bef.TabIndex = 3;
            this.Bef.Text = "の中から正しいの数を当ててね!!";
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ans.Location = new System.Drawing.Point(217, 352);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(271, 37);
            this.Ans.TabIndex = 4;
            this.Ans.Text = "頑張って当ててね";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "1から";
            // 
            // nudNum2
            // 
            this.nudNum2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum2.Location = new System.Drawing.Point(156, 42);
            this.nudNum2.Name = "nudNum2";
            this.nudNum2.Size = new System.Drawing.Size(120, 44);
            this.nudNum2.TabIndex = 6;
            this.nudNum2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNum2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.Bef);
            this.Controls.Add(this.nudNum1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudNum1;
        private System.Windows.Forms.Label Bef;
        private System.Windows.Forms.Label Ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNum2;
    }
}

