using System.Runtime.Serialization;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Domain.Basic.Entities
{

    [DataContract]
    public class DTOUser : IDTOUser
    {
        public DTOUser()
        {
        }

        public DTOUser(int id, string userName, string name, int languageNumber, bool active, bool allSalesOffices)
        {
            this.Id = id;
            this.UserName = userName;
            this.Name = name;
            this.LanguageNumber = languageNumber;
            this.Active = active;
            this.AllSalesOffices = allSalesOffices;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int LanguageNumber { get; set; }

        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        public bool AllSalesOffices { get; set; }
    }
}
