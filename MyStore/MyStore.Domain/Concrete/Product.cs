//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyStore.Domain.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "请输入产品名称：")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "产品名称长度小于100字")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "请输入产品价格：")]
        [Range(0.01, double.MaxValue, ErrorMessage = "产品价格必须大于0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "请选择产品图片")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "请输入产品简介")]
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
