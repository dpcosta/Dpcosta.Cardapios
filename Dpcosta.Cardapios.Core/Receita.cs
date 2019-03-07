using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dpcosta.Cardapios.Core
{
    public class Receita
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public IList<Ingrediente> Ingredientes { get; set;  }

    }
}
