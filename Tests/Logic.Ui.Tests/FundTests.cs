using System.Linq;
using NUnit.Framework;
using tomaszbaginski.UbsTask2.Logic.Ui.Models;

namespace tomaszbaginski.UbsTask2.Logic.Ui.Tests
{
    [TestFixture]
    public class FundTests
    {
        [Test]
        public void ShouldNameNewAddedBonds()
        {
            var fund = new Fund();
            fund.AddBond(100, 100);
            var bond1 = fund.Stocks.LastOrDefault();
            Assert.AreEqual(bond1.Name, "Bond1");
            fund.AddBond(200, 200);
            var bond2 = fund.Stocks.LastOrDefault();
            Assert.AreEqual(bond2.Name, "Bond2");
        }

        [Test]
        public void ShouldNameNewAddedEquities()
        {
            var fund = new Fund();
            fund.AddEquity(100, 100);
            var equity1 = fund.Stocks.LastOrDefault();
            Assert.AreEqual(equity1.Name, "Equity1");
            fund.AddEquity(100, 100);
            var equity2 = fund.Stocks.LastOrDefault();
            Assert.AreEqual(equity2.Name, "Equity2");
        }

        [Test]
        public void ShouldCalculateStockWeight()
        {
            var fund = new Fund();
            fund.AddBond(20, 10);
            var bond1 = fund.Stocks.LastOrDefault();
            Assert.AreEqual(bond1.StockWeight, 1);
            fund.AddBond(30, 10);
            var bond2 = fund.Stocks.LastOrDefault();
            Assert.AreEqual(bond1.StockWeight, 0.4);
            Assert.AreEqual(bond2.StockWeight, 0.60);
            fund.AddEquity(50, 10);
            var equity1 = fund.Stocks.LastOrDefault();
            Assert.AreEqual(bond1.StockWeight, 0.20);
            Assert.AreEqual(bond2.StockWeight, 0.30);
            Assert.AreEqual(equity1.StockWeight, 0.50);
        }

        [Test]
        public void ShouldCalculateTotalMarketValue()
        {
            var fund = new Fund();
            fund.AddBond(20, 10);
            Assert.AreEqual(fund.TotalMarketValue, 200);
            fund.AddBond(30, 10);
            Assert.AreEqual(fund.TotalMarketValue, 500);
            fund.AddEquity(50, 10);
            Assert.AreEqual(fund.TotalMarketValue, 1000);
        }

        [Test]
        public void ShouldCalculateTotalMarketValueOfEquities()
        {
            var fund = new Fund();
            fund.AddEquity(20, 10);
            Assert.AreEqual(fund.TotalMarketValueOfEquities, 200);
            fund.AddEquity(30, 10);
            Assert.AreEqual(fund.TotalMarketValueOfEquities, 500);
            fund.AddBond(50, 10);
            Assert.AreEqual(fund.TotalMarketValueOfEquities, 500);
        }

        [Test]
        public void ShouldCalculateTotalMarketValueOfBonds()
        {
            var fund = new Fund();
            fund.AddBond(20, 10);
            Assert.AreEqual(fund.TotalMarketValueOfBonds, 200);
            fund.AddBond(30, 10);
            Assert.AreEqual(fund.TotalMarketValueOfBonds, 500);
            fund.AddEquity(50, 10);
            Assert.AreEqual(fund.TotalMarketValueOfBonds, 500);
        }

        [Test]
        public void ShouldGetTotalNumber()
        {
            var fund = new Fund();
            Assert.AreEqual(fund.TotalNumber, 0);
            fund.AddBond(20, 10);
            Assert.AreEqual(fund.TotalNumber, 1);
            fund.AddBond(30, 10);
            Assert.AreEqual(fund.TotalNumber, 2);
            fund.AddEquity(50, 10);
            Assert.AreEqual(fund.TotalNumber, 3);
        }

        [Test]
        public void ShouldGetTotalNumberOfEquities()
        {
            var fund = new Fund();
            Assert.AreEqual(fund.TotalNumberOfEquities, 0);
            fund.AddEquity(20, 10);
            Assert.AreEqual(fund.TotalNumberOfEquities, 1);
            fund.AddEquity(30, 10);
            Assert.AreEqual(fund.TotalNumberOfEquities, 2);
            fund.AddBond(50, 10);
            Assert.AreEqual(fund.TotalNumberOfEquities, 2);
        }

        [Test]
        public void ShouldGetTotalNumberOfBonds()
        {
            var fund = new Fund();
            Assert.AreEqual(fund.TotalNumberOfBonds, 0);
            fund.AddBond(20, 10);
            Assert.AreEqual(fund.TotalNumberOfBonds, 1);
            fund.AddBond(30, 10);
            Assert.AreEqual(fund.TotalNumberOfBonds, 2);
            fund.AddEquity(50, 10);
            Assert.AreEqual(fund.TotalNumberOfBonds, 2);
        }

        [Test]
        public void ShouldGetTotalStockWeight()
        {
            var fund = new Fund();
            Assert.AreEqual(fund.TotalStockWeight, 0);
            fund.AddBond(20, 10);
            Assert.AreEqual(fund.TotalStockWeight, 1);
            fund.AddBond(30, 10);
            Assert.AreEqual(fund.TotalStockWeight, 1);
            fund.AddEquity(50, 10);
            Assert.AreEqual(fund.TotalStockWeight, 1);
        }

        [Test]
        public void ShouldGetTotalStockWeightOfEquities()
        {
            var fund = new Fund();
            Assert.AreEqual(fund.TotalStockWeightOfEquities, 0);
            fund.AddBond(20, 10);
            Assert.AreEqual(fund.TotalStockWeightOfEquities, 0);
            fund.AddBond(30, 10);
            Assert.AreEqual(fund.TotalStockWeightOfEquities, 0);
            fund.AddEquity(50, 10);
            Assert.AreEqual(fund.TotalStockWeightOfEquities, 0.50);
        }

        [Test]
        public void ShouldGetTotalStockWeightOfBonds()
        {
            var fund = new Fund();
            Assert.AreEqual(fund.TotalStockWeightOfBonds, 0);
            fund.AddBond(20, 10);
            Assert.AreEqual(fund.TotalStockWeightOfBonds, 1);
            fund.AddBond(30, 10);
            Assert.AreEqual(fund.TotalStockWeightOfBonds, 1);
            fund.AddEquity(50, 10);
            Assert.AreEqual(fund.TotalStockWeightOfBonds, 0.50);
        }
    }
}