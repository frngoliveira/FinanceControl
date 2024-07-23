
using FinanceControl.API.V1;
using FinanceControl.Application._1._1_Interface;
using FinanceControl.Domain._2._1_Interface;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.V1
{    
    [Route("api/[controller]")]
    public class ConsolidacaoController : ApiController
    {
        private readonly IConsolidacaoService _consolidacaoService;
        private readonly IDomainNotificationHandler _notificator;

        public ConsolidacaoController(IConsolidacaoService consolidacaoService,
                                      IDomainNotificationHandler notifications) : base(notifications)
        {
            _consolidacaoService = consolidacaoService;
            _notificator = notifications;
        }

        [HttpGet("ObterSaldoDiario")]
        public IActionResult ObterSaldoDiario([FromQuery] DateTime data)
        {
            var saldo = _consolidacaoService.ObterSaldoDiario(data);
            
            return Response(saldo);
        }
    }
}
