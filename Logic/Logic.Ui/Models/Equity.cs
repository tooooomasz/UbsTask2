namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public class Equity : Stock
    {
        public override decimal Tolerance => 200000;

        public override decimal TransactionCost => decimal.Multiply(MarketValue, (decimal)0.005);
    }
}
