using DistanceConverter.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public class MeterConverter : ConverterBase
    {
        protected override double Ratio => 1;

        public override string UnitNume =>"メートル";

        public override bool IsMyUnit(string name)
        {
            return name.ToLower() == "meter" || name == UnitNume;
        }
    }

    public class FeetConverter : ConverterBase
    {
        protected override double Ratio =>0.3048; 

        public override string UnitNume =>"フィート";

        public override bool IsMyUnit(string name)
        {
            return name.ToLower() == "feet" || name == UnitNume;
        }
    }

    public class InchConverter : ConverterBase
    {
        protected override double Ratio => 0.0254; 

        public override string UnitNume => "インチ";

        public override bool IsMyUnit(string name)
        {
            return name.ToLower() == "inch" || name == UnitNume;
        }
    }

    public class YardConverter : ConverterBase
    {
        protected override double Ratio => 0.9144;

        public override string UnitNume => "ヤード";

        public override bool IsMyUnit(string name)
        {
            return name.ToLower() == "yard" || name == UnitNume;
        }
    }

    public class MileConverter : ConverterBase
    {
        protected override double Ratio => 1609.344;

        public override string UnitNume => "マイル";

        public override bool IsMyUnit(string name)
        {
            return name.ToLower() == "mile" || name == UnitNume;
        }
    }

    public class KiloMeterConverter : ConverterBase
    {
        protected override double Ratio => 1000;

        public override string UnitNume => "キロメートル";

        public override bool IsMyUnit(string name)
        {
            return name.ToLower() == "kilometer" || name == UnitNume;
        }
    }
}
