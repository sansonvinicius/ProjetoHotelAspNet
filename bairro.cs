namespace ProjetoHotelVS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
  

    [Table("bairros")]
    public partial class bairro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bairro()
        {
            logradouros = new HashSet<logradouro>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bairro_id { get; set; }

        public int cidade_id { get; set; }

        [Required]
        [StringLength(45)]
        public string desc_bairro { get; set; }

        public virtual cidade cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<logradouro> logradouros { get; set; }
    }
}
