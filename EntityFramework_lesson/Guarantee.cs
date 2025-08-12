using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_lesson;
public class Guarantee
{
    [Key, ForeignKey(nameof(Phone))]
    [Column("phone_id")]
    public int PhoneId { get; set; }
    [Column("months")]
    public int Months { get; set; }

    public Phone Phone { get; set; } = null!;
}
