using Microsoft.EntityFrameworkCore;



//e ticaret sitesi
    public class ECommerceDbContext : DbContext
    {
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    //hangi db bağlanacağımızı belirtmek için ayarları oluşturdugumuz kısım
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=10.239.5.34;Database=TestDb;User Id=testuser;Password=123456;TrustServerCertificate=True");
    }
}
//Entity (urunlerle alakalı olan entity)
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
}

//Entity (musterilerle alakalı olan entity)
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}