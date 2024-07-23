using AutoMapper;
using FinanceControl.Application._1._3_ViewModels;
using FinanceControl.Domain._2._2_Entity;

namespace FinanceControl.Application._1._4_SeedWork
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Lancamento, LancamentoViewModel>();
        }
    }
}
