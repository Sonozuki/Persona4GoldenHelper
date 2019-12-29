using Microsoft.EntityFrameworkCore;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Data.Models.Calculator;

namespace Persona4GoldenHelper.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Armor> Armor { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookOrder> BookOrder { get; set; }
        public DbSet<Answer> ExamAnswers { get; set; }
        public DbSet<Lunch> Lunches { get; set; }
        public DbSet<Models.Persona> Personas { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillCard> SkillCards { get; set; }
        public DbSet<SkillCardLocation> SkillCardLocations { get; set; }
        public DbSet<Source> Sources { get; set; }

        public DbSet<ArcanaFusionResult> ArcanaFusionResults { get; set; }
        public DbSet<SpecialFusionResult> SpecialFusionResults { get; set; }
        public DbSet<ArcanaRank> ArcanaRanks { get; set; }
    }
}
