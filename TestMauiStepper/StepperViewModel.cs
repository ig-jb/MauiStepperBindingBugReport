using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestMauiStepper
{
    public class StepperViewModel : INotifyPropertyChanged
    {
        public StepperViewModel()
        {
            _Min = 1;
            _Max = 105;
            _Value = 102;
        }

        private double _Min;
        private double _Max;
        private double _Value;

        public event PropertyChangedEventHandler PropertyChanged;


        public double Min
        {
            get => _Min;
            set
            {
                if (_Min != value)
                {
                    _Min = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Max
        {
            get => _Max;
            set
            {
                if (_Max != value)
                {
                    _Max = value;
                    OnPropertyChanged();
                }
            }
        }


        public double Value
        {
            get => _Value;
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    OnPropertyChanged();
                }
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
