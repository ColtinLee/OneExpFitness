﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneExpFitness.Repository.Context;

namespace OneExpFitness.Repository.Migrations
{
    [DbContext(typeof(OneExpFitnessContext))]
    partial class OneExpFitnessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<byte>("Age");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Certification", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificateIssuer");

                    b.Property<int>("CertificationCourseId");

                    b.Property<string>("UserId");

                    b.HasKey("CertificateId");

                    b.HasIndex("CertificationCourseId");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.CertificationCompany", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyUrl");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.CertificationCourse", b =>
                {
                    b.Property<int>("CertificationCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CertificationCost");

                    b.Property<string>("CertificationLink");

                    b.Property<int>("CompanyId");

                    b.Property<short>("CourseLength");

                    b.HasKey("CertificationCourseId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Friend", b =>
                {
                    b.Property<int>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("ApplicationUserId");

                    b.Property<string>("FriendUserId");

                    b.Property<string>("UserId");

                    b.HasKey("FriendId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupTitle");

                    b.Property<int>("GymId");

                    b.Property<bool>("IsActive");

                    b.Property<int>("UserId");

                    b.Property<Guid?>("UserId1");

                    b.HasKey("GroupId");

                    b.HasIndex("UserId1");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.GroupActivity", b =>
                {
                    b.Property<int>("GroupActivityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<int>("GroupId");

                    b.Property<string>("MuscleGroup");

                    b.Property<DateTime>("WorkoutTime");

                    b.HasKey("GroupActivityId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupActivities");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Gym", b =>
                {
                    b.Property<int>("GymId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GymAddress1");

                    b.Property<string>("GymAddress2");

                    b.Property<string>("GymName");

                    b.Property<decimal>("GymPrice");

                    b.Property<string>("GymUrl");

                    b.HasKey("GymId");

                    b.ToTable("Gyms");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.GymTrainer", b =>
                {
                    b.Property<int>("GymTrainerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GymId");

                    b.Property<int>("TrainerId");

                    b.HasKey("GymTrainerId");

                    b.HasIndex("GymId");

                    b.HasIndex("TrainerId");

                    b.ToTable("GymTrainers");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TrainerId");

                    b.Property<string>("UserId");

                    b.HasKey("TraineeId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CertificationId");

                    b.Property<bool>("IsFreelance");

                    b.Property<string>("UserId");

                    b.HasKey("TrainerId");

                    b.HasIndex("CertificationId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OneExpFitness.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Certification", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.CertificationCourse", "CertificationCourse")
                        .WithMany()
                        .HasForeignKey("CertificationCourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.CertificationCourse", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.CertificationCompany", "CertificationCompany")
                        .WithMany("CertificationCourses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Friend", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.ApplicationUser")
                        .WithMany("Friends")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Group", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.GroupActivity", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.Group", "Group")
                        .WithMany("GroupActivities")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.GymTrainer", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.Gym")
                        .WithMany("GymTrainers")
                        .HasForeignKey("GymId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OneExpFitness.Repository.Models.Trainer")
                        .WithMany("GymTrainers")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Trainee", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.Trainer", "Trainer")
                        .WithMany("Trainees")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OneExpFitness.Repository.Models.Trainer", b =>
                {
                    b.HasOne("OneExpFitness.Repository.Models.Certification", "Certification")
                        .WithMany()
                        .HasForeignKey("CertificationId");
                });
#pragma warning restore 612, 618
        }
    }
}
