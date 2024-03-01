using Aplicacion.Dominio;

namespace Api.Funcionalities.Sellers;
    public class SellerCommandDto
    {
        public required long CUIT {get; set;}
        public required string name {get; set;}
        public required string lastname {get; set;}
        public required string direction {get; set;}
        public required Users user {get; set;}
    }
    
    public class SellerQueryDto
    {
        public Guid Id {get; set;}
        public required long CUIT {get; set;}
        public string name {get; set;} = string.Empty;
        public string lastname {get; set;} = string.Empty;
        public string direction {get; set;} = string.Empty;
        public required Users user {get; set;} 
    }
