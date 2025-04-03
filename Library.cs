using System.Collections.Generic;

namespace WpfApp1
{
    public class Library
    {
        public List<Book> FillLibrary()
        {
            return new List<Book>
            {
                new Book(1, "Книга 1", "Автор 1", 100, "Художественная", 1),
                new Book(2, "Книга 2", "Автор 2", 200, "Научная", 1)
            };
        }

        public void AddBook(List<Book> books, int id, string name, string authors, int pages, string category)
        {
            books.Add(new Book(id, name, authors, pages, category, 1));
        }

        public Book GetBook(List<Book> books, int id)
        {
            return books.Find(b => b.Id == id);
        }

        public void ChangeBookId(List<Book> books, int oldId, int newId)
        {
            var book = GetBook(books, oldId);
            if (book != null)
            {
                book.Id = newId;
            }
        }

        public void ChangeBooksState(List<Book> books, int id, int state)
        {
            var book = GetBook(books, id);
            if (book != null)
            {
                book.State = state;
            }
        }
    }
}