namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public abstract class Stock : BaseModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name)
                    return;
                _name = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public abstract decimal TransactionCost { get; }

        public abstract decimal Tolerance { get; }

        public decimal MarketValue => Price * Quantity;

        public bool IsTolerated => MarketValue < 0 || TransactionCost > Tolerance;
    }
}
