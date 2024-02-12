using System;
using UnityEngine;

public class BasePopup : MonoBehaviour
{
    protected PopUpScheme popUpScheme;

    public static event Action<BasePopup> DialogInitialized;
    public static event Action<BasePopup> DialogDestroyed;

    protected void Awake()
    {
        popUpScheme = GetComponent<PopUpScheme>();
    }

    protected virtual void OnEnable()
    {
        DialogInitialized?.Invoke(this);
    }
    protected virtual void OnDisable()
    {
        DialogDestroyed?.Invoke(this);
    }

    /// <summary>
    /// Create component based on parent parameter.
    /// </summary>
    /// <param name="pInstantiatedObject">Prefab to insantiate</param>
    /// <param name="parent">If null prefab will be instantiated on main root.</param>
    /// <returns></returns>
    protected virtual PopUpBaseComponent CreateComponent(GameObject pInstantiatedObject, Transform? parent = null)
    {
        if (parent == null)
        {
            parent = popUpScheme.MainHolder;
        }
        return InstantiateComponent(pInstantiatedObject, parent);
    }

    /// <summary>
    /// Actual instantiation
    /// </summary>
    /// <param name="pInstantiatedObject"></param>
    /// <param name="parent"></param>
    /// <returns></returns>
    private PopUpBaseComponent InstantiateComponent(GameObject pInstantiatedObject, Transform parent)
    {
        GameObject instantiatedComponent = Instantiate(pInstantiatedObject, parent);
        PopUpBaseComponent myComponent = instantiatedComponent.GetComponent<PopUpBaseComponent>();

        DecideChildSize(parent, myComponent);

        return myComponent;
    }

    //TODO: It can be moved to the component itself.
    /// <summary>
    /// Auto resize child object on every instantiation.
    /// </summary>
    /// <param name="parent"></param>
    /// <param name="myComponent"></param>
    private static void DecideChildSize(Transform parent, PopUpBaseComponent myComponent)
    {
        if (parent.TryGetComponent(out ComponentHorizontalParent horizontalParent))
        {
            if (myComponent.TryGetComponent(out ComponentVerticalParent VParent))
            {
                horizontalParent.SetListAndCheck(myComponent);
            }
            if (!myComponent.TryGetComponent(out ComponentHorizontalParent HParent))
            {
                horizontalParent.AddChild(myComponent);
            }
        }
        else if (parent.GetComponentInParent<ComponentHorizontalParent>() != null)
        {
            parent.GetComponentInParent<ComponentHorizontalParent>().SetListAndCheck(myComponent);
        }
    }

}
