namespace YouTubePlaylist.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        private ICollection<Playlist> playlists;
        public Category()
        {
            this.playlists = new HashSet<Playlist>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(2)]
        [MaxLength(150)]
        public string Name { get; set; }

        public ICollection<Playlist> Playlists
        {
            get { return this.playlists; }
            set { this.playlists = value; }
        }
    }
}