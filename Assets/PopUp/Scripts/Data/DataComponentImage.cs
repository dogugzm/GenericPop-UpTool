public class DataComponentImage
{
    public DataComponentImage(string? color = "#ffffff", string? url = "default_url", string? path = "default_path", bool? useUrl = false)
    {
        Color = color;
        Url = url;
        Path = path;
        UseUrl = useUrl;
    }

    public string? Color { get; private set; }
    public string? Url { get; private set; }
    public string? Path { get;  private set; }
    public bool? UseUrl { get; private set; }

}
