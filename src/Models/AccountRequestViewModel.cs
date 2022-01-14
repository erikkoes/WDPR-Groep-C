
using System.ComponentModel.DataAnnotations;
namespace src.Models{
    public class AccountRequestViewModel{
        [EmailAddress]
        public string userEmail {get;set;}
        public string userName {get;set;}
        public string DateOfBirth{get;set;}
        public string CaregiverId {get;set;}
        public string description {get;set;}
        public string parentId{get;set;}
        
        
    }
}