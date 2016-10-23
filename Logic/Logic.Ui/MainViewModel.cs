using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using tomaszbaginski.UbsTask2.Logic.Ui.Models;

namespace tomaszbaginski.UbsTask2.Logic.Ui
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Fund = new Fund();
            AddNewBondCommand = new RelayCommand(() => Fund.AddBond(NewStockPrice, NewStockQuantity));
            AddNewEquityCommand = new RelayCommand(() => Fund.AddEquity(NewStockPrice, NewStockQuantity));
        }

        public Fund Fund { get; }

        public decimal NewStockPrice { get; set; }

        public decimal NewStockQuantity { get; set; }

        public RelayCommand AddNewEquityCommand { get; }

        public RelayCommand AddNewBondCommand { get; }
    }
}