using System.Windows.Forms;

namespace CScalpAutoSettings
{
    public partial class MainForm : Form
    {
        public MainModel ViewModel { get; set; } = new MainModel();

        public MainForm()
        {
            InitializeComponent();

            BindUI(nameof(_FSRLauncherFolderPathTextBox.Text), nameof(ViewModel.FSRLauncherPath), _FSRLauncherFolderPathTextBox);
            BindUI(nameof(_serverSideSLTPCheckBox.Checked), nameof(ViewModel.ServerSideSLTP), _serverSideSLTPCheckBox);
            BindUI(nameof(_enableNotificationsCheckBox.Checked), nameof(ViewModel.EnableNotification), _enableNotificationsCheckBox);
            BindUI(nameof(_showRulerCheckBox.Checked), nameof(ViewModel.ShowRuler), _showRulerCheckBox);
            BindUI(nameof(_reduceAmounts.Checked), nameof(ViewModel.ReduceAmounts), _reduceAmounts);
            BindUI(nameof(_reduceAmountsPriceTextBox.Enabled), nameof(ViewModel.ReduceAmounts), _reduceAmountsPriceTextBox);
            BindUI(nameof(_reduceAmountsPriceTextBox.Text), nameof(ViewModel.ReduceAmountsPrice), _reduceAmountsPriceTextBox);
            BindUI(nameof(_decimalPriceChangeFactor.Value), nameof(ViewModel.DecimalPriceChangeFactor), _decimalPriceChangeFactor);
            BindUI(nameof(_maxDecimalPlaces.Value), nameof(ViewModel.MaxDecimalPlaces), _maxDecimalPlaces);

            _profitTypeComboBox.DataSource = MainModel._profitTypes;
            _profitTypeComboBox.DisplayMember = nameof(ProfitType.Label);
            _profitTypeComboBox.ValueMember = nameof(ProfitType.Value);

            BindUI(nameof(_profitTypeComboBox.SelectedItem), nameof(ViewModel.SelectedProfitType), _profitTypeComboBox);

            BindUI(nameof(_applyForSpot.Checked), nameof(ViewModel.ApplyForSpot), _applyForSpot);
            BindUI(nameof(_applyForUSDMFutures.Checked), nameof(ViewModel.ApplyForUSDMFutures), _applyForUSDMFutures);
            BindUI(nameof(_ApplyForCOINMFutures.Checked), nameof(ViewModel.ApplyForCOINMFutures), _ApplyForCOINMFutures);
        }

        private void BindUI(string propertyName, string dataMember, IBindableComponent component)
        {
            component.DataBindings.Add(propertyName, ViewModel, dataMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void _FSRLauncherFolderPathButton_Click(object sender, System.EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ViewModel.FSRLauncherPath = fbd.SelectedPath;
                }
            }
        }

        private void _ApplyButton_Click(object sender, System.EventArgs e)
        {
            ViewModel.Process();
        }
    }
}
