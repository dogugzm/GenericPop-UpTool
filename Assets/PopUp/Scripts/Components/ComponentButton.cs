using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComponentButton : PopUpBaseComponent
{
    [SerializeField] Button buttonField;
    [SerializeField] TextMeshProUGUI textField;


    public override void SetCustomMethod(Action actionData)
    {
        base.SetCustomMethod(actionData);
        buttonField.onClick.AddListener(() => actionData.Invoke());
    }

    public override void WriteCustomData<TData>(TData data)
    {
        base.WriteCustomData(data);
        if (data is DataComponentButton dataComponentButton)
        {
            bool ignored = (bool)dataComponentButton.IsIgnored;
            GetComponent<LayoutElement>().ignoreLayout = ignored;
            if (ignored)
            {
                GetComponent<RectTransform>().SetAnchor(AnchorPresets.TopLeft);
                GetComponent<RectTransform>().SetPivot(PivotPresets.TopLeft);

                buttonField.GetComponent<Image>().sprite = Resources.Load<Sprite>(dataComponentButton.ButtonImage.Path); 

            }
            ColorUtility.TryParseHtmlString(dataComponentButton.Color, out Color color);
            buttonField.image.color = color;
            textField.text = dataComponentButton.Text;

            

        }

    }
}
