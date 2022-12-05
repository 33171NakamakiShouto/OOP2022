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

namespace WeatherApp2
{
    public partial class Form1 : Form
    {
        string AreaCode = "0";
        string WeatherCode = "0";
        string[] Change = {"103","105","106","107","108","109","111","113","114","116","117","118","119",
                           "120","121","122","123","124","125","126","127","128","130","131","132","140",
                           "160","170","181","203","205","206","207","208","209","211","213","214","216",
                           "217","218","219","220","221","222","223","224","225","226","228","229","230",
                           "231","240","250","260","270","281","304","306","309","315","316","314","320",
                           "321","322","323","324","325","326","327","328","329","340","350","361","371",
                           "405","407","409","420","421","422","423","425","426","427","450"};
        int check = 0;

        public Form1()
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

        private void cbAreaCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAreaCode.Items.Clear();

            switch (cbAreaCode.Text)
            {
                case "北海道地方":
                    lbAreaCode.Items.Add("宗谷地方");
                    lbAreaCode.Items.Add("上川・留萌地方");
                    lbAreaCode.Items.Add("網走・北見・紋別地方");
                    lbAreaCode.Items.Add("十勝地方");
                    lbAreaCode.Items.Add("釧路・根室地方");
                    lbAreaCode.Items.Add("胆振・日高地方");
                    lbAreaCode.Items.Add("石狩・空知・後志地方");
                    lbAreaCode.Items.Add("渡島・檜山地方");
                    pbAreaCode.ImageLocation = @"Images\北海道.png";
                    break;
                case "東北地方":
                    lbAreaCode.Items.Add("青森県");
                    lbAreaCode.Items.Add("岩手県");
                    lbAreaCode.Items.Add("宮城県");
                    lbAreaCode.Items.Add("秋田県");
                    lbAreaCode.Items.Add("山形県");
                    lbAreaCode.Items.Add("福島県");
                    pbAreaCode.ImageLocation = @"Images\東北.png";
                    break;
                case "関東甲信地方":
                    lbAreaCode.Items.Add("茨城県");
                    lbAreaCode.Items.Add("栃木県");
                    lbAreaCode.Items.Add("群馬県");
                    lbAreaCode.Items.Add("埼玉県");
                    lbAreaCode.Items.Add("千葉県");
                    lbAreaCode.Items.Add("東京都");
                    lbAreaCode.Items.Add("神奈川県");
                    lbAreaCode.Items.Add("山梨県");
                    lbAreaCode.Items.Add("長野県");
                    pbAreaCode.ImageLocation = @"Images\関東甲信.png";
                    break;
                case "東海地方":
                    lbAreaCode.Items.Add("岐阜県");
                    lbAreaCode.Items.Add("静岡県");
                    lbAreaCode.Items.Add("愛知県");
                    lbAreaCode.Items.Add("三重県");
                    pbAreaCode.ImageLocation = @"Images\東海.png";
                    break;
                case "北陸地方":
                    lbAreaCode.Items.Add("新潟県");
                    lbAreaCode.Items.Add("富山県");
                    lbAreaCode.Items.Add("石川県");
                    lbAreaCode.Items.Add("福井県");
                    pbAreaCode.ImageLocation = @"Images\北陸.png";
                    break;
                case "近畿地方":
                    lbAreaCode.Items.Add("滋賀県");
                    lbAreaCode.Items.Add("京都府");
                    lbAreaCode.Items.Add("大阪府");
                    lbAreaCode.Items.Add("兵庫県");
                    lbAreaCode.Items.Add("奈良県");
                    lbAreaCode.Items.Add("和歌山県");
                    pbAreaCode.ImageLocation = @"Images\近畿.png";
                    break;
                case "中国地方（山口県を除く）":
                    lbAreaCode.Items.Add("鳥取県");
                    lbAreaCode.Items.Add("島根県");
                    lbAreaCode.Items.Add("岡山県");
                    lbAreaCode.Items.Add("広島県");
                    pbAreaCode.ImageLocation = @"Images\中国.png";
                    break;
                case "四国地方":
                    lbAreaCode.Items.Add("徳島県");
                    lbAreaCode.Items.Add("香川県");
                    lbAreaCode.Items.Add("愛媛県");
                    lbAreaCode.Items.Add("高知県");
                    pbAreaCode.ImageLocation = @"Images\四国.png";
                    break;
                case "九州北部地方（山口県を含む）":
                    lbAreaCode.Items.Add("山口県");
                    lbAreaCode.Items.Add("福岡県");
                    lbAreaCode.Items.Add("佐賀県");
                    lbAreaCode.Items.Add("長崎県");
                    lbAreaCode.Items.Add("熊本県");
                    lbAreaCode.Items.Add("大分県");
                    pbAreaCode.ImageLocation = @"Images\九州北部.png";
                    break;
                case "九州南部・奄美地方":
                    lbAreaCode.Items.Add("宮崎県");
                    lbAreaCode.Items.Add("奄美地方");
                    lbAreaCode.Items.Add("鹿児島県（奄美地方除く）");
                    pbAreaCode.ImageLocation = @"Images\九州南部.png";
                    break;
                case "沖縄地方":
                    lbAreaCode.Items.Add("沖縄本島地方");
                    lbAreaCode.Items.Add("大東島地方");
                    lbAreaCode.Items.Add("宮古島地方");
                    lbAreaCode.Items.Add("八重山地方");
                    pbAreaCode.ImageLocation = @"Images\沖縄.png";
                    break;
            }
        }

