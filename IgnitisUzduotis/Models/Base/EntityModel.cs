using System.ComponentModel.DataAnnotations;

namespace IgnitisUzduotis.Models.Base
{
    public class EntityModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
