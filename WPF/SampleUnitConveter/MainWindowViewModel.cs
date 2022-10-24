using SampleUnitConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter
{
    public class MainWindowViewModel : ViewModel
    {
        private double metricValue, imperiaValue;

        public double MetricValue
        {
            get { return this.metricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double ImperiaValue
        {
            get { return this.imperiaValue; }
            set
            {
                this.imperiaValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値(単位)
        public MetricUnit CurrentMetricUnit { get; set; }

        //下のComboBoxで選択されている値(単位)
        public ImperuaUnit CurrentImperiaUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        public MainWindowViewModel()
        {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperiaUnit = ImperuaUnit.Units.First();

            this.MetricToImperialUnit = new DelegateCommand(
                () => this.ImperiaValue = this.CurrentImperiaUnit.FromMetricUnit(
                    this.CurrentMetricUnit, this.MetricValue));

            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromImperiaUnit(
                    this.CurrentImperiaUnit, this.ImperiaValue));
        }
    }
}
