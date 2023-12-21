using AppleStoreIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppleStoreIdentity.Database;

public class AppleDbContext : IdentityDbContext
{
    public AppleDbContext(DbContextOptions<AppleDbContext> options) : base(options) { }

    public DbSet<Device> Devices { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Category>().HasData
        (
            new()
            {
                Id = 1,
                Name = "iPad",
                Description = "Os iPads da Apple são os primeiros tablets do mercado. Uma revolução para a época e até hoje os melhores.",
                Devices = null
            },
            new()
            {
                Id = 2,
                Name = "iPhone",
                Description = "Os mais rápidos celulares, os melhores aparelhos multimídia e o maior preço do mercado.",
                Devices = null
            },
            new()
            {
                Id = 3,
                Name = "Mac",
                Description = "O MacOS é o melhor sistema operacional e apenas os aparelhos Apple o possuem. Sem comparação, inclusive no preço.",
                Devices = null
            },
            new()
            {
                Id = 4,
                Name = "Watch",
                Description = "Ninguém pensou que um relógio poderia ser inteliganete... Antes da Apple.",
                Devices = null
            },
            new()
            {
                Id = 5,
                Name = "iMac",
                Description = "Os lendários iMacs da Apple. Feito para os criativos.",
                Devices = null
            }
        );

        builder.Entity<Device>().HasData
        (
            new()
            {
                CategoryId = 1,
                Name = "iPad Air",
                Description = "O iPad Air é um tablet da Apple.",
                Price = 13899,
                UrlImg = "/iPadPro.jpg",
                Id = 1
            },
            new()
            {
                CategoryId = 2,
                Name = "iPhone 15 Pro Max",
                Description = "O iPhone 15 Pro Max é um celular da Apple.",
                Price = 11799,
                UrlImg = "/iPhone.jpg",
                Id = 2
            },
            new()
            {
                CategoryId = 3,
                Name = "Macbook Pro",
                Description = "O Macbook Pro é um notebook da Apple.",
                Price = 14189,
                UrlImg = "/MacbookPro.jpg",
                Id = 3
            },
            new()
            {
                CategoryId = 4,
                Name = "Apple Watch 5",
                Description = "O Apple Watch é um smartwatch da Apple.",
                Price = 3799,
                UrlImg = "/AppleWatch.png",
                Id = 4
            },
            new()
            {
                CategoryId = 5,
                Name = "iMac",
                Description = "O iMac é um computador da Apple.",
                Price = 21299,
                UrlImg = "/iMac.jpg",
                Id = 5
            }
        );
    }
}
