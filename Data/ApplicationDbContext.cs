using Histo_Clinic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Histo_Clinic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Patiens> Patiens { get; set; }
        public DbSet<FamilyHistory> FamilyHistory { get; set; }
        public DbSet<Medical_History> MedicalHistory { get; set; }
    }
}
