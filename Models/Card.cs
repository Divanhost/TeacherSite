using System.Collections.Generic;

namespace TeachApi.Models
{
    public class Card {
        public int ID {get; set; }
        public string Name {get;set;}
        public string Image {get;set;}
        public string InnerImage {get;set;}
        public string InnerText {get;set;}
        public List<Document> Documents {get;set;}
        public int? HostCardId {get;set;}

    }

}