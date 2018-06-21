namespace Financeiro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mensalidade")]
    public partial class Mensalidade
    {
        [Key]
        public int idMensalidade { get; set; }

        [Display(Name = "Valor Mensalidade")]
        public int ValorMensalidade { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Vencimento")]
        public DateTime DataVencimento { get; set; }

        [Display(Name = "Juros/Dia(%)")]
        public int JurosAoDia { get; set; }

        [Display(Name = "Bolsa(%)")]
        public int PercentualBolsa { get; set; }

        [Display(Name = "Curso")]
        public int? Curso_idCurso { get; set; }

        public virtual Curso Curso { get; set; }

        public double calculaValor(double mensalidade, DateTime dataVencimento, double bolsa, double juros)
        {
            DateTime today = DateTime.Today;
            var diferenca = (today - dataVencimento).TotalDays;
            double valor = 0;

            if (diferenca > 0)
            {
                valor = mensalidade + (mensalidade * ((juros / 100) * diferenca));
            }
            else
            {
                valor = mensalidade - (mensalidade * (bolsa / 100));
            }

            return valor;
        }
    }
}
