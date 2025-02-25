using System.Text;

public class Book
{
	public string Title { get; set; }
	public string Author { get; set; }
	public string Code { get; set; }
	public string Description { get; set; }

	public string GetInfo()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("------------------------------------");
		sb.Append($"{Title} {Author} {Code}");
		sb.Append("------------------------------------");
		
		return sb.ToString();
	}
}
