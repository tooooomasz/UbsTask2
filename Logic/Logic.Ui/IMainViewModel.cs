using System.Windows.Input;
using tomaszbaginski.UbsTask2.Logic.Ui.Models;

namespace tomaszbaginski.UbsTask2.Logic.Ui
{
    public interface IMainViewModel
    {
        IFund Fund { get; }

        decimal NewStockPrice { get; set; }

        decimal NewStockQuantity { get; set; }

        ICommand AddNewEquityCommand { get; }

        ICommand AddNewBondCommand { get; }
    }
}