using GalaSoft.MvvmLight;

namespace tomaszbaginski.UbsTask2.Logic.Ui
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            WindowTitle = "dupa";
        }

        public string WindowTitle { get; private set; }
    }
}