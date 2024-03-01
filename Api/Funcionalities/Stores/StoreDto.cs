using Aplicacion.Dominio;

namespace Api.Funcionalities.Stores
{
    public class StoreCommandDto
    {
        public required string name {get; set;}
        public required List<Seller> sellers {get; set;} = new List<Seller>();
        public required List<Publications> publications {get; set;} = new List<Publications>();

    }
}