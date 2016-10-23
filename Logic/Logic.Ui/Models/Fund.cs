using System.Collections.ObjectModel;
using System.Linq;

namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public class Fund : BaseModel
    {
        private int _equityCounter;

        private int _bondCounter;

        public Fund()
        {
            Stocks = new ObservableCollection<Stock>();
        }

        public ObservableCollection<Stock> Stocks { get; }

        public void AddEquity(decimal price, decimal quantity)
        {
            var equityName = nameof(Equity) + ++_equityCounter;
            var newEquity = new Equity(equityName, price, quantity);
            Stocks.Add(newEquity);
            ResetStockWeights();
            UpdateTotalProperties();
        }

        public void AddBond(decimal price, decimal quantity)
        {
            var bondName = nameof(Bond) + ++_bondCounter;
            var newBond = new Bond(bondName, price, quantity);
            Stocks.Add(newBond);
            ResetStockWeights();
            UpdateTotalProperties();
        }

        private void ResetStockWeights()
        {
            var totalMarketValue = TotalMarketValue;
            foreach (var stock in Stocks)
            {
                if (totalMarketValue > 0)
                    stock.StockWeight = stock.MarketValue/totalMarketValue;
                else
                    stock.StockWeight = 0;
            }
        }

        private void UpdateTotalProperties()
        {
            OnPropertyChanged(nameof(TotalNumber));
            OnPropertyChanged(nameof(TotalMarketValue));
            OnPropertyChanged(nameof(TotalStockWeight));
            OnPropertyChanged(nameof(TotalNumberOfEquities));
            OnPropertyChanged(nameof(TotalMarketValueOfEquities));
            OnPropertyChanged(nameof(TotalStockWeightOfEquities));
            OnPropertyChanged(nameof(TotalNumberOfBonds));
            OnPropertyChanged(nameof(TotalMarketValueOfBonds));
            OnPropertyChanged(nameof(TotalStockWeightOfBonds));
        }

        public decimal TotalMarketValue => Stocks.Sum(s => s.MarketValue);

        public decimal TotalMarketValueOfEquities => Stocks.OfType<Equity>().Sum(s => s.MarketValue);

        public decimal TotalMarketValueOfBonds => Stocks.OfType<Bond>().Sum(s => s.MarketValue);

        public int TotalNumber => Stocks.Count();

        public int TotalNumberOfEquities => Stocks.OfType<Equity>().Count();

        public int TotalNumberOfBonds => Stocks.OfType<Bond>().Count();

        public decimal TotalStockWeight => Stocks.Sum(s => s.StockWeight);

        public decimal TotalStockWeightOfEquities => Stocks.OfType<Equity>().Sum(s => s.StockWeight);

        public decimal TotalStockWeightOfBonds => Stocks.OfType<Bond>().Sum(s => s.StockWeight);
    }
}
