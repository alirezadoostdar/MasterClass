public class Path
{
    public int Code { get; set; }
    public string Source { get; set; }
    public string Destination { get; set; }

    public static Path ShirazToTehran()
    {
        var path = new Path();
        path.Code = 7121;
        path.Source = "Shiraz";
        path.Destination = "Tehran";
        return path;
    }
}
