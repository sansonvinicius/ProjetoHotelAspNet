namespace ProjetoHotelVS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Turista")]
    public partial class Turista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turista()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        public bool Sexo { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cpf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
