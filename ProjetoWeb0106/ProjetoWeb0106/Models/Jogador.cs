//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoWeb0106.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public int Numero { get; set; }
        public int ClubeId { get; set; }
    
        public virtual Clube Clube { get; set; }
    }
}
