using System.ComponentModel.DataAnnotations.Schema;

namespace WinBlogger.Model;

public class Blog : ModelBase
{
  public Blogger Author { get; set; }

  [ForeignKey(nameof(Blogger))]
  public int BloggerId { get; set; }
}
