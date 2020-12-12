using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> queue = new Queue<Customer>();

            queue.Enqueue(new Customer { Name = "Staszek" });
            queue.Enqueue(new Customer { Name = "Tomek" });
            queue.Enqueue(new Customer { Name = "Marta" });
            queue.Enqueue(new Customer { Name = "Jonas" });
            queue.Enqueue(new Customer { Name = "Piotrek" });
            queue.Enqueue(new Customer { Name = "Andrzej" });

           
            while (queue.Count>0)
            {
                var customer = queue.Dequeue();
                Console.WriteLine(customer.Name);
                Console.WriteLine("Ilość w kolejce: " + queue.Count);
            }

            Stack<Book> stack = new Stack<Book>();

            stack.Push(new Book { Name = "Harry Potter 1" });
            stack.Push(new Book { Name = "Harry Potter 2" });
            stack.Push(new Book { Name = "Harry Potter 3" });
            stack.Push(new Book { Name = "Harry Potter 4" });
            stack.Push(new Book { Name = "Harry Potter 5" });
            stack.Push(new Book { Name = "Harry Potter 6" });

            
            while (stack.Count > 0)
            {
                var book = stack.Pop();
                Console.WriteLine(book.Name);
                Console.WriteLine("Ilość na stosie: " + stack.Count);
            }
        }
    }
}
