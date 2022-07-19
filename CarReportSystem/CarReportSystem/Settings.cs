using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    //設定情報
    [Serializable]
    public class Settings
    {
        [System.ComponentModel.DisplayName("色設定")]
        public Color MainFormColor { get; set; }
    }
}
