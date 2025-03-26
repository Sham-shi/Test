
namespace Lessons.TemplateMethod;

public class ProductDbContext : DbContext
{
    public ProductDbContext() : base()
    {

    }

    public override void OnConfiguring()
    {
        //...
    }

    public override void OnModelCreating()
    {
        //...
    }
}
