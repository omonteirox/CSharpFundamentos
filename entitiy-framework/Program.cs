using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entitiy_framework.Data;
using entitiy_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace entitiy_framework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // var tag = new Tag { Name = "C#", Slug = "c-sharp" };
                // context.Tags.Add(tag);
                // context.SaveChanges();
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
                // tag.Name = "Dotnet";
                // tag.Slug = "dot-net";
                // context.Update(tag);
                // context.SaveChanges();
                // context.Tags.Remove(context.Tags.FirstOrDefault(x => x.Id == 2));
                // var tags = context.Tags.AsNoTracking().ToList();


            }
        }
    }
}