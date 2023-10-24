using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinBlogger.Model;

public class Blog : ModelBase
{
  [StringLength(50)]
  public string Title { get; set; }

  [StringLength(1000)]
  public string? Description { get; set; }

  public Blogger Author { get; set; }

  [ForeignKey(nameof(Blogger))]
  public int BloggerId { get; set; }

  public List<Post>? Posts { get; set; }
}
