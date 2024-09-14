using FlashSportsScore.Core.FlashSports.Domain;
using Microsoft.EntityFrameworkCore;

namespace FlashSportsScore.Core.FlashSports.Infrastructure
{
    public class FlashSportsContext : DbContext
    {
        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Properties
        public DbSet<FlashSport> FlashSports { get; set; }
        public DbSet<Score> Scores { get; set; }

        #endregion
    }
}
