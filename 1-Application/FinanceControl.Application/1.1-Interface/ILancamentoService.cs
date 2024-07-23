using FinanceControl.Domain._2._2_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Application._1._1_Interface
{
    public interface ILancamentoService
    {
        void AdicionarLancamento(Lancamento lancamento);
        IEnumerable<Lancamento> ObterLancamentos(DateTime data);
    }

    public interface IConsolidacaoService
    {
        decimal ObterSaldoDiario(DateTime data);
    }
}
