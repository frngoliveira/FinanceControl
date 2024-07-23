using FinanceControl.Domain._2._2_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Domain._2._1_Interface
{
    public interface ILancamentoRepository
    {
        void Add(Lancamento lancamento);
        IEnumerable<Lancamento> GetByDate(DateTime date);
    }
}
