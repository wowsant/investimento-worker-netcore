namespace Investimento.Worker.Models;

public class CotacaoModel
{
    public Result[] Results { get; set; }
    public DateTime RequestedAt { get; set; }
    public string Took { get; set; }
}

public class Result
{
    public string Currency { get; set; }
    public string ShortName { get; set; }
    public string LongName { get; set; }
    public double RegularMarketChange { get; set; }
    public double RegularMarketChangePercent { get; set; }
    public DateTime RegularMarketTime { get; set; }
    public double RegularMarketPrice { get; set; }
    public double RegularMarketDayHigh { get; set; }
    public string RegularMarketDayRange { get; set; }
    public double RegularMarketDayLow { get; set; }
    public long RegularMarketVolume { get; set; }
    public double RegularMarketPreviousClose { get; set; }
    public double RegularMarketOpen { get; set; }
    public string FiftyTwoWeekRange { get; set; }
    public double FiftyTwoWeekLow { get; set; }
    public double FiftyTwoWeekHigh { get; set; }
    public string Symbol { get; set; }
    public double PriceEarnings { get; set; }
    public double EarningsPerShare { get; set; }
    public string LogoUrl { get; set; }
}
