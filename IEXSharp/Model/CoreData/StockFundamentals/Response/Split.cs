using System;

namespace IEXSharp.Model.CoreData.StockFundamentals.Response
{
	public class SplitLegacy
	{
		public DateTime exDate { get; set; }
		public DateTime declaredDate { get; set; }
		public DateTime recordDate { get; set; }
		public DateTime paymentDate { get; set; }
		public double ratio { get; set; }
		public int toFactor { get; set; }
		public int forFactor { get; set; }
	}

	public class Split
	{
		public DateTime exDate { get; set; }
		public DateTime declaredDate { get; set; }
		public decimal ratio { get; set; }
		public decimal toFactor { get; set; }
		public decimal fromFactor { get; set; }
		public string description { get; set; }
		public string symbol { get; set; }
	}
}