using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;
using LibraryApp.exceptions;

namespace LibraryApp
{
    internal class Library<T> where T : LibraryItem<T>
    {
        List<T> Items = new List<T>();

        public void Add(T item)
        {
            Items.Add(item);
        }


        public void ListItems()
        {
            Console.WriteLine("Knihovní předměty: ");
            foreach (T item in Items)
            {
                item.DisplayInfo();
            }

            
        }

        public void CheckoutItem(int id)
        {
            T itemToCheckout = Items.Find(i => i.Id == id);
            if (itemToCheckout != null)
            {
                if (itemToCheckout.IsAvailable)
                {
                    itemToCheckout.IsAvailable = false;
                    Console.WriteLine($"vypůjčil jsem si knížku: {itemToCheckout.Title}");
                }
                else
                {
                    throw new NotAvailableException($"Položka s ID ${itemToCheckout.Id} nebyla nalezena");
                }
            } else
            {
                throw new NotFoundException();
            }
        }
        public void ReturnItem(int id)
        {

        }
    }    
}
