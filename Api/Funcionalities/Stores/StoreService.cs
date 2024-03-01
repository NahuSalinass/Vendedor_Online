using Api.Persistence;
using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Funcionalities.Stores;

    public interface IStoreService 
    {
        List<Store> GetStores();
        void AgregarVendedor(Guid StoreId, Guid SellerId);
    }
    public class StoreService : IStoreService
    {

        private readonly aplicationDbContext context;
        public StoreService(aplicationDbContext context)
        {
            this.context = context;
        }
        public List<Store> GetStores()
        {
            return context.Stores.Include(x => x.sellers).ToList();
        }

        public void AgregarVendedor(Guid StoreId, Guid SellerId)
        {
            var seller = context.Sellers.FirstOrDefault(x => x.Id == SellerId);

            var store = context.Stores.FirstOrDefault(x => x.Id == StoreId);

            if (seller != null && store != null)
            {
                store.AgregarVendedor(seller);

                context.SaveChanges();
            }
        }

    
}

