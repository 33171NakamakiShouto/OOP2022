using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btAddReport_Click(object sender, EventArgs e)
        {
            CarReport newCarReport = new CarReport
            {
                Registration = dtpRegistDate.Value,
                Recorder = cbRecorder.Text,
                Maker = GetMakerGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
            };

            setcbRecorder(cbRecorder.Text);
            setcbCarName(cbCarName.Text);

            listCarReport.Add(newCarReport);
            btCorrReport.Enabled = true;
            btDelReport.Enabled = true;
        }

        private CarReport.MakerType GetRadioButtonGroup()
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
            if (rbNissan.Checked)
            {
                return CarReport.MakerType.日産;
            }
            if (rbNissan.Checked)
            {
                return CarReport.MakerType.日産;
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

        private void rbSubaru_CheckedChanged(object sender, EventArgs e){}
        private void rbOutsideCar_CheckedChanged(object sender, EventArgs e){}

        //画像追加ボタン
        private void btOpPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
