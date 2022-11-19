using System.ComponentModel.DataAnnotations.Schema;

namespace ConduitCloneAPI.Entities
{
    public class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Theme { get; set; }
        public string? Body { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        // relacionamentos
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public ICollection<Tag>? Tags { get; set; }
    }
}
