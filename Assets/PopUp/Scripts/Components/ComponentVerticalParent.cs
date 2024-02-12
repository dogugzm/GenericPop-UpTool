using System.Collections.Generic;
using UnityEngine;

public class ComponentVerticalParent : PopUpBaseComponent
{
    private const int totalWidth = 1000;
    //no data set
    private List<PopUpBaseComponent> childComponents = new List<PopUpBaseComponent>();

    float generalRatio;

    public void AddChild(PopUpBaseComponent component)
    {
        childComponents.Add(component);

        //TODO: width needs to be setted.

        //int textCount = childComponents.Count(component => component is ComponentText);
        //textCount = textCount == 0 ? 1 : textCount;
        //generalRatio = (totalWidth / textCount);

        //foreach (MyComponent child in childComponents)
        //{
        //    if (child.TryGetComponent(out ComponentText componentDescription))
        //    {
        //        componentDescription.GetComponent<LayoutElement>().preferredWidth = generalRatio;
        //    }

        //}

    }

    //private float GetChildLogoWidth()
    //{
    //    float totalWidth = 0;
    //    foreach (MyComponent child in childComponents)
    //    {
    //        if (child.TryGetComponent(out ComponentImage componentLogo))
    //        {
    //            totalWidth += componentLogo.GetComponent<RectTransform>().sizeDelta.x;
    //        }

    //    }
    //    return totalWidth;
    //}


}
