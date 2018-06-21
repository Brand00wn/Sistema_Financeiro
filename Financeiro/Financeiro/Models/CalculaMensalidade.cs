namespace Financeiro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CalculaMensalidade
    {
        public float calculaValor(float mensalidade)
        {
            return mensalidade + mensalidade;
        }
    }
}
