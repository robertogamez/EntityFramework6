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

        static void CheckOrdersForRefunds()
        {
            List<Order> orders = new List<Order>()
            {
                new Order{ Id = 123, Amount = 29.95m, CustomerName = "Mark", Status = "Delivered" },
                new Order{ Id = 456, Amount = 45.00m, CustomerName = "Mark", Status = "Refunded" },
                new Order{ Id = 768, Amount = 32.50m, CustomerName = "Mark", Status = "Delivered" }
            };

            bool anyRefunded = orders.Any(o => o.Status == "Refunded");
            bool allDelivered = orders.All(o => o.Status == "Delivered");

            Console.WriteLine("Any: {0}, Delivered: {1}", anyRefunded, allDelivered);
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
            //}
            GetListOfFileSizes();

            Console.ReadLine();
        }
    }
}
