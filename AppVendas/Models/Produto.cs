﻿using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo não pode ser vazio!")]
        [MaxLength(100, ErrorMessage = "O Campo deve ter, no máximo, 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo deve ter no mí/nimo 3 caracteres!")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O Campo não pode ser vazio!")]
        [Range(0.0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser positivo!")]
        public double Valor { get; set; }

        [Display(Name = "Estoque")]
        [Required(ErrorMessage = "O Campo não pode ser vazio!")]
        [Range(0.0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser positivo!")]
        public double QtdadeEstoque { get; set; }

        [Display(Name = "Ativo?")]
        public bool? CadastroAtivo { get; set; }

        //CHAVE ESTRANGEIRA\\
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "por favor, selecione uma categoria!")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
