public class DataComponentButton
{
    public DataComponentButton(string? color = "#000000", string? text = "OKEY", bool? isIgnored = false, DataComponentImage? buttonImage = null)
    {
        Color = color;
        Text = text;
        IsIgnored = isIgnored;
        ButtonImage = buttonImage;  
    }
    public DataComponentImage ButtonImage { get; set; }
    public string? Color { get; private set; }
    public string? Text { get; private set; }
    public bool? IsIgnored { get; private set; }
}
