using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_lesson;


[Table("software_updates")]
public class SoftwareUpdate
{
    [Column("id")]
    public int Id { get; set; }
    [Column("version")]
    public string Version { get; set; }
    [Column("release_date")]
    public DateTime ReleaseDate { get; set; }

    public Phone Phone { get; set; }
}