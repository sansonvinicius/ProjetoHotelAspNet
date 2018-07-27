namespace ProjetoHotelVS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quarto")]
    public partial class Quarto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quarto()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int Id { get; set; }

        public int HotelId { get; set; }

        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [StringLength(250)]
        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int MaximoOcupantes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorDiaria { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorDiariaCrianca { get; set; }

        public bool? DiariaPorOcupante { get; set; }

        public virtual Hotel Hotel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
