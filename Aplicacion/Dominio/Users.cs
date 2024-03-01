namespace Aplicacion.Dominio;

    public class Users
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 
        
        public string username { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public Users()
        {
            
        }

        public Users(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
    }

