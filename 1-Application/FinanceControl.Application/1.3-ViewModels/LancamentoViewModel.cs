namespace FinanceControl.Application._1._3_ViewModels
{
    public class LancamentoViewModel
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public TipoLancamento Tipo { get; set; }
    }
    public enum TipoLancamento
    {
        Debito,
        Credito
    }
}
