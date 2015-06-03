
namespace Bsdl.FreshTrade.Domain.Account.Entities
{
    public class DTOCustomerGroup
    {
        public int Id { get; set; } /*Csgrecno*/

        public string Description { get; set; }

        public int CustomerCount { get; set; }

        public int Type { get; set; }

        public short ContainerNo { get; set; }

        public int AccountCount { get; set; }
    }
}
