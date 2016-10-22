using GalaSoft.MvvmLight;
using tomaszbaginski.UbsTask2.Logic.Ui.Models;

namespace tomaszbaginski.UbsTask2.Logic.Ui
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Fund = new Fund();
        }

        public Fund Fund { get; private set; }
    }
}