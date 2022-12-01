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
        string AreaCode = "0";

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

            //AreaCode = "014030";

            if (AreaCode == "0") { tbWeatherInfo.Text = "地域が選択されていません";return; }
            if (AreaCode == "014030") { tbWeatherInfo.Text = "こちらは現在使用できません"; return; }
            if (AreaCode == "460040") { tbWeatherInfo.Text = "こちらは現在使用できません"; return; }

            var dStrig = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{AreaCode}.json");
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
                    lbAreaCode.Items.Add("沖縄本島地方");
                    lbAreaCode.Items.Add("大東島地方");
                    lbAreaCode.Items.Add("宮古島地方");
                    lbAreaCode.Items.Add("八重山地方");
                    break;
            }          
        }

        private void lbAreaCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAreaCode.SelectedItem == null){return;}

            if (lbAreaCode.SelectedItem.ToString() == "宗谷地方") { AreaCode = "011000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "上川・留萌地方") { AreaCode = "012000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "網走・北見・紋別地方") { AreaCode = "013000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "十勝地方") { AreaCode = "014030"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "釧路・根室地方") { AreaCode = "014100"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "胆振・日高地方") { AreaCode = "015000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "石狩・空知・後志地方") { AreaCode = "016000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "渡島・檜山地方") { AreaCode = "017000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "青森県") { AreaCode = "020000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "岩手県") { AreaCode = "030000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "宮城県") { AreaCode = "040000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "秋田県") { AreaCode = "050000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "山形県") { AreaCode = "060000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "福島県") { AreaCode = "070000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "茨城県") { AreaCode = "080000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "栃木県") { AreaCode = "090000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "群馬県") { AreaCode = "100000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "埼玉県") { AreaCode = "110000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "千葉県") { AreaCode = "120000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "東京都") { AreaCode = "130000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "神奈川県") { AreaCode = "140000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "山梨県") { AreaCode = "190000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "長野県") { AreaCode = "200000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "岐阜県") { AreaCode = "210000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "静岡県") { AreaCode = "220000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "愛知県") { AreaCode = "230000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "三重県") { AreaCode = "240000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "新潟県") { AreaCode = "150000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "富山県") { AreaCode = "160000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "石川県") { AreaCode = "170000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "福井県") { AreaCode = "180000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "滋賀県") { AreaCode = "250000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "京都府") { AreaCode = "260000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "大阪府") { AreaCode = "270000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "兵庫県") { AreaCode = "280000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "奈良県") { AreaCode = "290000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "和歌山県") { AreaCode = "300000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "鳥取県") { AreaCode = "310000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "島根県") { AreaCode = "320000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "岡山県") { AreaCode = "330000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "広島県") { AreaCode = "340000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "徳島県") { AreaCode = "360000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "福岡県") { AreaCode = "400000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "佐賀県") { AreaCode = "410000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "長崎県") { AreaCode = "420000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "熊本県") { AreaCode = "430000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "大分県") { AreaCode = "440000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "宮崎県") { AreaCode = "450000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "奄美地方") { AreaCode = "460040"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "鹿児島県（奄美地方除く）") { AreaCode = "460100"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "沖縄本島地方") { AreaCode = "471000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "大東島地方") { AreaCode = "472000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "宮古島地方") { AreaCode = "473000"; return; }
            if (lbAreaCode.SelectedItem.ToString() == "八重山地方") { AreaCode = "474000"; }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbAreaCode.Text = null;
            lbAreaCode.Items.Clear();
        }
    }
}
