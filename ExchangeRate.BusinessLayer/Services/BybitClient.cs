using Bybit.Net.Interfaces.Clients;
using ExchangeRate.BusinessLayer.Enums;
using ExchangeRate.BusinessLayer.Interfaces;

namespace ExchangeRate.BusinessLayer.Services;

public class BybitClient : IExchangeClient
{
    private readonly IBybitRestClient _bybitRestClient;

    public BybitClient(IBybitRestClient bybitRestClient)
    {
        _bybitRestClient = bybitRestClient;
    }

    public async Task<decimal?> GetPrice() =>
        (await _bybitRestClient.SpotApiV1.ExchangeData.GetTickerAsync($"{Tickers.BTC}{Tickers.USDT}")).Data.LastPrice;

}

