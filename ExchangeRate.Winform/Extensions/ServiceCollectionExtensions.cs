using Binance.Net;
using Bybit.Net;
using ExchangeRate.BusinessLayer.Interfaces;
using ExchangeRate.BusinessLayer.Services;
using Kucoin.Net;
using Microsoft.Extensions.DependencyInjection;

namespace ExchangeRate.Winform.Extensions;

public class ServiceCollectionExtensions
{
    public static ServiceProvider Configure()
    {
        var services = new ServiceCollection();

        services.AddScoped<IExchangeClient, BinanceClient>();
        services.AddScoped<IExchangeClient, KucoinClient>();
        services.AddScoped<IExchangeClient, BybitClient>();
        services.AddBinance();
        services.AddKucoin();
        services.AddBybit();

        services.AddTransient<Form1>();

        return services.BuildServiceProvider();
    }
}