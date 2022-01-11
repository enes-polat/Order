using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Core.Common
{
    public class Result<T>
    {
        //Property
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        [NotMapped]
        public string InnerMessage { get; set; } 

    }
}
