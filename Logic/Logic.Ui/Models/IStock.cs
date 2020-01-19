namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public interface IStock
    {
        string StockType { get; }

        string Name { get; set; }

        decimal Price { get; set; }

        decimal Quantity { get; set; }

        decimal StockWeight { get; set; }

        decimal TransactionCost { get; }

        decimal Tolerance { get; }

        decimal MarketValue { get; }

        bool IsNotTolerated { get; }
    }
}
