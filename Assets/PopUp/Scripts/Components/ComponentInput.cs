using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComponentInput : PopUpBaseComponent
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] Image inputFieldImage;

    [SerializeField] GameObject placeholderText;
    [SerializeField] GameObject realText;

    [SerializeField] private Sprite smallSprite;
    [SerializeField] private Sprite bigSprite;

    public string GetInput()
    {
        return inputField.text;
    }

    public override void WriteCustomData<TData>(TData data)
    {
        base.WriteCustomData(data);

        if (data is DataComponentInput dataComponentInput)
        {
            if (dataComponentInput.InputType is (int?)InputFieldType.SMALL)
            {
                inputFieldImage.sprite = smallSprite;
            }
            else if (dataComponentInput.InputType is (int?)InputFieldType.BIG)
            {
                inputFieldImage.sprite = bigSprite;
            }
            inputFieldImage.type = Image.Type.Simple;
            inputFieldImage.SetNativeSize();

            placeholderText.TryGetComponent(out ComponentText placText);
            realText.TryGetComponent(out ComponentText reText);

            dataComponentInput.PlaceHolderTextData.Alpha = 0.5f;

            placText.WriteCustomData(dataComponentInput.PlaceHolderTextData);
            reText.WriteCustomData(dataComponentInput.SettedTextData);

            ColorUtility.TryParseHtmlString(dataComponentInput.BGColor,out Color color);
            inputFieldImage.color = color;
        }

    }

}

public enum InputFieldType
{
    SMALL = 0,
    BIG = 1
}
