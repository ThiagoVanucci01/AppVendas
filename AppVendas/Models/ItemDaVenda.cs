namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }

        //RELACIONAMENTO COM A TABELA PRODUTOS\\

        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        //RELACIONAMENTO COM A TABELA PRODUTOS\\

        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public double QtdadeVendida { get; set; }
        public double ValorTotalDoItem { get; set; }

    }
}
