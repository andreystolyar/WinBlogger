using System.ComponentModel.DataAnnotations;

namespace WinBlogger.Model;

public class Blogger : ModelBase
{
	[StringLength(50)]
	public string Nickname { get; set; }

	[StringLength(100)]
	public string? FullName { get; set; }

	public Blog? Blog { get; set; }

	[StringLength(10)]
	public string? Avatar { get; set; }
}
