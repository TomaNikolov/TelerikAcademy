namespace YouTubePlaylist.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(200)]
        public string Url { get; set; }

        public int PlaylistId { get; set; }

        public virtual Playlist Playlist { get; set; }
    }
}