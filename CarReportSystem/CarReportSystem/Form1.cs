using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {

        Settings settings = Settings.getInstance();


        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dgvTdrms.DataSource = listCarReport;
            
        }

        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        //追加ボタン
        private void btAddReport_Click(object sender, EventArgs e)
        {
            DataRow newRow = infosys202216DataSet.CarReportDB.NewRow();
            newRow[1] = dtpRegistDate.Text;
            newRow[2] = cbRecorder.Text;
            newRow[3] = GetMakerGroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);

            //データセットへ新しいレコードを追加
            infosys202216DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202216DataSet.CarReportDB);

            setcbRecorder(cbRecorder.Text);
            setcbCarName(cbCarName.Text);

            AllDelete();            
            //btDelReport.Enabled = true;
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

        private CarReport.MakerType GetMakerGroup()
        {
            var selectKindNumber = CarReport.MakerType.その他;

            if (rbToeta.Checked)
            {
                return CarReport.MakerType.トヨタ;
            }
            if (rbNissan.Checked)
            {
                return CarReport.MakerType.日産;
            }
            if (rbHonda.Checked)
            {
                return CarReport.MakerType.ホンダ;
            }
            if (rbSubaru.Checked)
            {
                return CarReport.MakerType.スバル;
            }
            if (rbOutsideCar.Checked)
            {
                return CarReport.MakerType.外車;
            }

            return selectKindNumber;
        }

        private void setcbRecorder(string company)
        {
            if (!(cbRecorder.Items.Contains(company)))
            {
                cbRecorder.Items.Add(company);
            }
        }

        private void setcbCarName(string company)
        {
            if ((!cbCarName.Items.Contains(company) ))
            {
                cbCarName.Items.Add(company);
            }
        }

        private void AllDelete()
        {
            cbRecorder.Text = cbCarName.Text = tbReport.Text = null;
            pbPicture.Image = null;
            grouoMakerTypeAllClear();
        }


        //画像追加ボタン
        private void btOpPicture_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
            
        }

        private void btDelPicture_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }               

        //削除ボタン
        private void btDelReport_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = carReportDBDataGridView.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--)
            {
                carReportDBDataGridView.Rows.RemoveAt(src[i].Index);
            }

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202216DataSet);

        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvTdrms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (dgvTdrms.CurrentRow == null) return;

        //    int index = dgvTdrms.CurrentRow.Index;

        //    cbRecorder.Text = listCarReport[index].Recorder;
        //    cbCarName.Text = listCarReport[index].CarName;
        //    tbReport.Text = listCarReport[index].Report;
        //    tbReport.Text = listCarReport[index].Report;
        //    pbPicture.Image = listCarReport[index].Picture;

        //    dtpRegistDate.Value = listCarReport[index].Registration.Year > 1900 ?
        //        listCarReport[index].Registration : DateTime.Today;



        //    grouoMakerTypeAllClear();
        //    GetMakerGroup();
        }

        private void grouoMakerTypeAllUpdate()
        {
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "トヨタ" )
            {
                rbToeta.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "日産")
            {
                rbNissan.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "ホンダ")
            {
                rbHonda.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "スバル")
            {
                rbSubaru.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "外車")
            {
                rbOutsideCar.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "その他")
            {
                rbOther.Checked = true;
            }
        }

        private void grouoMakerTypeAllClear()
        {
            rbHonda.Checked = rbNissan.Checked = rbOther.Checked =
                rbOutsideCar.Checked = rbSubaru.Checked = rbToeta.Checked = false;
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (cdColorSelect.ShowDialog() == DialogResult.OK)
            {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();//設定オブジェクトにセット
            }
        }

        private void LoadColorSelect(ColorDialog Settings)
        {          
            using (var reader = XmlReader.Create("Settings"))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                var employee = serializer.Deserialize(reader) as Settings;
                Console.WriteLine(employee);
                
            }
        }

        private void SaveColorSelect(ColorDialog Settings)
        {
            using (var writer = XmlWriter.Create("Settings"))
            {
                var serializer = new XmlSerializer(Settings.GetType());
                serializer.Serialize(writer, Settings);
            }
        }

        //とじる
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var writer = XmlWriter.Create("Settings.xml"))
            {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }
        }

        //ひらく
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = XmlReader.Create("Settings.xml"))
            {
                var serializer = new DataContractSerializer(typeof(Settings));
                settings = serializer.ReadObject(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
        }

        private void tbReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllDelete();

            // TODO: このコード行はデータを 'infosys202216DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202216DataSet.CarReportDB);

            for (int i = 0; i < carReportDBDataGridView.RowCount; i++)
            {
                setcbRecorder(carReportDBDataGridView.Rows[i].Cells[2].Value.ToString());
                setcbCarName(carReportDBDataGridView.Rows[i].Cells[4].Value.ToString());
            }


            btUpdate.Enabled = btAddReport.Enabled = btDelReport.Enabled = true;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpRegistDate.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbRecorder.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetMakerGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pbPicture.Image;

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202216DataSet);
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e)
        {
            if (carReportDBDataGridView.CurrentRow == null)
                return;

            dtpRegistDate.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbRecorder.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            grouoMakerTypeAllClear();
            grouoMakerTypeAllUpdate();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            //画像表示処理
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))

                pbPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);

            else pbPicture.Image = null;
        }

        private void btNameSearch_Click(object sender, EventArgs e)
        {
           carReportDBTableAdapter.FillByName(infosys202216DataSet.CarReportDB, tbNameSearch.Text);
        }

        private void btAllDelete_Click(object sender, EventArgs e)
        {
            AllDelete();
        }
    }
}
