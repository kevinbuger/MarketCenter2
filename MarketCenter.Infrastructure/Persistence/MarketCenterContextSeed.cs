using MarketCenter.Domain.Entities;
using Microsoft.Extensions.Logging; 

namespace MarketCenter.Infrastructure.Persistence
{
    public class MarketCenterContextSeed
    {
        public static async Task SeedAsync(MarketCenterContext marketCenterContext, ILogger<MarketCenterContextSeed> logger)
        {
            if (!marketCenterContext.Orders.Any())
            {
                marketCenterContext.Orders.AddRange(GetPreconfiguredOrders());
                await marketCenterContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(MarketCenterContext).Name);

            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order() { 
                    AccountId = 1,
                    CVV="3445",
                    CardName = "4545-3234-3423-3423",
                    PaymentMethod="Online", 
                    Expiration = DateTime.Now.AddYears(2).ToString(),
                    TotalPrice = 350 }
            };
        }
    }
}
