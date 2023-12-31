﻿namespace StockMarket_App
{
 /// <summary>
 /// Represents Options pattern for "StockPrice" configuration
 /// </summary>
 public class TradingOptions
 {
  public string? DefaultStockSymbol { get; set; }
  public uint? DefaultOrderQuantity { get; set; }
 }
}
