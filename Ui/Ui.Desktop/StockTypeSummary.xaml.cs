using System.Windows;
using System.Windows.Controls;

namespace tomaszbaginski.UbsTask2.Ui.Desktop
{
    /// <summary>
    /// Interaction logic for StockTypeSummary.xaml
    /// </summary>
    public partial class StockTypeSummary : UserControl
    {
        public StockTypeSummary()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty StockTypeNameProperty = DependencyProperty.Register(
            "StockTypeName", typeof(string), typeof(StockTypeSummary), new PropertyMetadata(default(string)));

        public string StockTypeName
        {
            get { return (string) GetValue(StockTypeNameProperty); }
            set { SetValue(StockTypeNameProperty, value); }
        }

        public static readonly DependencyProperty TotalNumberProperty = DependencyProperty.Register(
            "TotalNumber", typeof(decimal), typeof(StockTypeSummary), new PropertyMetadata(default(decimal)));

        public decimal TotalNumber
        {
            get { return (decimal) GetValue(TotalNumberProperty); }
            set { SetValue(TotalNumberProperty, value); }
        }

        public static readonly DependencyProperty TotalStockWeightProperty = DependencyProperty.Register(
            "TotalStockWeight", typeof(decimal), typeof(StockTypeSummary), new PropertyMetadata(default(decimal)));

        public decimal TotalStockWeight
        {
            get { return (decimal) GetValue(TotalStockWeightProperty); }
            set { SetValue(TotalStockWeightProperty, value); }
        }

        public static readonly DependencyProperty TotalMarketValueProperty = DependencyProperty.Register(
            "TotalMarketValue", typeof(decimal), typeof(StockTypeSummary), new PropertyMetadata(default(decimal)));

        public decimal TotalMarketValue
        {
            get { return (decimal) GetValue(TotalMarketValueProperty); }
            set { SetValue(TotalMarketValueProperty, value); }
        }
    }
}
