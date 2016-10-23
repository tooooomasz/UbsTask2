namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public class Bond : Stock
    {
        public Bond(string name, decimal price, decimal quantity) 
            : base(name, price, quantity)
        {
        }

        public override string StockType => nameof(Bond);

        public override decimal Tolerance => 100000;

        public override decimal TransactionCost => decimal.Multiply(MarketValue, (decimal)0.02);
    }
}
