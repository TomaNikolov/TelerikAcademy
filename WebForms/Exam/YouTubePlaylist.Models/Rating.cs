﻿namespace YouTubePlaylist.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int  Value { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int PlaylistId { get; set; }

        public virtual Playlist Playlist { get; set; }
    }
}