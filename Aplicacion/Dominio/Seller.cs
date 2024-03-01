using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Aplicacion.Dominio;

    [Table("Seller")]
    public class Seller
    {

        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public long CUIT {get; private set;  } 

        [Required]
        [StringLength(20)]
        public string name { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string lastname { get; set; } = string.Empty;

        [Required]
        [StringLength(40)]
        public string direction { get; set; } = string.Empty;

        public Users User;

        public Seller()
        {
            
        }
        public Seller(long CUIT, string name, string lastname, string direction, Users user)
        {
            this.CUIT = CUIT;
            this.name = name;
            this.lastname = lastname;
            this.direction = direction;
            User = user;
        }
    }
