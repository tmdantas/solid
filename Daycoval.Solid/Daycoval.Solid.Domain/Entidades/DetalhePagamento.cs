namespace Daycoval.Solid.Domain.Entidades
{
    public class DetalhePagamento
    {
        public FormaPagamento FormaPagamento { get; set; }
        public string NumeroCartao { get; set; }
        public int MesExpiracao { get; set; }
        public int AnoExpiracao { get; set; }
        public string NomeImpressoCartao { get; set; }
        
    }
}