using BLL.Concrete;
using DAL.EntityFramework;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.Design;

namespace ConsoleApp.UI
{
	public class Program
	{
		static void Main(string[] args)
		{
			
		 void GetCategories()
		{
			CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
			List<Category> categories = categoryManager.GetAll();
				foreach (var item in categories)
				{
					Console.WriteLine(item.CategoryName);
				}
			}

			void GetCourses(string? word)
			{
				CourseManager courseManager = new CourseManager(new EFCourseDal());
				List<Course> courses;
				if (word.IsNullOrEmpty())
				{
				courses = courseManager.GetCourseWithInstructor();
				}
				else
				{
				courses = courseManager.GetCourseWithSearch(word);
				}
				foreach (var item in courses)
				{
					Console.WriteLine("Kurs Adı:" + item.CourseName);
					Console.WriteLine("Kurs Açıklaması:" + item.Description);
					Console.WriteLine("Eğitmen Adı :" + item.Instructor.FirstName);
					Console.WriteLine("Eğitmen Soyadı :" + item.Instructor.LastName);
					if (item.IsFree)
					{
						Console.WriteLine("Ücretsiz");
					}
					else
					{
						Console.WriteLine("Ücret :" + item.Price + "₺");
					}
					Console.WriteLine("-------------------------------");
				}
			}

			Console.WriteLine("----------------------Kodlama.io----------------------");
          
			GetCategories();
			GetCourses(null);
			Console.WriteLine("Kurs Arayın");
			string word = Console.ReadLine();
			GetCourses(word);
			bool init=true;
			while(init==true)
			{          
                Console.WriteLine("Devam Etmek İstiyor Musunz?E/H");
				string choice=Console.ReadLine();
				switch (choice.ToUpper())
				{
					case "E":
						Console.Clear();
						Console.WriteLine("Kurs Arayın");
						GetCourses(Console.ReadLine().ToString());
						break;
					case "H":
						init = false;
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Lütfen doğru bilgi giriniz");
						break;
				}	
			}
			Console.ReadLine();
		}
	}
}
