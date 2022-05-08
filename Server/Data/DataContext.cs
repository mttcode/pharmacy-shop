namespace PharmacyShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Vitamins",
                    Url = "vitamins"
                },
                new Category
                {
                    Id = 2,
                    Name = "Antipyretics",
                    Url = "antipyretics"
                },
                new Category
                {
                    Id = 3,
                    Name = "Digestion",
                    Url = "digestion"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Vitamin C Long Effect 500 mg",
                        Description = "Vitamin C nutritional supplement with gradual release for the proper functioning of the immune system.",
                        ImageUrl = "https://www.drmax.sk/_i/288425126.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2F6%2Fz%2F6zdiiq0_400x400_1.jpg&fit=contain&w=350&h=350&format=webp",
                        Price = 4.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Vitamin D DeVit 2000 IU",
                        Description = "Advantageous package with gelatin capsules with vitamin D3.",
                        ImageUrl = "https://www.drmax.sk/_i/1851874929.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fd%2Fe%2Fdevit_2000_120_l.png&fit=contain&w=350&h=350&format=webp",
                        Price = 11.49m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Magne B6",
                        Description = "It contains a combination of magnesium and vitamin B6, thanks to which magnesium is replenished in the body faster. Magne B6® improves in case of magnesium deficiency e.g. nervousness, fatigue, irritability, muscle cramps and numbness.",
                        ImageUrl = "https://www.drmax.sk/_i/1922185717.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fz%2Fp%2Fzpv4rz0_400x400_1.jpg&fit=contain&w=350&h=350&format=webp",
                        Price = 14.39m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Biopron 9",
                        Description = "Probiotic complex suitable for adults and children from 3 years.",
                        ImageUrl = "https://www.drmax.sk/_i/1944578361.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fo%2Fz%2Fozz0lb0_400x400_1.jpg&fit=contain&w=350&h=350&format=webp",
                        Price = 13.39m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Colafit",
                        Description = "Nutritional supplement that contains lyophilized collagen. Suitable as nutrition for cartilage, ligaments, joint capsule, tooth nails, skin.",
                        ImageUrl = "https://www.drmax.sk/_i/-145592899.jpg?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fj%2Fz%2Fjzn3he0_400x400_1.jpg&fit=contain&w=350&h=350&format=jpg",
                        Price = 9.39m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Paralen 500",
                        Description = "Drug with analgesic and antipyretic effect. Helps relieve pain and lower temperature. Suitable for flu conditions. It does not irritate the stomach.",
                        ImageUrl = "https://www.drmax.sk/_i/-1194474228.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fp%2Fa%2Fparalen_500_24tab.png&fit=contain&w=350&h=350&format=webp",
                        Price = 2.09m,
                        CategoryId = 2
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
