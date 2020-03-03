using Microsoft.EntityFrameworkCore;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Data.Models.Calculator;

namespace Persona4GoldenHelper.Data
{
    /// <summary>The database context.</summary>
    public class ApplicationDbContext : DbContext
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The collection of accessories.</summary>
        public DbSet<Accessory> Accessories { get; set; }

        /// <summary>The collection of armor.</summary>
        public DbSet<Armor> Armor { get; set; }

        /// <summary>The collection of books.</summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>The order the books are rendered in the players inventory.</summary>
        public DbSet<BookOrder> BookOrder { get; set; }

        /// <summary>The collection of exam answers.</summary>
        public DbSet<Answer> ExamAnswers { get; set; }

        /// <summary>The collection of lunches.</summary>
        public DbSet<Lunch> Lunches { get; set; }

        /// <summary>The collection of personas.</summary>
        public DbSet<Persona> Personas { get; set; }

        /// <summary>The collection of plants.</summary>
        public DbSet<Plant> Plants { get; set; }

        /// <summary>The collection of quests.</summary>
        public DbSet<Quest> Quests { get; set; }

        /// <summary>The collection of shadows.</summary>
        public DbSet<Shadow> Shadows { get; set; }

        /// <summary>The collection of skills.</summary>
        public DbSet<Skill> Skills { get; set; }

        /// <summary>The collection of skill cards.</summary>
        public DbSet<SkillCard> SkillCards { get; set; }

        /// <summary>The collection of skill card locations.</summary>
        public DbSet<SkillCardLocation> SkillCardLocations { get; set; }

        /// <summary>The collection of weapons.</summary>
        public DbSet<Weapon> Weapons { get; set; }

        /// <summary>The collection of arcana fusion results.</summary>
        public DbSet<ArcanaFusionResult> ArcanaFusionResults { get; set; }

        /// <summary>The collection of special persona fusion results.</summary>
        public DbSet<SpecialFusionResult> SpecialFusionResults { get; set; }

        /// <summary>The arcanas ranked in importance.</summary>
        public DbSet<ArcanaRank> ArcanaRanks { get; set; }


        /*********
        ** Public Methods 
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="options">The database context options.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
