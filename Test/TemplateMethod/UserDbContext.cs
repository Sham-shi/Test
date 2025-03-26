
namespace Lessons.TemplateMethod;

public class UserDbContext : DbContext
{
    public override void OnConfiguring()
    {
        //...
    }

    public override void OnModelCreating()
    {
        //...
    }
}
