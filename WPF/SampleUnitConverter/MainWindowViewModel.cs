using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    internal class MainWindowViewModel:ViewModel{

        //フィールド
        private double metricValue;
        private double imperiaValue;

        public double MetricValue {
            get => metricValue;
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        private void OnPropertyChanged() {
            
        }

        public double ImperialValue {
            get => imperiaValue;
            set {
                this.imperiaValue = value;
            }
        }

        //プロパティ
    }
}
