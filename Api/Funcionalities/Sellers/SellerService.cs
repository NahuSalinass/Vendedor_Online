using Api.Persistence;
using Aplicacion.Dominio;

namespace Api.Funcionalities.Sellers;

    public interface ISellerService
    {
    void CreateSeller(SellerCommandDto sellerDto);
    void DeleteSeller(Guid sellerId);

    List<Seller> GetSellers();
    }
        

    public class SellerService : ISellerService
    {
    private readonly aplicationDbContext context;

    public SellerService(aplicationDbContext context)
        {
        this.context = context;
        }
        public List<Seller> GetSellers()
        {
            return context.Sellers.ToList();
        }

        public void CreateSeller(SellerCommandDto sellerDto)
        {
            context.Sellers.Add(new Seller(sellerDto.CUIT, sellerDto.name, sellerDto.lastname, sellerDto.direction, sellerDto.user));
            context.SaveChanges();
        }

        public void DeleteSeller(Guid SellerId)
        {

            var seller = context.Sellers.FirstOrDefault(x => x.Id == SellerId);
        
            if (seller != null)
            {
                context.Sellers.Remove(seller);
                context.SaveChanges();
            }
        }
    }