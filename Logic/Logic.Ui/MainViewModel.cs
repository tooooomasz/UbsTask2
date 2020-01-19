using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using tomaszbaginski.UbsTask2.Logic.Ui.Models;

namespace tomaszbaginski.UbsTask2.Logic.Ui
{

    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        public MainViewModel(IFund fund)
        {
            Fund = fund;
            AddNewBondCommand = new RelayCommand(() => Fund.AddBond(NewStockPrice, NewStockQuantity));
            AddNewEquityCommand = new RelayCommand(() => Fund.AddEquity(NewStockPrice, NewStockQuantity));
        }

        public IFund Fund { get; }

        public decimal NewStockPrice { get; set; }

        public decimal NewStockQuantity { get; set; }

        public ICommand AddNewEquityCommand { get; }

        public ICommand AddNewBondCommand { get; }
    }
}