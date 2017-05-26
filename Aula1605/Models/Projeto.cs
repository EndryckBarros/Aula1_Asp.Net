using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1605.Models
{
    public class Projeto
    {
        public int ProjetoID { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required] // NAO PERMITE NULO
        public string Nome { get; set; }
        public bool Ativo { get; set; }

    }
}