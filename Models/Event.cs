using System.Collections.Generic;

namespace TeachApi.Models
{
    public class Event {
        public int ID {get; set; }
        public string Name {get;set;}
        
        public List<Photo> Photos {get;set;}

    }

}