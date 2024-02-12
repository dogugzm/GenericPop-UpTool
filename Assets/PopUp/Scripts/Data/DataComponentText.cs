
public class DataComponentText
{
#nullable enable
    public DataComponentText(string? text = "TestText",
                             float? fontSize = 60f,
                             string? color = "#000000",
                             float? alpha = 1f,
                             int? alignmentOption = 514,
                             int? style = 0)
    {
        Text = text;
        FontSize = fontSize;
        Color = color;
        Alpha = alpha;
        AlignmentOption = alignmentOption;
        Style = style;
    }

    public string? Text { get; private set;}
    public float? FontSize { get;  private set;}
    public string? Color { get;  private set;}
    public float? Alpha { get;  set;}
    public int? AlignmentOption { get;  private set;} //TextAlignmentOptions enum
    public int? Style { get;  private set;}  //FontStyles enum
}
