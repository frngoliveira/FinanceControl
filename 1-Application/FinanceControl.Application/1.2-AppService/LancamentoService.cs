using FinanceControl.Application._1._1_Interface;
using FinanceControl.Domain._2._1_Interface;
using FinanceControl.Domain._2._2_Entity;

namespace FinanceControl.Application._1._2_AppService
{
    public class LancamentoService : ILancamentoService
    {
        private readonly ILancamentoRepository _lancamentoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LancamentoService(ILancamentoRepository lancamentoRepository, IUnitOfWork unitOfWork)
        {
            _lancamentoRepository = lancamentoRepository;
            _unitOfWork = unitOfWork;
        }

        public void AdicionarLancamento(Lancamento lancamento)
        {
            _lancamentoRepository.Add(lancamento);
            _unitOfWork.Commit();
        }

        public IEnumerable<Lancamento> ObterLancamentos(DateTime data)
        {
            return _lancamentoRepository.GetByDate(data);
        }
    }

   
}
