using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    class Produto
    {
        [Key]                    // CHAVE PRIMÁRIA
        public int ProdutoID { get; set; }
        [Required]              // CAMPO OBRIGATÓRIO
        [StringLength(20)]      // TAMANHO MÁXIMO
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }


        // _RELACIONAMENTO CATEGORIA --- PRODUTO
        public int CategoriaID { get; set; }
        public virtual Categoria _Categoria { get; set; }
    }
}
