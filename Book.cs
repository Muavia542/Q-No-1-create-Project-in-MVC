using System;

using System.Data.Entity;


namespace ClassWorkCRUD.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Theme { get; set; }
        public decimal Price { get; set; }
    }
    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }


}