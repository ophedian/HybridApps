using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public static class EnumerableExtensions
    {
        public static Random r = new Random();

        public static T GetRandom<T>(this IEnumerable<T> list)
        {;
            return list.ElementAt(r.Next(list.Count()));
        }
    }
}