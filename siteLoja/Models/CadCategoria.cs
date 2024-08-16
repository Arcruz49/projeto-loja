using System;
using System.Collections.Generic;

namespace siteLoja.Models
{
    public partial class CadCategoria
    {
        public CadCategoria()
        {
            CadProdutos = new HashSet<CadProduto>();
        }

        public int CdCategoria { get; set; }
        public string NmCategoria { get; set; } = null!;
        public string? DescCategoria { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public int? Inativo { get; set; }

        public virtual ICollection<CadProduto> CadProdutos { get; set; }
    }
}
