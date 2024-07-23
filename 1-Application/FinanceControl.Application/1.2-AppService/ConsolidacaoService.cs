using FinanceControl.Application._1._1_Interface;
using FinanceControl.Domain._2._1_Interface;
using FinanceControl.Domain._2._2_Entity;

namespace FinanceControl.Application._1._2_AppService
{
    public class ConsolidacaoService : IConsolidacaoService
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public ConsolidacaoService(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }

        public decimal ObterSaldoDiario(DateTime data)
        {
            var lancamentos = _lancamentoRepository.GetByDate(data);
            decimal saldo = 0;

            foreach (var lancamento in lancamentos)
            {
                if (lancamento.Tipo == TipoLancamento.Credito)
                    saldo += lancamento.Valor;
                else
                    saldo -= lancamento.Valor;
            }

            return saldo;
        }
    }
}
