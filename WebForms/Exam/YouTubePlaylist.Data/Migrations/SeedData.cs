namespace YouTubePlaylist.Data.Migrations
{
    using YouTubePlaylist.Models;
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity;
    using System.Linq;
    public class SeedData
    {
        public static Random Rand = new Random();

        public List<Category> Categories;

        public List<User> Users;

        public List<Playlist> Playlist { get; set; }

        public List<Video> Videos { get; set; }

        public List<Rating> Ratings { get; set; }

        public User Admin { get; set; }

        public SeedData(List<User> users)
        {
            this.Users = users;

            this.Categories = new List<Category>();
            Categories.Add(new Category() { Name = "Art" });
            Categories.Add(new Category() { Name = "Economy" });
            Categories.Add(new Category() { Name = "Technology" });
            Categories.Add(new Category() { Name = "Education" });
            Categories.Add(new Category() { Name = "Sports" });
            Categories.Add(new Category() { Name = "Science" });
            Categories.Add(new Category() { Name = "Weather" });

                      this.Videos = new List<Video>();
            Videos.Add(new Video() {Url = "https://www.youtube.com/watch?v=7t0edGrcH4w" });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=FTfk7odM7U0" });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=0TAfVyqFBL0" });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=_5qgdig9nIs" });


            this.Ratings = new List<Rating>();
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });
            this.Ratings.Add(new Rating { Value = this.GetRandomNumber(1, 5), UserId = this.Users[this.GetRandomNumber(0, this.Users.Count - 1)].Id });

            this.Playlist = new List<Playlist>();
            Playlist.Add(new Playlist()
            {
                Title = "What is Lorem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> {  this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] }, 
                
            });
            Playlist.Add(new Playlist()
            {
                Title = "What is Lorem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "What im Ipsuem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "What ism Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "What isssing hiddenm?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "What at is Lor Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "Whem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "em Ipsum has beenrem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "em Ipsum has been?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
            Playlist.Add(new Playlist()
            {
                Title = "em Ipsum has beensum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                User = users[this.GetRandomNumber(0, Users.Count - 1)],
                Category = this.Categories[this.GetRandomNumber(0, Categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = new List<Video>() { this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)], this.Videos[this.GetRandomNumber(0, Videos.Count - 1)] },
                Ratings = new List<Rating> { this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)], this.Ratings[this.GetRandomNumber(0, Ratings.Count - 1)] },

            });
        }


        private int GetRandomNumber(int min, int max)
        {
            return Rand.Next(min, max + 1);
        }
    }
}