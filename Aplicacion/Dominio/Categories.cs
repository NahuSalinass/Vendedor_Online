namespace Aplicacion.Dominio
{
    public class Categories
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 
        
        public string name { get; set; } = string.Empty;
        
    }
}