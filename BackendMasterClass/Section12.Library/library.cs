
public class library
{
    public library()
    {
        Categories = new Catagory[5];

	}
    public Catagory[] Categories { get; set; }

    private void Initial()
    {
        Categories[0] = new Catagory()
    }
}
