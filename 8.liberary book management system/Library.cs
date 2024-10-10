

namespace _8.liberary_book_management_system
{
    internal class Library
    {
        private Book[] books; 
        private int index = 0;

        public Library(int capacity)
        {
          books = new Book[capacity];
        }
        public void AddBook(Book book)
        {
            if (index < books.Length)
            {
                books[index] = book;
                index++;
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{books[i].Title} by {books[i].Author}");
            }
            
            
         
        }
    }
}
