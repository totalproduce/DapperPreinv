
namespace Bsdl.FreshTrade.Repositories.PreInv.DBModel
{
    class InvExtractHedEx: InvExtractHed
    {
        private string _fLogonName;
        public string LogonName
        {
            get { return _fLogonName; }
            set
            {
                if (_fLogonName != value)
                {
                    Modify();
                    _fLogonName = value;
                }
            }
        }
    }
}
