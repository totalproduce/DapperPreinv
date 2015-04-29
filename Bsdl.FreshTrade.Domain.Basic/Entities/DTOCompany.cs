using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Domain.Basic.Entities
{
    /*  Company Dictionary*/

    [DataContract]
    public class DTOCompany : IDTOCompany
    {
        [DataMember]
        public int No
        {
            get;
            set;
        }

        [DataMember]
        public string Name
        {
            get;
            set;
        }
        #region Constructors
        public DTOCompany() { }

        public DTOCompany(int aNo, string aName)
        {
            No = aNo;
            Name = aName;
        }
        #endregion
    }
}
