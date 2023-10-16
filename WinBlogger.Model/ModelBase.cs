using WinBlogger.Model.Interfaces;

namespace WinBlogger.Model;

public abstract class ModelBase : IIdentifiableModel
{
	public int Id { get; set; }
}
