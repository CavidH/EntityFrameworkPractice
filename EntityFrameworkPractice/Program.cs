using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkPractice.DAL;
using EntityFrameworkPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetAllProduct())
            {
                Console.WriteLine(item.Id+"  "+item.Name+" "+" "+item.Price+"\n");
            }           
            
        }

        static List<Product> GetAllProduct()
        {
            
            using (AppDbContext Db = new AppDbContext())
            {
                var product = Db.Products.ToList();
                return product;

            }



        } 
        static void AddProduct()
        {
            using (AppDbContext Db = new AppDbContext())
            {
                var product = new Product() {Name = "Lenovo", Price = 2540};
                Db.Products.Add(product);
                Db.SaveChanges();
                Console.WriteLine("ok");
            }
        }
    }
}
