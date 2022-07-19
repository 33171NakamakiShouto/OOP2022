using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    [Serializable]
    public class CarReport
    {
        [System.ComponentModel.DisplayName("日付")]
        public DateTime Registration { get; set; }

        [System.ComponentModel.DisplayName("記録者")]
        public string Recorder { get; set; }

        [System.ComponentModel.DisplayName("メーカー")]
        public MakerType Maker { get; set; }

        [System.ComponentModel.DisplayName("車名")]
        public string CarName { get; set; }

        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; }

        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }


        public enum MakerType
        {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他,
        }
    }
}
