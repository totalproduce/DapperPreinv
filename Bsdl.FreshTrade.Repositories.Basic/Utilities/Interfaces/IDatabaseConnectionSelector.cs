namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces
{
    public interface IDatabaseConnectionSelector
    {
        string GetConnectionString(int id);
    }
}
