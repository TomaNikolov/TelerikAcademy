namespace YouTubePlaylist.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Playlist
    {
        private ICollection<Video> videos;
        private ICollection<Rating> ratings;

        public Playlist()
        {
            this.videos = new HashSet<Video>();
            this.ratings = new HashSet<Rating>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(2000)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Video> Videos
        {
            get { return this.videos; }
            set { this.videos = value; }
        }

        public virtual ICollection<Rating> Ratings
        {
            get { return this.ratings; }
            set { this.ratings = value; }
        }
    }
}