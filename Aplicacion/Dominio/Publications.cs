namespace Aplicacion.Dominio;

    public class Publications
    {
        public Guid id { get; set; } = Guid.NewGuid();

        public Boolean visibility {get; private set; }
        
        public List<Product> products {get; set; } = new List<Product>();
    }