using Microsoft.EntityFrameworkCore;

namespace EntityFramework_lesson;

public class Program
{
    public static void Main()
    {
        using var dbContext = new ApplicationDbContext();

        using var transaction = dbContext.Database.BeginTransaction();

        try
        {
            var phoneService = new PhoneService(dbContext);

            // Вызываем методы, которые выполняют операции с базой данных
            phoneService.AddPhones();
            phoneService.UpdatePhone();

            // Фиксируем все изменения вместе
            transaction.Commit();
            transaction.Commit();
        }
        catch (Exception)
        {
            // Откат всех изменений, если что-то пошло не так
            transaction.Rollback();
            throw;
        }
    }
}
