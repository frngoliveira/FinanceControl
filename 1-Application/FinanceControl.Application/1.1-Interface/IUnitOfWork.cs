using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Application._1._1_Interface
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
