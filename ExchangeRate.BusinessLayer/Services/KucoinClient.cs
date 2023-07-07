using ExchangeRate.BusinessLayer.Enums;
using ExchangeRate.BusinessLayer.Interfaces;
using Kucoin.Net.Interfaces.Clients;

namespace ExchangeRate.BusinessLayer.Services;

public class KucoinClient : IExchangeClient
{
    private readonly IKucoinRestClient _kucoinRestClient;
    public KucoinClient(IKucoinRestClient kucoinRestClient)
    {
        _kucoinRestClient = kucoinRestClient;
    }


    public async Task<decimal?> GetPrice() =>
        (await _kucoinRestClient.SpotApi.ExchangeData.GetTickerAsync($"{Tickers.BTC}-{Tickers.USDT}")).Data.LastPrice;
}

