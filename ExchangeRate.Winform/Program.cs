using ExchangeRate.Winform.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace ExchangeRate.Winform
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            var serviceProvider = ServiceCollectionExtensions.Configure();
            ApplicationConfiguration.Initialize();

            using (var scope = serviceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<Form1>();
                Application.Run(form);
            }
        }
    }
}