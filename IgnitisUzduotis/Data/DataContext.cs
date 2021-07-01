using IgnitisUzduotis.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IgnitisUzduotis.Data
{
    public class DataContext : DbContext
    {
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<DropDownModel> DropDowns { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<QuestionModel>()
        //    .HasMany(d => d.DropDowns)
        //    .WithOne(dd => dd.Question)
        //    .HasForeignKey(qi => qi.QuestionModelId);
        //}

        public DataContext(DbContextOptions options) : base(options)
        {
            if (!Questions.Any())
            {
                Questions.Add(new QuestionModel()
                {
                    Name = "Do you watch TV?"
                });
                Questions.Add(new QuestionModel()
                {
                    Name = "How many times during the week you are watching the TV?"
                });
                Questions.Add(new QuestionModel()
                {
                    Name = "Do you watch Anime?"
                });
                Questions.Add(new QuestionModel()
                {
                    Name = "Select your favorite anime"
                });
                SaveChanges();
            }
            if (!DropDowns.Any())
            {
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Yes",
                    Value = "Yes",
                    QuestionModelId = 1,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "No",
                    Value = "No",
                    QuestionModelId = 1,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "None",
                    Value = "0",
                    QuestionModelId = 2,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Some times (2-3 days of the week)",
                    Value = "3",
                    QuestionModelId = 2,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Regularly (4-5 days of the week)",
                    Value = "4",
                    QuestionModelId = 2,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Everyday",
                    Value = "7",
                    QuestionModelId = 2,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Yes",
                    Value = "Yes",
                    QuestionModelId = 3,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "No",
                    Value = "No",
                    QuestionModelId = 3,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Fullmetal Alchemist: Brotherhood",
                    Value = "FAB",
                    QuestionModelId = 4,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Steins;Gate",
                    Value = "SG",
                    QuestionModelId = 4,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Hunter x Hunter",
                    Value = "HH",
                    QuestionModelId = 4,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Your Name",
                    Value = "YN",
                    QuestionModelId = 4,
                });
                DropDowns.Add(new DropDownModel()
                {
                    Name = "Violet Evergarden",
                    Value = "VE",
                    QuestionModelId = 4,
                });
                SaveChanges();
            }
        }
    }
}
