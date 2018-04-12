using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Models
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(250)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(250)]
        public string UpdatedBy { set; get; }

        [MaxLength(250)]
        public string MetaKeyword { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}