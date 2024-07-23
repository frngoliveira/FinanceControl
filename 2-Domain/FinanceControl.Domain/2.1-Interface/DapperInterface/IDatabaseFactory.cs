using System.Data;

namespace FinanceControl.Domain._2._1_Interface.DapperInterface
{
    public interface IDatabaseFactory
    {
        IDbConnection GetDbConnection { get; }
    }
}
