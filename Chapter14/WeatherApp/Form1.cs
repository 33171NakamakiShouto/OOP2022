using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class btWeatherGet : Form
    {
        public btWeatherGet()
        {
            InitializeComponent();
            cbAreaCode.Items.Add("北海道地方");
            cbAreaCode.Items.Add("東北地方");
            cbAreaCode.Items.Add("関東甲信地方");
            cbAreaCode.Items.Add("東海地方");
            cbAreaCode.Items.Add("北陸地方");
            cbAreaCode.Items.Add("近畿地方");
            cbAreaCode.Items.Add("中国地方（山口県を除く）");
            cbAreaCode.Items.Add("四国地方");
            cbAreaCode.Items.Add("九州北部地方（山口県を含む）");
            cbAreaCode.Items.Add("九州南部・奄美地方");
            cbAreaCode.Items.Add("沖縄地方");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            var dStrig = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dStrig);

            tbWeatherInfo.Text = json.text;
        }

        private void cbAreaCode_SelectedIndexChanged(object sender, EventArgs e)
        {          
            switch (cbAreaCode.Text)
            {
                case "北海道地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("宗谷地方");
                    lbAreaCode.Items.Add("上川・留萌地方");
                    lbAreaCode.Items.Add("網走・北見・紋別地方");
                    lbAreaCode.Items.Add("十勝地方");
                    lbAreaCode.Items.Add("釧路・根室地方");
                    lbAreaCode.Items.Add("胆振・日高地方");
                    lbAreaCode.Items.Add("石狩・空知・後志地方");
                    lbAreaCode.Items.Add("渡島・檜山地方");
                    break;
                case "東北地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("青森県");
                    lbAreaCode.Items.Add("岩手県");
                    lbAreaCode.Items.Add("宮城県");
                    lbAreaCode.Items.Add("秋田県");
                    lbAreaCode.Items.Add("山形県");
                    lbAreaCode.Items.Add("福島県");
                    break;
                case "関東甲信地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("茨城県");
                    lbAreaCode.Items.Add("栃木県");
                    lbAreaCode.Items.Add("群馬県");
                    lbAreaCode.Items.Add("埼玉県");
                    lbAreaCode.Items.Add("千葉県");
                    lbAreaCode.Items.Add("東京都");
                    lbAreaCode.Items.Add("神奈川県");
                    lbAreaCode.Items.Add("山梨県");
                    lbAreaCode.Items.Add("長野県");
                    break;
                case "東海地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("岐阜県");
                    lbAreaCode.Items.Add("静岡県");
                    lbAreaCode.Items.Add("愛知県");
                    lbAreaCode.Items.Add("三重県");
                    break;
                case "北陸地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("新潟県");
                    lbAreaCode.Items.Add("富山県");
                    lbAreaCode.Items.Add("石川県");
                    lbAreaCode.Items.Add("福井県");
                    break;
                case "近畿地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("滋賀県");
                    lbAreaCode.Items.Add("京都府");
                    lbAreaCode.Items.Add("大阪府");
                    lbAreaCode.Items.Add("兵庫県");
                    lbAreaCode.Items.Add("奈良県");
                    lbAreaCode.Items.Add("和歌山県");
                    break;
                case "中国地方（山口県を除く）":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("鳥取県");
                    lbAreaCode.Items.Add("島根県");
                    lbAreaCode.Items.Add("岡山県");
                    lbAreaCode.Items.Add("広島県");
                    break;
                case "四国地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("徳島県");
                    lbAreaCode.Items.Add("香川県");
                    lbAreaCode.Items.Add("愛媛県");
                    lbAreaCode.Items.Add("高知県");
                    break;
                case "九州北部地方（山口県を含む）":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("山口県");
                    lbAreaCode.Items.Add("福岡県");
                    lbAreaCode.Items.Add("佐賀県");
                    lbAreaCode.Items.Add("長崎県");
                    lbAreaCode.Items.Add("熊本県");
                    lbAreaCode.Items.Add("大分県");
                    break;
                case "九州南部・奄美地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("宮崎県");
                    lbAreaCode.Items.Add("奄美地方");
                    lbAreaCode.Items.Add("鹿児島県（奄美地方除く）");
                    break;
                case "沖縄地方":
                    lbAreaCode.Items.Clear();
                    lbAreaCode.Items.Add("沖縄地方");
                    lbAreaCode.Items.Add("大東島地方");
                    lbAreaCode.Items.Add("宮古島地方");
                    lbAreaCode.Items.Add("八重山地方");
                    break;
            }
        }
    }
}
