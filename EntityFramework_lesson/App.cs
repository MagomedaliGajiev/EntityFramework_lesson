using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_lesson;

[Table("apps")]
public class App
{
    [Column("id")]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; }

    public List<Phone> Phones { get; set; }
}