namespace FinanceControl.Domain._2._2_Entity
{
    public class Lancamento
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
