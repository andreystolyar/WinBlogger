using System.ComponentModel.DataAnnotations;

namespace WinBlogger.Model;

public class Post : ModelBase
{
  [StringLength(50)]
  public string? Title { get; set; }

  [StringLength(10_000)]
  public string Text { get; set; }

  public DateTime Created { get; set; }

  public int BlogId { get; set; }

  public Blog Blog { get; set; }

  public List<Comment>? Comments { get; set; }
}
