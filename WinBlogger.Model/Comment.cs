using System.ComponentModel.DataAnnotations;

namespace WinBlogger.Model;

public class Comment : ModelBase
{
  public int? BloggerId { get; set; }

  public int PostId { get; set; }

  public Blogger? Author { get; set; }

  public Post Post { get; set; }

  [StringLength(1000)]
  public string Text { get; set; }

  public DateTime Created { get; set; }
}
