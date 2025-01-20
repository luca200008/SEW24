using _14_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Libary
{
    internal class Liabary
    {
        private Book[] bookList = new Book[1000];
        private int nrOfBooks = 0;

        public Liabary()
        {

        }
        public void AddBook(Book book)
        {
            if (nrOfBooks < 1000)
            {
                bookList[nrOfBooks] = book;
                nrOfBooks++;
            }
        }
        public void PrintBookList()
        {
            for (int i = 0; i < nrOfBooks; i++)
            {
                Console.WriteLine(bookList[i].Info);
            }
        }
        public void BorrowBook(Book book)
        {
            for (int i = 0; i < nrOfBooks; i++)
            {
                if (bookList[i] == book)
                {
                    bookList[i].Available = false;
                }
            }

        }
        public void ReturnBook(Book book)
        {
            for (int i = 0; i < nrOfBooks; i++)
            {
                if (bookList[i] == book)
                {
                    bookList[i].Available = true;
                }
            }
        }
        public void BringAvailableList()
        {
            Console.WriteLine("Verfügbare Bücher: ");
            for (int i = 0; i < nrOfBooks; i++)
            {
                if (bookList[i].Available)
                {
                    Console.WriteLine(bookList[i].Info);
                }
            }
        }
        public void PrintBorrowedBookList()
        {
            Console.WriteLine("Ausgeborgte Bücher: ");
            for (int i = 0; i < nrOfBooks; i++)
            {
                if (!bookList[i].Available)
                {
                    Console.WriteLine(bookList[i].Info);
                }
            }
        }
    }
}