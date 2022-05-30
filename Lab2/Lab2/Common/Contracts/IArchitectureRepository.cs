using Lab2.Models;
using System.Collections.Generic;

namespace Lab2.Common.Contracts
{
    public interface IArchitectureRepository
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Artist> GetArtists();
        IEnumerable<FinalOrder> GetOrder();

        void AddOrders(Order order);
        void AddArtists(Artist artist);
        void AddOrder(FinalOrder order);
    }
}
