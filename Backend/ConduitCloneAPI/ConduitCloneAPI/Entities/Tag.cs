using System.ComponentModel.DataAnnotations.Schema;

namespace ConduitCloneAPI.Entities
{
    public class Tag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? Description { get; set; }
    }
}
