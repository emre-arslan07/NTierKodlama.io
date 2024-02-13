using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
	public class NTierKodlamaDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source = DESKTOP-1F0RU5E; Initial Catalog = NTierKodlamaIoDb; Integrated Security=true; MultipleActiveResultSets=true;TrustServerCertificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category
				{
					Id = 1,
					CategoryName = "Programlama",
				}
				);

			modelBuilder.Entity<Instructor>().HasData(
				new Instructor
				{
					Id = 1,
					FirstName="Engin",
					LastName="Demiroğ"
				},
				new Instructor
				{
					Id = 2,
					FirstName = "Halit Enes",
					LastName = "Kalaycı"
				}
				);

			modelBuilder.Entity<Course>().HasData(
				new Course
				{
					Id = 1,
					CourseName= "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
					Description= "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
					IsFree=true,
					Price=10,
					CategoryId= 1,
					InstructorId= 1,
				},
				new Course
				{
					Id = 2,
					CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
			        Description = "Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
					IsFree = true,
					Price = 10,
					CategoryId = 1,
					InstructorId = 1,
				},
				new Course
				{
					Id = 3,
					CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
					Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız",
					IsFree = true,
					Price = 10,
					CategoryId = 1,
					InstructorId = 2,
				},
				new Course
				{
					Id = 4,
					CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
					Description = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
					IsFree = true,
					Price = 10,
					CategoryId = 1,
					InstructorId = 1,
				},
				new Course
				{
					Id=5,
					CourseName= "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
					Description= "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız",
					IsFree = true,
					Price = 10,
					CategoryId = 1,
					InstructorId = 1,
				},
				new Course
				{
					Id=6,
					CourseName= "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
					Description= "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız",
					IsFree = true,
					Price = 10,
					CategoryId = 1,
					InstructorId = 1,
				},
				new Course
				{
					Id=7,
					CourseName= "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
					Description= "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız",
					IsFree = true,
					Price = 10,
					CategoryId = 1,
					InstructorId = 1,
				},
				new Course
				{
					Id=8,
					CourseName= "Programlamaya Giriş için Temel Kurs",
					Description= "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.",
					IsFree = true,
					Price = 10,
					CategoryId = 1,
					InstructorId = 1,
				}


				);;
		}

		public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
