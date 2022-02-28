using System.Data.Entity;

namespace BookStore_Miheev.Models
{
    public class BookDbInitializer:DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "War and piece", Author = "Толстой", Price = 20 });
            db.Books.Add(new Book { Name = "Dads and childrens", Author = "Тургенев", Price = 30 });
            db.Books.Add(new Book { Name = "Gull", Author = "Чехов", Price = 50 });
            db.Books.Add(new Book { Name = "Game of thrones", Author = "Martin", Price = 40 });
            base.Seed(db);
        }
    }
}
