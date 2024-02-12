
public class DataComponentInput 
{
    public DataComponentInput(DataComponentText? placeHolderTextData,
                              DataComponentText? settedTextData,
                              int? inputType = 0,
                              string? bGColor = "#E2E2E2")
    {
        InputType = inputType;
        PlaceHolderTextData = placeHolderTextData;
        SettedTextData = settedTextData;
        BGColor = bGColor;
    }
    public DataComponentText PlaceHolderTextData;
    public DataComponentText SettedTextData;


    public string? BGColor { get; private set; }
    public int? InputType { get;  private set; } //0 => Small , 1=> Big

}
