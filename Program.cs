using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();
            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            var badPW = users.Where(p => p.Password == "hello");
            foreach (var p in badPW)
            {
                Console.WriteLine($"The user {p.Name} has the bad password 'hello'");
            }
            var removeBadPW = badPW.FirstOrDefault();
            users.Remove(removeBadPW);

            var otrBadPW = users.Where(p => (p.Password.ToUpper() == p.Name.ToUpper()));
            var removeOtrBadPW = otrBadPW.FirstOrDefault();
            users.Remove(removeOtrBadPW);

            foreach (var u in users)
            {
                Console.WriteLine($"\nThe remaining user: {u.Name} and password: {u.Password}\n");
            }

        }
    }
}
