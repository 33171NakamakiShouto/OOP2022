using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Framework
{
    public abstract class ConverterBase
    {
        public abstract bool IsMyUnit(string name);

        protected abstract double Ratio { get; }

        public abstract string UnitNume { get; }

        public double FromMeter(double meter)
        {
            return meter / Ratio;
        }

        public double ToMeter(double feet)
        {
            return feet * Ratio;
        }
    }
}
