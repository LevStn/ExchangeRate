using Binance.Net.Interfaces.Clients;
using ExchangeRate.BusinessLayer.Enums;
using ExchangeRate.BusinessLayer.Interfaces;

namespace ExchangeRate.BusinessLayer.Services;

public class BinanceClient : IExchangeClient
{
    private readonly IBinanceRestClient _binanceRestClient;
    public BinanceClient(IBinanceRestClient binanceRestClient)
    {
        _binanceRestClient = binanceRestClient;
    }

    public async Task<decimal?> GetPrice() =>
        (await _binanceRestClient.SpotApi.ExchangeData.GetPriceAsync($"{Tickers.BTC}{Tickers.USDT}")).Data.Price;

}


