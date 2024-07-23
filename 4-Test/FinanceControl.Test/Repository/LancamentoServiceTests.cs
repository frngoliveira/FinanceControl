using FinanceControl.Application._1._1_Interface;
using FinanceControl.Application._1._2_AppService;
using FinanceControl.Domain._2._1_Interface;
using FinanceControl.Domain._2._2_Entity;
using Moq;

namespace FinanceControl.Tests.Repository
{
    public class LancamentoServiceTests
    {
        private readonly ILancamentoService _lancamentoService;
        private readonly Mock<ILancamentoRepository> _lancamentoRepositoryMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public LancamentoServiceTests()
        {
            _lancamentoRepositoryMock = new Mock<ILancamentoRepository>();
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _lancamentoService = new LancamentoService(_lancamentoRepositoryMock.Object,
                                                       _unitOfWorkMock.Object);
        }

        [Fact]
        public void AdicionarLancamento_DeveAdicionarLancamento()
        {
            var lancamento = new Lancamento { Id = Guid.NewGuid(), Valor = 100, Data = DateTime.Today, Tipo = TipoLancamento.Credito };

            _lancamentoService.AdicionarLancamento(lancamento);

            _lancamentoRepositoryMock.Verify(r => r.Add(It.IsAny<Lancamento>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
        }

        [Fact]
        public void ObterLancamentos_DeveRetornarLancamentosPorData()
        {
            var data = DateTime.Today;
            var lancamentos = new List<Lancamento>
        {
            new Lancamento { Id = Guid.NewGuid(), Valor = 100, Data = data, Tipo = TipoLancamento.Credito }
        };
            _lancamentoRepositoryMock.Setup(r => r.GetByDate(data)).Returns(lancamentos);

            var result = _lancamentoService.ObterLancamentos(data);

            Assert.Equal(lancamentos, result);
        }
    }

}
