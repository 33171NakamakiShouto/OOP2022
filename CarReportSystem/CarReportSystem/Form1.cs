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
        private BindingList<CarReport> listCarReport;

        public Form1()
        {
            InitializeComponent();
            dgvTdrms.DataSource = listCarReport;
            
        }
        

        //追加ボタン
        private void btAddReport_Click(object sender, EventArgs e)
        {
            CarReport newCarReport = new CarReport
            {
                Registration = dtpRegistDate.Value,
                Recorder = cbRecorder.Text,
                Maker = GetMakerGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };

            setcbRecorder(cbRecorder.Text);
            setcbCarName(cbCarName.Text);

            listCarReport.Add(newCarReport);
            AllDelete();            
            btCorrReport.Enabled = true;
            btDelReport.Enabled = true;
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
            if (cbRecorder.Items.IndexOf(cbRecorder.Text) == -1)
            {
                cbRecorder.Items.Add(cbRecorder.Text);
            }
        }

        private void setcbCarName(string company)
        {
            if (cbCarName.Items.IndexOf(cbCarName.Text) == -1)
            {
                cbCarName.Items.Add(cbCarName.Text);
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

        //記事の保存
        private void btPvArticle_Click(object sender, EventArgs e)
        {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //記事の開く
        private void btOpArticle_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvTdrms.DataSource = null;
                        dgvTdrms.DataSource = listCarReport;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cbCarName.Items.Clear();
                cbRecorder.Items.Clear();

                foreach (var item in listCarReport.Select(p => p.CarName))
                {
                    setcbCarName(item);
                }
                foreach (var item in listCarReport.Select(p => p.Recorder))
                {
                    setcbRecorder(item);
                }

                EnadledCheck();

            }
        }

        private void EnadledCheck()
        {
            btCorrReport.Enabled = btDelReport.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        //修正ボタン
        private void btCorrReport_Click(object sender, EventArgs e)
        {
            if (dgvTdrms.CurrentRow == null) return;

            var select = dgvTdrms.CurrentRow.Index;
            listCarReport[select].Recorder = cbRecorder.Text;
            listCarReport[select].Maker = GetMakerGroup();
            listCarReport[select].CarName = cbCarName.Text;
            listCarReport[select].Report = tbReport.Text;
            listCarReport[select].Picture = pbPicture.Image;
            dgvTdrms.Refresh();//データグリッドビュー更新
            EnadledCheck();
            AllDelete();
        }

        //削除ボタン
        private void btDelReport_Click(object sender, EventArgs e)
        {
            if (dgvTdrms.CurrentRow == null) return;
            listCarReport.RemoveAt(dgvTdrms.CurrentRow.Index);

            EnadledCheck();
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvTdrms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTdrms.CurrentRow == null) return;

            int index = dgvTdrms.CurrentRow.Index;

            cbRecorder.Text = listCarReport[index].Recorder;
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;

            dtpRegistDate.Value = listCarReport[index].Registration.Year > 1900 ?
                listCarReport[index].Registration : DateTime.Today;

            grouoMakerTypeAllClear();
            grouoMakerTypeAllUpdate();
        }

        private void grouoMakerTypeAllUpdate()
        {
            var select = dgvTdrms.CurrentRow.Index;
            switch (listCarReport[select].Maker)
            {
                case MakerType.トヨタ:
                    rbToeta.Checked = true;
                    break;
                case MakerType.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerType.ホンダ:
                     rbHonda.Checked = true;
                    break;
                case MakerType.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerType.外車:
                    rbOutsideCar.Checked = true;
                    break;
                case MakerType.その他:
                    break;
                default:
                    break;
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
            try
            {
                using (var reader = XmlReader.Create("Settings.xml"))
                {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    settings = serializer.ReadObject(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                btCorrReport.Enabled = btDelReport.Enabled = false;
            }
        }
    }
}
