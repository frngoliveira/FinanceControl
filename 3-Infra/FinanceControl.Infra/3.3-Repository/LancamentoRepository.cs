using FinanceControl.Domain._2._1_Interface;
using FinanceControl.Domain._2._2_Entity;
using FinanceControl.Infra._3._1_Context;

namespace FinanceControl.Infrastructure._3._3_Repository
{
    public class LancamentoRepository : ILancamentoRepository
    {        
        protected readonly FinanceControlContext _context;

        public LancamentoRepository(FinanceControlContext context)
        {
            _context = context;
        }

        public void Add(Lancamento lancamento)
        {
            //_lancamentos.Add(lancamento);
            _context.Add(lancamento);
        }

        public IEnumerable<Lancamento> GetByDate(DateTime date)
        {
            return _context.Lancamento.Where(l => l.Data.Date == date.Date).ToList();
        }

    }
}
