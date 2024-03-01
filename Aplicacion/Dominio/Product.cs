using Aplicacion.Dominio;

namespace Aplicacion.Dominio
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 

        public string name { get; set; } = string.Empty;

        public float price { get; private set; }

        public List<Categories> Category {get; set; } = new List<Categories>();

        public int stock {get; private set; }

        protected string URLImage {get; set; } = string.Empty;
        
    }
}
