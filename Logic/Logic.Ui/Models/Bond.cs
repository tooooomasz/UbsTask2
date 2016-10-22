namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public class Bond : Stock
    {
        public override decimal Tolerance => 100000;

        public override decimal TransactionCost => decimal.Multiply(MarketValue, (decimal)0.02);
    }
}
