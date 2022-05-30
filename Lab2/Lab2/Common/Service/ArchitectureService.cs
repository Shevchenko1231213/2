using Lab2.Common.Contracts;
using Lab2.Data;
using Lab2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Common.Service
{
    public class ArchitectureService : IArchitectureRepository
    {
        private readonly ArchitectureDesignDbContext _dbContext;

        public ArchitectureService(ArchitectureDesignDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddArtists(Artist artist)
        {
            var artistDto = new Artist
            {
                Id = artist.Id,
                Name = artist.Name,
                LastName = artist.LastName,
                DateOfBirth = artist.DateOfBirth,
                Experience = artist.Experience
            };

            _dbContext.Artists.Add(artistDto);
            _dbContext.SaveChanges();
        }

        public void AddOrder(FinalOrder order)
        {
            var ordertDto = new FinalOrder
            {
                Id = order.Id,
                OrderId = order.OrderId,
                ArtistId = order.ArtistId
            };

            _dbContext.FinalOrders.Add(ordertDto);
            _dbContext.SaveChanges();
        }

        public void AddOrders(Order order)
        {
            var ordertDto = new Order
            {
                Id = order.Id,
                Theme = order.Theme,
                Description = order.Description
            };

            _dbContext.Orders.Add(ordertDto);
            _dbContext.SaveChanges();
        }

        public IEnumerable<FinalOrder> GetOrder()
        {
            return _dbContext.FinalOrders.ToList();
        }

        public IEnumerable<Artist> GetArtists()
        {
            return _dbContext.Artists.ToList();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _dbContext.Orders.ToList();
        }
    }
}
