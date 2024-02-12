using UnityEngine;

public class PopUpScheme : MonoBehaviour
{
    [Header("HOLDERS")]
    public Transform MainHolder;
    public GameObject VerticalComponentParent;
    public GameObject HorizontalComponentParent;
    public Transform HorizontalButtonParent;
    public Transform VerticalButtonParent;
    [Header("COMPONENTS")]
    public GameObject ComponentButton;
    public GameObject ComponentDescription;
    public GameObject ComponentTitle;
    public GameObject ComponentImage;
    public GameObject ComponentInput;

    public void ActivateButtonParentObject(ButtonAlignment alignmentType)
    {
        if (alignmentType is ButtonAlignment.Horizontal)
        {
            HorizontalButtonParent.gameObject.SetActive(true);
            HorizontalButtonParent.SetAsLastSibling();
        }
        else if (alignmentType is ButtonAlignment.Vertical)
        {
            VerticalButtonParent.gameObject.SetActive(true);
            VerticalButtonParent.SetAsLastSibling();
        }
    }

}

public enum ButtonAlignment
{
    Horizontal,
    Vertical
}
