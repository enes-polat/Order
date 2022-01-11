using ECommerce.Core.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities.Concrete
{
    public class EntityBase<TId> : IEntityBase<TId>
    {
        //Property
        [Key]
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        //public DateTime UpdatedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
    }
}
