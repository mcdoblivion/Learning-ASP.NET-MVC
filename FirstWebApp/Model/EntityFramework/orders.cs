namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sales.orders")]
    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            order_items = new HashSet<order_items>();
        }

        [Key]
        public int order_id { get; set; }

        public int? customer_id { get; set; }

        public byte order_status { get; set; }

        [Column(TypeName = "date")]
        public DateTime order_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime required_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? shipped_date { get; set; }

        public int store_id { get; set; }

        public int staff_id { get; set; }

        public virtual customers customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_items> order_items { get; set; }

        public virtual staffs staffs { get; set; }

        public virtual stores stores { get; set; }
    }
}
