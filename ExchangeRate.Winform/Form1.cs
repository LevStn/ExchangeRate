using ExchangeRate.BusinessLayer.Interfaces;
using ExchangeRate.BusinessLayer.Services;

namespace ExchangeRate.Winform;

public partial class Form1 : Form
{
    private readonly IEnumerable<IExchangeClient> _exchangeApiClients;

    private readonly IExchangeClient _binance;
    private readonly IExchangeClient _bybit;
    private readonly IExchangeClient _kucoin;

    public Form1(IEnumerable<IExchangeClient> exchangeApiClients)
    {
        _exchangeApiClients = exchangeApiClients;
        _binance = _exchangeApiClients.OfType<BinanceClient>().FirstOrDefault();
        _bybit = _exchangeApiClients.OfType<BybitClient>().FirstOrDefault();
        _kucoin = _exchangeApiClients.OfType<KucoinClient>().FirstOrDefault();


        InitializeComponent();
    }



    private async void timerRefresh_Tick(object sender, EventArgs e)
    {
        await RefreshPrices();
    }

    private async Task RefreshPrices()
    {
        var tasks = new[]
        {
             GetPriceSafely(_binance),
             GetPriceSafely(_bybit),
             GetPriceSafely(_kucoin)
        };

        var prices = await Task.WhenAll(tasks);

        labelBinanceRate.Text = $"{prices[0]}";
        labelBybitRate.Text = $"{prices[1]}";
        labelKucoinRate.Text = $"{prices[2]}";
    }

    private async Task<decimal?> GetPriceSafely(IExchangeClient exchangeService)
    {
        try
        {
            return await exchangeService.GetPrice();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving price: {ex.Message}");
            return null;
        }
    }
}