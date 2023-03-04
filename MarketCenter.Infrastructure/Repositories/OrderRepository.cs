using MarketCenter.Application.Contracts.Persistence;
using MarketCenter.Domain.Entities;
using MarketCenter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore; 

namespace MarketCenter.Infrastructure.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(MarketCenterContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Order>> GetOrderByUserName(int accountId)
        {
            var orderList = await _dbContext.Orders
                                    .Where(o => o.AccountId == accountId)
                                    .ToListAsync();
            return orderList;
        }
    }
}
