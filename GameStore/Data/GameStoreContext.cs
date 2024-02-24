using Microsoft.EntityFrameworkCore;
using GameStore.Models;

namespace GameStore.Data
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            


            modelBuilder.Entity<Product>().HasData(
        new Product
        {
            Id = 1,
            Name = "Call Of Duty",
            ImageGame = "/public/call of duty.jpeg",
            Developer = "Ubisoft Montreal",
            Publisher = "Ubisoft",
            ReleaseDate = DateTime.Parse("2020-11-10"),
            Catagories = "Action, Adventure, RPG",
            Review = "242,544",
            Price = 59.99m,
            DiscountPercentage = 15
        },
            new Product
            {
                Id = 2,
                Name = "Dead Space",
                ImageGame = "/public/dead space.jpeg",
                Developer = "CD Projekt",
                Publisher = "CD Projekt",
                ReleaseDate = DateTime.Parse("2020-12-10"),
                Catagories = "Action, RPG",
                Review = "345,542",
                Price = 49.99m,
                DiscountPercentage = 10
            },
            new Product
            {
                Id = 3,
                Name = "Duty After School",
                ImageGame = "/public/duty after school.jpeg",
                Developer = "CD Projekt",
                Publisher = "CD Projekt",
                ReleaseDate = DateTime.Parse("2015-05-19"),
                Catagories = "Action, RPG",
                Review = "Very Positive",
                Price = 29.99m,
                DiscountPercentage = 20
            },
            new Product
            {
                Id = 4,
                Name = "Enshrounded",
                ImageGame = "/public/Enshrouded.jpeg",
                Developer = "EA Vancouver",
                Publisher = "Electronic Arts",
                ReleaseDate = DateTime.Parse("2021-10-01"),
                Catagories = "Sports, Simulation",
                Review = "Positive",
                Price = 39.99m,
                DiscountPercentage = 10
            },
            new Product
            {
                Id = 5,
                Name = "God Of War",
                ImageGame = "/public/God Of War.jpeg",
                Developer = "Rockstar Studios",
                Publisher = "Rockstar Games",
                ReleaseDate = DateTime.Parse("2018-10-26"),
                Catagories = "Action, Adventure",
                Review = "Very Positive",
                Price = 69.99m,
                DiscountPercentage = 15
            },
            new Product
            {
                Id = 6,
                Name = "Hogwart",
                ImageGame = "/public/hogwart.jepg",
                Developer = "Infinity Ward",
                Publisher = "Activision",
                ReleaseDate = DateTime.Parse("2019-10-25"),
                Catagories = "Action, Shooter",
                Review = "Positive",
                Price = 49.99m,
                DiscountPercentage = 10
            },
            new Product
            {
                Id = 7,
                Name = "Knivea Out",
                ImageGame = "/public/knivea out.jpeg",
                Developer = "Mojang Studios",
                Publisher = "Mojang",
                ReleaseDate = DateTime.Parse("2011-11-18"),
                Catagories = "Sandbox, Adventure",
                Review = "Overwhelmingly Positive",
                Price = 19.99m,
                DiscountPercentage = 25
            },
            new Product
            {
                Id = 8,
                Name = "League Legend",
                ImageGame = "/public/League Legend.jpeg",
                Developer = "InnerSloth",
                Publisher = "InnerSloth",
                ReleaseDate = DateTime.Parse("2018-11-16"),
                Catagories = "Casual, Party Game",
                Review = "Very Positive",
                Price = 4.99m,
                DiscountPercentage = 50
            },
            new Product
            {
                Id = 9,
                Name = "Palworld",
                ImageGame = "/public/Palworld.jpeg",
                Developer = "Riot Games",
                Publisher = "Riot Games",
                ReleaseDate = DateTime.Parse("2009-10-27"),
                Catagories = "MOBA",
                Review = "Very Positive",
                Price = 0m,
                DiscountPercentage = 0
            },
            new Product
            {
                Id = 10,
                Name = "TEKKEN 8",
                ImageGame = "/public/TEKKEN 8.jpeg",
                Developer = "id Software",
                Publisher = "Bethesda Softworks",
                ReleaseDate = DateTime.Parse("2020-03-20"),
                Catagories = "Action, Shooter",
                Review = "Very Positive",
                Price = 59.99m,
                DiscountPercentage = 20
            },
            new Product
            {
                Id = 11,
                Name = "Till The End Of The Moonl",
                ImageGame = "/public/tntm.jpeg",
                Developer = "id Software",
                Publisher = "Bethesda Softworks",
                ReleaseDate = DateTime.Parse("2020-03-20"),
                Catagories = "Action, Shooter",
                Review = "21,543",
                Price = 59.99m,
                DiscountPercentage = 20
            },
            new Product
            {
                Id = 12,
                Name = "Tom Clancy's Rainbow",
                ImageGame = "/public/Tom Clancy's Rainbow.jpeg",
                Developer = "id Software",
                Publisher = "Bethesda Softworks",
                ReleaseDate = DateTime.Parse("2020-03-20"),
                Catagories = "Action, Shooter",
                Review = "876,234",
                Price = 59.99m,
                DiscountPercentage = 20
            },
            new Product
            {
                Id = 13,
                Name = "War Thunderl",
                ImageGame = "/public/War Thunder.jpeg",
                Developer = "id Software",
                Publisher = "Bethesda Softworks",
                ReleaseDate = DateTime.Parse("2020-03-20"),
                Catagories = "Action, Shooter",
                Review = "143,756",
                Price = 59.99m,
                DiscountPercentage = 20
            },
            new Product
            {
                Id = 14,
                Name = "World of Tanks",
                ImageGame = "/public/World of Tanks.jpeg",
                Developer = "id Software",
                Publisher = "Bethesda Softworks",
                ReleaseDate = DateTime.Parse("2020-03-20"),
                Catagories = "Action, Shooter",
                Review = "566,34",
                Price = 59.99m,
                DiscountPercentage = 20
          
            }

        ); 

            base.OnModelCreating(modelBuilder);

        }
    }
}
