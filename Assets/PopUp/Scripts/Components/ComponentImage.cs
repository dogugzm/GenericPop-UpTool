using UnityEngine;
using UnityEngine.UI;

public class ComponentImage : PopUpBaseComponent
{
    [SerializeField] Image imageField;
    //path veya url

    public override void WriteCustomData<TData>(TData data)
    {
        base.WriteCustomData(data);
        if (data is DataComponentImage componentImage)
        {
            Sprite sprite = null;
            if ((bool)componentImage.UseUrl)
            {
                //get from server
            }
            else
            {
                sprite = Resources.Load<Sprite>(componentImage.Path);
            }

            imageField.sprite = sprite;
            imageField.type = Image.Type.Simple;
            imageField.SetNativeSize();

            ColorUtility.TryParseHtmlString(componentImage.Color, out Color color);
            imageField.color = color;
        }
    }



}