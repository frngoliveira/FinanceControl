using FinanceControl.Application._1._1_Interface;
using FinanceControl.Infra._3._1_Context;

namespace FinanceControl.Application._1._2_AppService
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FinanceControlContext _context;

        public UnitOfWork(FinanceControlContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