        private void lbAreaCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAreaCode.SelectedItem == null) { return; }

            if (lbAreaCode.SelectedItem.ToString() == "宗谷地方") { AreaCode = "011000";}
            if (lbAreaCode.SelectedItem.ToString() == "上川・留萌地方") { AreaCode = "012000"; }
            if (lbAreaCode.SelectedItem.ToString() == "網走・北見・紋別地方") { AreaCode = "013000"; }
            if (lbAreaCode.SelectedItem.ToString() == "十勝地方") { AreaCode = "014030";}
            if (lbAreaCode.SelectedItem.ToString() == "釧路・根室地方") { AreaCode = "014100"; }
            if (lbAreaCode.SelectedItem.ToString() == "胆振・日高地方") { AreaCode = "015000"; }
            if (lbAreaCode.SelectedItem.ToString() == "石狩・空知・後志地方") { AreaCode = "016000"; }
            if (lbAreaCode.SelectedItem.ToString() == "渡島・檜山地方") { AreaCode = "017000"; }
            if (lbAreaCode.SelectedItem.ToString() == "青森県")
            {
                AreaCode = "020000";
                pbAreaCode.ImageLocation = @"Images\青森.png"; 
            }
            if (lbAreaCode.SelectedItem.ToString() == "岩手県")
            {
                AreaCode = "030000";
                pbAreaCode.ImageLocation = @"Images\岩手.png"; 
            }
            if (lbAreaCode.SelectedItem.ToString() == "宮城県")
            {
                AreaCode = "040000";
                pbAreaCode.ImageLocation = @"Images\宮城.png"; 
            }
            if (lbAreaCode.SelectedItem.ToString() == "秋田県")
            {
                AreaCode = "050000";
                pbAreaCode.ImageLocation = @"Images\秋田.png"; 
            }
            if (lbAreaCode.SelectedItem.ToString() == "山形県")
            {
                AreaCode = "060000";
                pbAreaCode.ImageLocation = @"Images\山形.png"; 
            }
            if (lbAreaCode.SelectedItem.ToString() == "福島県")
            {
                AreaCode = "070000";
                pbAreaCode.ImageLocation = @"Images\福島.png"; 
            }
            //関東甲信　幅1977　高さ2148
            if (lbAreaCode.SelectedItem.ToString() == "茨城県")
            {
                AreaCode = "080000";
                pbAreaCode.ImageLocation = @"Images\茨城.png"; 
            }
            if (lbAreaCode.SelectedItem.ToString() == "栃木県")
            {
                AreaCode = "090000";
                pbAreaCode.ImageLocation = @"Images\栃木.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "群馬県")
            {
                AreaCode = "100000";
                pbAreaCode.ImageLocation = @"Images\群馬.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "埼玉県")
            {
                AreaCode = "110000";
                pbAreaCode.ImageLocation = @"Images\埼玉.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "千葉県")
            {
                AreaCode = "120000";
                pbAreaCode.ImageLocation = @"Images\千葉.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "東京都")
            {
                AreaCode = "130000";
                pbAreaCode.ImageLocation = @"Images\東京.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "神奈川県")
            {
                AreaCode = "140000";
                pbAreaCode.ImageLocation = @"Images\神奈川.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "山梨県")
            {
                AreaCode = "190000";
                pbAreaCode.ImageLocation = @"Images\山梨.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "長野県")
            {
                AreaCode = "200000";
                pbAreaCode.ImageLocation = @"Images\長野.png";
            }
            //東海地方  幅1977　高さ2148
            if (lbAreaCode.SelectedItem.ToString() == "岐阜県")
            {
                AreaCode = "210000";
                pbAreaCode.ImageLocation = @"Images\岐阜.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "静岡県")
            {
                AreaCode = "220000";
                pbAreaCode.ImageLocation = @"Images\静岡.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "愛知県")
            {
                AreaCode = "230000";
                pbAreaCode.ImageLocation = @"Images\愛知.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "三重県")
            {
                AreaCode = "240000";
                pbAreaCode.ImageLocation = @"Images\三重.png";
            }
            //北陸地方  幅2091　高さ2148
            if (lbAreaCode.SelectedItem.ToString() == "新潟県")
            {
                AreaCode = "150000";
                pbAreaCode.ImageLocation = @"Images\新潟.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "富山県")
            {
                AreaCode = "160000";
                pbAreaCode.ImageLocation = @"Images\富山.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "石川県")
            {
                AreaCode = "170000";
                pbAreaCode.ImageLocation = @"Images\石川.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "福井県")
            {
                AreaCode = "180000";
                pbAreaCode.ImageLocation = @"Images\福井.png";
            }
            //近畿地方  幅2091　高さ2148
            if (lbAreaCode.SelectedItem.ToString() == "滋賀県")
            {
                AreaCode = "250000";
                pbAreaCode.ImageLocation = @"Images\滋賀.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "京都府")
            {
                AreaCode = "260000";
                pbAreaCode.ImageLocation = @"Images\京都.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "大阪府")
            {
                AreaCode = "270000";
                pbAreaCode.ImageLocation = @"Images\大阪.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "兵庫県")
            {
                AreaCode = "280000";
                pbAreaCode.ImageLocation = @"Images\兵庫.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "奈良県")
            {
                AreaCode = "290000";
                pbAreaCode.ImageLocation = @"Images\奈良.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "和歌山県")
            {
                AreaCode = "300000";
                pbAreaCode.ImageLocation = @"Images\和歌山.png";
            }
            //中国地方（山口県を除く）  幅1747　高さ1632
            if (lbAreaCode.SelectedItem.ToString() == "鳥取県")
            {
                AreaCode = "310000";
                pbAreaCode.ImageLocation = @"Images\鳥取.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "島根県")
            {
                AreaCode = "320000";
                pbAreaCode.ImageLocation = @"Images\島根.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "岡山県")
            {
                AreaCode = "330000";
                pbAreaCode.ImageLocation = @"Images\岡山.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "広島県")
            {
                AreaCode = "340000";
                pbAreaCode.ImageLocation = @"Images\広島.png";
            }
            //四国地方
            if (lbAreaCode.SelectedItem.ToString() == "徳島県")
            {
                AreaCode = "360000";
                pbAreaCode.ImageLocation = @"Images\徳島.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "香川県")
            {
                AreaCode = "370000";
                pbAreaCode.ImageLocation = @"Images\香川.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "愛媛県")
            {
                AreaCode = "380000";
                pbAreaCode.ImageLocation = @"Images\愛媛.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "高知県")
            {
                AreaCode = "390000";
                pbAreaCode.ImageLocation = @"Images\高知.png";
            }
            //九州北部地方（山口県を含む）
            if (lbAreaCode.SelectedItem.ToString() == "山口県")
            {
                AreaCode = "350000";
                pbAreaCode.ImageLocation = @"Images\山口.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "福岡県")
            {
                AreaCode = "400000";
                pbAreaCode.ImageLocation = @"Images\福岡.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "佐賀県")
            {
                AreaCode = "410000";
                pbAreaCode.ImageLocation = @"Images\佐賀.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "長崎県")
            {
                AreaCode = "420000";
                pbAreaCode.ImageLocation = @"Images\長崎.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "熊本県")
            {
                AreaCode = "430000";
                pbAreaCode.ImageLocation = @"Images\熊本.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "大分県")
            {
                AreaCode = "440000";
                pbAreaCode.ImageLocation = @"Images\大分.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "宮崎県")
            {
                AreaCode = "450000";
                pbAreaCode.ImageLocation = @"Images\宮崎.png"; 
            }
            if (lbAreaCode.SelectedItem.ToString() == "奄美地方")
            {
                AreaCode = "460040";
                pbAreaCode.ImageLocation = @"Images\九州南部.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "鹿児島県（奄美地方除く）")
            {
                AreaCode = "460100";
                pbAreaCode.ImageLocation = @"Images\鹿児島.png";
            }
            //沖縄地方
            if (lbAreaCode.SelectedItem.ToString() == "沖縄本島地方")
            {
                AreaCode = "471000";
                pbAreaCode.ImageLocation = @"Images\沖縄.png";
            }
            if (lbAreaCode.SelectedItem.ToString() == "大東島地方") { AreaCode = "472000";}
            if (lbAreaCode.SelectedItem.ToString() == "宮古島地方") { AreaCode = "473000";}
            if (lbAreaCode.SelectedItem.ToString() == "八重山地方")
            {
                AreaCode = "474000";
            }

            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            try
            {
                var dStrig = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/forecast/{AreaCode}.json");
                var weathers = JsonConvert.DeserializeObject<Class1[]>(dStrig);

                try
                {
                    WeatherCode = weathers[0].timeSeries[0].areas[0].weatherCodes[0];
                    foreach (var Changing in Change)
                    {
                        if (Changing == WeatherCode)
                        {
                            pbToday.ImageLocation = @"Images\🥺.png";
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        pbToday.ImageLocation = $@"https://www.jma.go.jp/bosai/forecast/img/{WeatherCode}.png";
                    }
                    check = 0;

                    WeatherCode = weathers[0].timeSeries[0].areas[0].weatherCodes[1];

                    foreach (var Changing in Change)
                    {
                        if (Changing == WeatherCode)
                        {
                            pbTomorrow.ImageLocation = @"Images\🥺.png";
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        pbTomorrow.ImageLocation = $@"https://www.jma.go.jp/bosai/forecast/img/{WeatherCode}.png";
                    }
                    check = 0;

                    WeatherCode = weathers[0].timeSeries[0].areas[0].weatherCodes[2];

                    foreach (var Changing in Change)
                    {
                        if (Changing == WeatherCode)
                        {
                            pbDayAfterTomorrow.ImageLocation = @"Images\🥺.png";
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        pbDayAfterTomorrow.ImageLocation = $@"https://www.jma.go.jp/bosai/forecast/img/{WeatherCode}.png";
                    }
                    check = 0;
                }
                catch (Exception)
                {}
            }
            catch (Exception)
            {}
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbAreaCode.Text = null;
            lbAreaCode.Items.Clear();
            pbAreaCode.ImageLocation = @"Images\NIPPON.png";
            pbToday.ImageLocation = @"Images\泣.png";
            pbTomorrow.ImageLocation = @"Images\泣.png";
            pbDayAfterTomorrow.ImageLocation = @"Images\泣.png";
        }
    }
}
