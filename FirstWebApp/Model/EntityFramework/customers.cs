namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sales.customers")]
    public partial class customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customers()
        {
            orders = new HashSet<orders>();
        }

        [Key]
        public int customer_id { get; set; }

        [Required]
        [StringLength(255)]
        public string first_name { get; set; }

        [Required]
        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(25)]
        public string phone { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string street { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(25)]
        public string state { get; set; }

        [StringLength(5)]
        public string zip_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
    }
}
