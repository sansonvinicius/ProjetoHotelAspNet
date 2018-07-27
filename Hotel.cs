namespace ProjetoHotelVS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hotel")]
    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            Quartos = new HashSet<Quarto>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(20)]
        public string Complemento { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "CEP")]
        public decimal Cep { get; set; }

        [Required]
        [StringLength(60)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "UF")]
        public string Uf { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "DDD")]
        public decimal Ddd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Telefone { get; set; }

        [StringLength(250)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quarto> Quartos { get; set; }
    }
}