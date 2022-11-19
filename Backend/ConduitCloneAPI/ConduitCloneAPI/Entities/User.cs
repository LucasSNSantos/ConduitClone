using System.ComponentModel.DataAnnotations.Schema;

namespace ConduitCloneAPI.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string? ProfilePicture { get;set; }
        public ICollection<Article>? Articles { get; set; }
        //public ICollection<Article>? LikedArticles { get; set; }

        public User(int id, string? userName, string? password, string? email, string? bio, string? profilePicture)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
            Bio = bio;
            ProfilePicture = profilePicture;
        }
    }
}
