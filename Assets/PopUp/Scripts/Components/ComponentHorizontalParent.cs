using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ComponentHorizontalParent : PopUpBaseComponent
{
    private const int totalWidth = 1000;
    //no data set
    private List<PopUpBaseComponent> childComponents = new List<PopUpBaseComponent>();
    private List<PopUpBaseComponent> childComponentsFromOutside = new List<PopUpBaseComponent>();

    float generalRatio;

    public void AddChild(PopUpBaseComponent component)
    {
        childComponents.Add(component);
        generalRatio = totalWidth - GetChildImageWidth();
        generalRatio -= (childComponents.Count - 1) * GetComponent<HorizontalLayoutGroup>().spacing;
        generalRatio /= childComponents.Count(component => component is ComponentText);

        foreach (PopUpBaseComponent child in childComponents)
        {
            if (child.TryGetComponent(out ComponentText componentDescription))
            {
                componentDescription.GetComponent<LayoutElement>().preferredWidth = generalRatio;               
            }
        }
    }

    public void SetListAndCheck(PopUpBaseComponent component)  
    {
        childComponentsFromOutside.Add(component);

        generalRatio = (totalWidth - (2 * GetComponent<HorizontalLayoutGroup>().padding.left)); //left - right padding
        generalRatio -= ((childComponentsFromOutside.Count(component => component is ComponentVerticalParent) - 1) * GetComponent<HorizontalLayoutGroup>().spacing); //spacing based on children
        generalRatio /= childComponentsFromOutside.Count(component => component is ComponentVerticalParent); //ratio for each child compponent.

        foreach (var child in childComponentsFromOutside)
        {
            if (child.TryGetComponent(out ComponentText componentText))
            {
                componentText.GetComponent<LayoutElement>().preferredWidth = generalRatio;
            }
        }
    }

    //grand children have some components.
    private float GetChildImageWidth()
    {
        float totalWidth = 0;
        foreach (PopUpBaseComponent child in childComponents)
        {
            if (child.TryGetComponent(out ComponentImage componentLogo))
            {
                totalWidth += componentLogo.GetComponent<RectTransform>().sizeDelta.x;
            }

        }
         return totalWidth;
    }
}
