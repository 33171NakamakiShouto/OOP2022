using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addressTobleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addressTobleDataGridView_Click(object sender, EventArgs e)
        {
            if (addressTobleDataGridView.CurrentRow == null)
                return;

            tbName.Text = addressTobleDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addressTobleDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbTel.Text = addressTobleDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = addressTobleDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addressTobleDataGridView.CurrentRow.Cells[5].Value.ToString();
            //画像表示処理
            if (!(addressTobleDataGridView.CurrentRow.Cells[6].Value is DBNull))
            
               pbImage.Image = ByteArrayToImage((byte[])addressTobleDataGridView.CurrentRow.Cells[6].Value);
            
            else pbImage.Image = null;
                   
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
             addressTobleDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
             addressTobleDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
             addressTobleDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
             addressTobleDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
             addressTobleDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
             addressTobleDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            this.Validate();
            this.addressTobleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202216DataSet);
        }

        private void btImageOpen_Click(object sender, EventArgs e)
        {
            ofdImege.Filter = "画像ファイル(*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            if (ofdImege.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImege.FileName);
            }
        }

        private void btImegeClear_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = infosys202216DataSet.AddressToble.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            newRow[3] = tbTel.Text;
            newRow[4] = tbMail.Text;
            newRow[5] = tbMemo.Text;
            newRow[6] = ImageToByteArray(pbImage.Image);

            //データセットへ新しいレコードを追加
            infosys202216DataSet.AddressToble.Rows.Add(newRow);
            //データベース更新
            this.addressTobleTableAdapter.Update(this.infosys202216DataSet.AddressToble);
        }

        //エラー回避
        private void addressTobleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btNameSearch_Click(object sender, EventArgs e)
        {
            addressTobleTableAdapter.FillByName(infosys202216DataSet.AddressToble,tbNameSearch.Text);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbName.Text = tbAddress.Text = tbTel.Text = tbMail.Text = tbMemo.Text = "";
            pbImage.Image = null;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202216DataSet.AddressToble' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.addressTobleTableAdapter.Fill(this.infosys202216DataSet.AddressToble);
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Version().ShowDialog();
        }
    }
}
