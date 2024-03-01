using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;


    [Table("Store")]
    public class Store
    {

        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(20)]
        public string name { get; set; } = string.Empty;

        public List<Seller> sellers {get; set; } = new List<Seller>();

        public List<Publications> publications {get; set; } = new List<Publications>();

        public Store(string name)
       {
            this.name = name;
       }

       public void AgregarVendedor(Seller seller)
       {
         sellers.Add(seller);
       }
    
    }
        