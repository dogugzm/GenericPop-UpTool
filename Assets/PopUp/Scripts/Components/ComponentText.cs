using TMPro;
using UnityEngine;

public class ComponentText : PopUpBaseComponent
{
    [SerializeField] private TextMeshProUGUI textBox;

    public override void WriteCustomData<TData>(TData data)
    {
        base.WriteCustomData(data);
        if (data is DataComponentText dataComponentText)
        {
            textBox.text = dataComponentText.Text;
            textBox.fontSize = (float)dataComponentText.FontSize;
            ColorUtility.TryParseHtmlString(dataComponentText.Color, out Color color);
            textBox.color = new Color(color.r, color.g, color.b, (float)dataComponentText.Alpha);
            textBox.alignment = (TextAlignmentOptions)dataComponentText.AlignmentOption;
            textBox.fontStyle = (FontStyles)dataComponentText.Style;
        }


    }

}
