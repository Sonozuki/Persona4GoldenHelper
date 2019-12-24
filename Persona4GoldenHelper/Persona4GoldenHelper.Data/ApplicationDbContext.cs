using Microsoft.EntityFrameworkCore;
using Persona4GoldenHelper.Data.Models;

namespace Persona4GoldenHelper.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Armor> Armor { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookOrder> BookOrder { get; set; }
        public DbSet<Answer> ExamAnswers { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillCard> SkillCards { get; set; }
    }
}
