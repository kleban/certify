using Certify.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Certify.Core
{
    public class CertifyDbContext : IdentityDbContext<User, Role, string>
    {
        public CertifyDbContext()            
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder 
            { 
                DataSource = "certify_db.sqlite"
            };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course>().HasOne(x => x.Owner).WithMany(x => x.CoursesCreated);
            builder.Entity<Certificate>().HasOne(x => x.Student).WithMany(x => x.Certificates);

            builder.Entity<Role>().HasData(
                new List<Role>
                {
                    new Role
                    {
                        Id = "admin_role_id",
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new Role
                    {
                        Id = "teacher_role_id",
                        Name = "Teacher",
                        NormalizedName = "TEACHER"
                    },
                    new Role
                    {
                        Id = "student_role_id",
                        Name = "Student",
                        NormalizedName = "STUDENT"
                    }
                }
                );

            var hasher = new PasswordHasher<User>();

            builder.Entity<User>().HasData(
                new List<User> {
                    new User
                    {
                        Id = "admin_user_id",
                        UserName = "admin@dataclass.org.ua",
                        Email = "admin@dataclass.org.ua",
                        NormalizedUserName = "ADMIN@DATACLASS.ORG.UA",
                        PasswordHash = hasher.HashPassword(null, "temppass")
                    }});

            builder.Entity<IdentityUserRole<string>>().HasData(
                new List<IdentityUserRole<string>>
                {
                    new IdentityUserRole<string>
                    {
                        RoleId = "admin_role_id",
                        UserId = "admin_user_id"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "teacher_role_id",
                        UserId = "admin_user_id"
                    }}
                );          

            base.OnModelCreating(builder);
        }
    }
}
