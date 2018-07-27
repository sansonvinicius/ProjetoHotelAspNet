namespace ProjetoHotelVS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class uf
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uf()
        {
            cidades = new HashSet<cidade>();
        }

        [Key]
        [StringLength(2)]
        public string uf_id { get; set; }

        [Required]
        [StringLength(60)]
        public string desc_uf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cidade> cidades { get; set; }
    }
}
