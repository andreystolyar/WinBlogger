namespace WinBlogger.Model;

public class Blogger
{
	public string Nickname { get; set; }

	public string? FullName { get; set; }

	public Blog? Blog { get; set; }

	public Stream? Avatar { get; set; }
}
