using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities.Abstract
{
    public interface IEntityBase<TId>
    {
        //Property
        [Key]
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        //public DateTime UpdatedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
    }
}
