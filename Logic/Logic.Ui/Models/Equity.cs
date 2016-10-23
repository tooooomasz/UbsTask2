namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public class Equity : Stock
    {
        public Equity(string name, decimal price, decimal quantity) 
            : base(name, price, quantity)
        {
        }

        public override string StockType => nameof(Equity);

        public override decimal Tolerance => 200000;

        public override decimal TransactionCost => decimal.Multiply(MarketValue, (decimal)0.005);
    }
}
