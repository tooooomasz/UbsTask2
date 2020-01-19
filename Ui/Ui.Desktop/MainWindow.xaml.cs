using System;
using System.Windows;
using tomaszbaginski.UbsTask2.Logic.Ui;

namespace tomaszbaginski.UbsTask2.Ui.Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow(IRelationViewModel context)
        {
            InitializeComponent();
            this.DataContext = context.Get();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}
