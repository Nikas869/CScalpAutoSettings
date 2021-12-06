using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CScalpAutoSettings
{
    public class MainModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static IList<ProfitType> _profitTypes = new List<ProfitType>(new[] {
            new ProfitType { Value = 0, Label = "Points" },
            new ProfitType { Value = 1, Label = "Points * Amount" },
            new ProfitType { Value = 2, Label = "Percent" },
            });

        private string _FSRLauncherPath = "C:\\Program Files (x86)\\FSR Launcher";
        private bool _serverSideSLTP = true;
        private bool _enableNotifications = true;
        private bool _showRuler = true;
        private bool _reduceAmounts = false;
        private decimal _reduceAmountsPrice = 01.00M;
        private int _decimalPriceChangeFactor = 1;
        private int _maxDecimalPlaces = 4;
        private ProfitType _selectedProfitType = _profitTypes[2];

        private bool _applyForSpot = true;
        private bool _applyForUSDMFutures = true;
        private bool _applyForCOINMFutures = true;

        public string FSRLauncherPath
        {
            get { return _FSRLauncherPath; }
            set
            {
                if (value == _FSRLauncherPath) return;
                _FSRLauncherPath = value;
                OnPropertyChanged(nameof(FSRLauncherPath));
            }
        }

        public bool ServerSideSLTP
        {
            get { return _serverSideSLTP; }
            set
            {
                if (value == _serverSideSLTP) return;
                _serverSideSLTP = value;
                OnPropertyChanged(nameof(ServerSideSLTP));
            }
        }

        public bool EnableNotification
        {
            get { return _enableNotifications; }
            set
            {
                if (value == _enableNotifications) return;
                _enableNotifications = value;
                OnPropertyChanged(nameof(EnableNotification));
            }
        }

        public bool ShowRuler
        {
            get { return _showRuler; }
            set
            {
                if (value == _showRuler) return;
                _showRuler = value;
                OnPropertyChanged(nameof(ShowRuler));
            }
        }

        public bool ReduceAmounts
        {
            get { return _reduceAmounts; }
            set
            {
                if (value == _reduceAmounts) return;
                _reduceAmounts = value;
                OnPropertyChanged(nameof(ReduceAmounts));
            }
        }

        public decimal ReduceAmountsPrice
        {
            get { return _reduceAmountsPrice; }
            set
            {
                if (value == _reduceAmountsPrice) return;
                _reduceAmountsPrice = value;
                OnPropertyChanged(nameof(ReduceAmountsPrice));
            }
        }

        public int DecimalPriceChangeFactor
        {
            get { return _decimalPriceChangeFactor; }
            set
            {
                if (value == _decimalPriceChangeFactor) return;
                _decimalPriceChangeFactor = value;
                OnPropertyChanged(nameof(DecimalPriceChangeFactor));
            }
        }

        public int MaxDecimalPlaces
        {
            get { return _maxDecimalPlaces; }
            set
            {
                if (value == _maxDecimalPlaces) return;
                _maxDecimalPlaces = value;
                OnPropertyChanged(nameof(MaxDecimalPlaces));
            }
        }

        public ProfitType SelectedProfitType
        {
            get { return _selectedProfitType; }
            set
            {
                if (value == _selectedProfitType) return;
                _selectedProfitType = value;
                OnPropertyChanged(nameof(SelectedProfitType));
            }
        }

        public bool ApplyForSpot
        {
            get { return _applyForSpot; }
            set
            {
                if (value == _applyForSpot) return;
                _applyForSpot = value;
                OnPropertyChanged(nameof(ApplyForSpot));
            }
        }

        public bool ApplyForUSDMFutures
        {
            get { return _applyForUSDMFutures; }
            set
            {
                if (value == _applyForUSDMFutures) return;
                _applyForUSDMFutures = value;
                OnPropertyChanged(nameof(ApplyForUSDMFutures));
            }
        }

        public bool ApplyForCOINMFutures
        {
            get { return _applyForCOINMFutures; }
            set
            {
                if (value == _applyForCOINMFutures) return;
                _applyForCOINMFutures = value;
                OnPropertyChanged(nameof(ApplyForCOINMFutures));
            }
        }

        public void Process()
        {
            var success = MainService.Process(this);

            if (success)
            {
                MessageBox.Show("Success");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
