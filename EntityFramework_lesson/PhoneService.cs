namespace EntityFramework_lesson;

public class PhoneService
{
    private readonly ApplicationDbContext _dbContext;

    public PhoneService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddPhones()
    {
        _dbContext.Phones.Add(new Phone { Name = "SmartPhone Qwerty X Pro" });
        _dbContext.Phones.Add(new Phone { Name = "SmartPhone Qwerty Y Max" });
        _dbContext.SaveChanges(); // Сохраняем изменения внутри метода
    }

    public void UpdatePhone()
    {
        var phoneToUpdate = _dbContext.Phones
            .FirstOrDefault(p => p.Name == "SmartPhone Qwerty X Pro");

        if (phoneToUpdate != null)
        {
            phoneToUpdate.Name = "SmartPhone Qwerty X Pro Turbo";
            _dbContext.SaveChanges(); // Сохраняем изменения внутри метода
        }
    }
}
