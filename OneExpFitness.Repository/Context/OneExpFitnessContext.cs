using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OneExpFitness.Repository.Context
{
    using Models;
    public class OneExpFitnessContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public OneExpFitnessContext(DbContextOptions<OneExpFitnessContext> options)
            :base(options)
        {
            
        }

        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CertificationCompany> Companies { get; set; }
        public DbSet<CertificationCourse> Courses { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupActivity> GroupActivities { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<GymTrainer> GymTrainers { get; set; }
        public DbSet<Trainee> Trainees  { get; set; }
        public DbSet<Trainer> Trainers  { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}
