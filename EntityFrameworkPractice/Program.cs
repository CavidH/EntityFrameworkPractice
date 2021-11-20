using System;
using System.Collections;
using EntityFrameworkPractice.DAL;
using EntityFrameworkPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                using (AppDbContext Db = new AppDbContext())
                {
                    var product = new Product() { Name = "Lenovo", Price = 2540 };
                    Db.Products.Add(product);
                    Db.SaveChanges();
                    Console.WriteLine("ok");
                }
            
        }
    }
}
