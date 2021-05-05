using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;

namespace SamuraiApp.UI
{
    class Program
    {
        private static SamuraiContext _context = new SamuraiContext();
        static void Main(string[] args)
        {
            _context.Database.EnsureCreated();
            GetSumurai("Before add:");
            AddSumurai("Film2");
            GetSumurai("After add:");
            Console.ReadKey();
        }
        private static void AddSumurai(string _Name)
        {
            var _Sumurai = new Samurai { Name = _Name };
            _context.Samurais.Add(_Sumurai);
            _context.SaveChanges();

        }
        private static void GetSumurai(string _Name)
        {
            var _Sumurai = _context.Samurais.ToList();
            Console.WriteLine($"{_Name}: Samurais is Count {_Sumurai.Count}");
            foreach (var sumurai in _Sumurai)
            {
                Console.WriteLine($"{sumurai.Name}");
            }

        }
    }
}
