using Microsoft.EntityFrameworkCore;

namespace EntityFramework_lesson;

public class Program
{
    public static void Main()
    {
        var phone = new Phone()
        {
            Name = "Xiaomi Poco F4",
            Price = 25000
        };

        using var dbContext = new ApplicationDbContext();
        dbContext.Phones.Add(phone);
        dbContext.SaveChanges();
    }
}
