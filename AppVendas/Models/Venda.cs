namespace AppVendas.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public int NotaFiscal { get; set; }
        public DateTime Datavenda { get; set; }
        public double? TotalVenda { get; set; }

        //REFERENCIA PARA A MODEL CLIENTE\\

        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
