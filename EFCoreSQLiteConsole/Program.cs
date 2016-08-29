using EFCoreSQLiteConsole.Context;
using EFCoreSQLiteConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSQLiteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext();

            foreach (var item in db.Beers)
            {
                Console.WriteLine(string.Format("{0}\t{1}\t{2}", item.Id, item.Name, item.Note));
            }

            Console.WriteLine("Enter a beer name");
            string beerName = Console.ReadLine();

            Console.WriteLine("Enter a note");
            string beerNote = Console.ReadLine();

            Beer beer = new Beer()
            {
                Name = beerName,
                Note = beerNote
            };

            

            db.Beers.Add(beer);

            db.SaveChanges();
        }
    }
}
