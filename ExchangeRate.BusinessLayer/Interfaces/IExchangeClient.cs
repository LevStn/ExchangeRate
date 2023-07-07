namespace ExchangeRate.BusinessLayer.Interfaces;

public interface IExchangeClient
{
    Task<decimal?> GetPrice();
}
