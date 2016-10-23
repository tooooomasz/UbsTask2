namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public abstract class Stock : BaseModel
    {
        protected Stock(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public abstract string StockType { get; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name)
                    return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value == _price)
                    return;
                _price = value;
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(MarketValue));
                OnPropertyChanged(nameof(TransactionCost));
                OnPropertyChanged(nameof(IsNotTolerated));
            }
        }

        private decimal _quantity;

        public decimal Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value == _quantity)
                    return;
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
                OnPropertyChanged(nameof(MarketValue));
                OnPropertyChanged(nameof(TransactionCost));
                OnPropertyChanged(nameof(IsNotTolerated));
            }
        }

        private decimal _stockWeight;

        public decimal StockWeight
        {
            get { return _stockWeight; }
            set
            {
                if (value == _stockWeight)
                    return;
                _stockWeight = value;
                OnPropertyChanged(nameof(StockWeight));
            }
        }

        public abstract decimal TransactionCost { get; }

        public abstract decimal Tolerance { get; }

        public decimal MarketValue => Price * Quantity;

        public bool IsNotTolerated => MarketValue < 0 || TransactionCost > Tolerance;
    }
}
