using FinanceControl.API.V1;
using FinanceControl.Application._1._1_Interface;
using FinanceControl.Domain._2._1_Interface;
using FinanceControl.Domain._2._2_Entity;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.V1
{
    [Route("api/[controller]")]
    public class LancamentosController : ApiController
    {
        private readonly ILancamentoService _lancamentoService;
        private readonly IDomainNotificationHandler _notificator;

        public LancamentosController(ILancamentoService lancamentoService,
                                     IDomainNotificationHandler notifications) : base(notifications)
        {
            _lancamentoService = lancamentoService;
            _notificator = notifications;
        }

        [HttpPost("AdicionarLancamento")]
        public IActionResult AdicionarLancamento([FromBody] Lancamento lancamento)
        {
            _lancamentoService.AdicionarLancamento(lancamento);
            if (IsValidOperation())
                return Response(lancamento);

            if (lancamento == null) return NotFound();
            return Response(lancamento);
        }

        [HttpGet("ObterLancamentos")]
        public IActionResult ObterLancamentos([FromQuery] DateTime data)
        {
            var lancamentos = _lancamentoService.ObterLancamentos(data);
            if (IsValidOperation())
                return Response(lancamentos);

            if (lancamentos == null) return NotFound();
            return Response(lancamentos);
        }
    }

    

}
