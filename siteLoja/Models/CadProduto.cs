using System;
using System.Collections.Generic;

namespace siteLoja.Models
{
    public partial class CadProduto
    {
        public int CdProduto { get; set; }
        public int? CdCategoria { get; set; }
        public string NmProduto { get; set; } = null!;
        public double? Preco { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public int? Inativo { get; set; }
        public string? ImagemUrl { get; set; }
        public string? ImagemUrlThumb { get; set; }
        public bool? EmEstoque { get; set; }

        public virtual CadCategoria? cadCategoria { get; set; }
    }
}
