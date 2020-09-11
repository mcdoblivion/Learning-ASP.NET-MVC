namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sales.staffs")]
    public partial class staffs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public staffs()
        {
            orders = new HashSet<orders>();
            staffs1 = new HashSet<staffs>();
        }

        [Key]
        public int staff_id { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [StringLength(25)]
        public string phone { get; set; }

        public byte active { get; set; }

        public int store_id { get; set; }

        public int? manager_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<staffs> staffs1 { get; set; }

        public virtual staffs staffs2 { get; set; }

        public virtual stores stores { get; set; }
    }
}
