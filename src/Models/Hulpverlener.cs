using System.ComponentModel.DataAnnotations;

namespace src.Models{
    public class Hulpverlener{
        [Key]
        public string Id{get;set;}
        public string naam{get;set;}
        public string achternaam{get;set;}
        public string specialiteit{get;set;}
        public string beschrijving{get;set;}
        public string imagePath{get;set;}
    }
}