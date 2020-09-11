namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sales.stores")]
    public partial class stores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stores()
        {
            stocks = new HashSet<stocks>();
            orders = new HashSet<orders>();
            staffs = new HashSet<staffs>();
        }

        [Key]
        public int store_id { get; set; }

        [Required]
        [StringLength(255)]
        public string store_name { get; set; }

        [StringLength(25)]
        public string phone { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string street { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        [StringLength(5)]
        public string zip_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stocks> stocks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<staffs> staffs { get; set; }
    }
}
