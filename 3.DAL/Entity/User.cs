using System.ComponentModel.DataAnnotations;

namespace _3.DAL.Entity
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(255)] // Đặt độ dài tối đa cho các chuỗi dài
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string FullName { get; set; }

        [MaxLength(255)]
        public string? Nickname { get; set; }

        [MaxLength(500)]
        public string? Avatar { get; set; }

        [MaxLength(1000)]
        public string? Bio { get; set; }

        public bool Tick { get; set; }

        public int FollowingsCount { get; set; }
        public int FollowersCount { get; set; }
        public int LikesCount { get; set; }

        [MaxLength(255)]
        public string? WebsiteUrl { get; set; }

        [MaxLength(255)]
        public string? FacebookUrl { get; set; }

        [MaxLength(255)]
        public string? YoutubeUrl { get; set; }

        [MaxLength(255)]
        public string? TwitterUrl { get; set; }

        [MaxLength(255)]
        public string? InstagramUrl { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
