using System.Collections.Generic;

namespace tomaszbaginski.UbsTask2.Logic.Ui.Models
{
    public interface IFund
    {
        IList<Stock> Stocks { get; }

        void AddEquity(decimal price, decimal quantity);

        void AddBond(decimal price, decimal quantity);

        decimal TotalMarketValue { get; }

        decimal TotalMarketValueOfEquities { get; }

        decimal TotalMarketValueOfBonds { get; }

        int TotalNumber { get; }

        int TotalNumberOfEquities { get; }

        int TotalNumberOfBonds { get; }

        decimal TotalStockWeight { get; }

        decimal TotalStockWeightOfEquities { get; }

        decimal TotalStockWeightOfBonds { get; }
    }
}
