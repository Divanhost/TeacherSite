namespace TeachApi.Models
{
    public class User {
        public int ID {get; set; }
        public string Login {get;set;}
        public string Password {get;set;}
        public int ALevel {get;set;}
        public bool IsApproved {get;set;}
    }

}