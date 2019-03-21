using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEffectiveLINQ
{
    class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
    }

    class Program
    {
        static void GetListOfFileSizes()
        {
            var paths = new[] { "c:\\windows\\notepad.exe", "c:\\windows\\regedit.exe" };

            //var fileSizes = new List<long>();
            //foreach (var length in paths.Select(p => new FileInfo(p).Length))
            //{
            //    fileSizes.Add(length);
            //}

            paths.Select(f => new FileInfo(f).Length).ToList().ForEach(fs =>
            {
                Console.WriteLine(fs);
            });
        }

        static List<Order> orders = new List<Order>()
            {
                new Order{ Id = 123, Amount = 29.95m, CustomerName = "Mark", Status = "Delivered" },
                new Order{ Id = 456, Amount = 45.00m, CustomerName = "Mark", Status = "Refunded" },
                new Order{ Id = 768, Amount = 32.50m, CustomerName = "Mark", Status = "Delivered" }
            };

        static void CheckOrdersForRefunds()
        {
            bool anyRefunded = orders.Any(o => o.Status == "Refunded");
            bool allDelivered = orders.All(o => o.Status == "Delivered");

            Console.WriteLine("Any: {0}, Delivered: {1}", anyRefunded, allDelivered);
        }

        static void CountRefundedOrders()
        {
            Console.WriteLine("Refunded count: " + orders.Count(o => o.Status == "Refunded"));
            Console.ReadLine();
        }

        static void GetOrderTotal()
        {
            Console.WriteLine("Count: " + orders.Sum(o => o.Amount));
            Console.ReadLine();
        }

        static void GroupByCustomer()
        {
            orders.GroupBy(o => o.CustomerName).ToDictionary(g => g.Key, g => g.ToList());
        }

        static void Challengue()
        {
            "10, 5, 0, 8, 10, 1, 4, 0, 10, 1"
                .Split(',')
                .Select(int.Parse)
                .OrderBy(n => n)
                .Skip(3)
                .Sum();
        }

        static void ChallegueTime()
        {
            var result = "2:54,3:48,4:51,3:32,6:15,4:08,5:17,3:13,4:16,3:55,4:53,5:35,4:24"
                .Split(',')
                .Select(t => TimeSpan.Parse("0:" + t))
                .Aggregate((t1, t2) => t1 + t2);

            Console.WriteLine(result);
        }

        static void ChallengueRange()
        {
            var result = "6,1-3,2-4"
                .Split(',')
                .Select(x => x.Split('-'))
                .Select(p => new { First = int.Parse(p[0]), Last = int.Parse(p.Last()) })
                .SelectMany(r => Enumerable.Range(r.First, r.Last - r.First + 1))
                .OrderBy(r => r)
                .Distinct();

            Console.WriteLine(result);
        }

        static void BishopMoves()
        {
            var result = Enumerable.Range('a', 8).SelectMany(x => Enumerable.Range('1', 8),
                    (f, r) => new { File = (char)f, Rank = (char)r })
                    .Select(x => new { x.File, x.Rank, dx = Math.Abs(x.File - 'c'), dy = Math.Abs(x.Rank - '6') })
                    .Where(x => x.dx == x.dy && x.dx != 0)
                    .Select(x => string.Format("{0}{1}", x.File, x.Rank));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void QueryExpressionExample()
        {
            var result = from row in Enumerable.Range('a', 8)
                         from col in Enumerable.Range('1', 8)
                         let dx = Math.Abs(row - 'c')
                         let dy = Math.Abs(col - '6')
                         where dx == dy && dx != 0
                         select string.Format("{0}{1}", (char)row, (char)col);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void LongestBook()
        {
            var books = new[] {
                new { Author = "Robert Martin", Title = "Clean Code", Pages = 464 },
                new { Author = "Oliver Sturm", Title = "Functional Programming in C#" , Pages = 270 },
                new { Author = "Martin Fowler", Title = "Patterns of Enterprise Application Architecture", Pages = 533 },
                new { Author = "Bill Wagner", Title = "Effective C#", Pages = 328 }
            };

            var mostPages = books.Max(x => x.Pages);
            var book = books.First(b => b.Pages == mostPages);

            Console.WriteLine(book);
        }

        static void LongestBookAggregate()
        {
            var books = new[] {
                new { Author = "Robert Martin", Title = "Clean Code", Pages = 464 },
                new { Author = "Oliver Sturm", Title = "Functional Programming in C#" , Pages = 270 },
                new { Author = "Martin Fowler", Title = "Patterns of Enterprise Application Architecture", Pages = 533 },
                new { Author = "Bill Wagner", Title = "Effective C#", Pages = 328 }
            };

            var book = books.Aggregate((agg, next) => next.Pages > agg.Pages ? next : agg);

            Console.WriteLine(book);
        }

        static void Main(string[] args)
        {
            //var customers = new[] {
            //    new{ Name = "Roberto", Email = "roberto@mail.com" },
            //       new{ Name = "mari", Email = "" },
            //     new{ Name = "Roberto1", Email = "roberto1@mail.com" },
            //      new{ Name = "Roberto2", Email = "roberto2@mail.com" },
            //       new{ Name = "Roberto3", Email = "roberto3@mail.com" },
            //       new{ Name = "mari1", Email = "" }

            //};

            //foreach (var customer in customers.Where(c => !string.IsNullOrEmpty(c.Email)))
            //{
            //    Console.WriteLine("Sending email to {0}", customer.Name);
            LongestBook();
            LongestBookAggregate();

            Console.Read();
        }
    }
}
