using System;
using UnityEngine;

public class PopUpBaseComponent : MonoBehaviour
{
    /// <summary>
    /// Action data for buttons or inputfields.
    /// </summary>
    /// <param name="actionData"></param>
    public virtual void SetCustomMethod(Action actionData)
    {

    }

    /// <summary>
    /// Class data to modify text,color etc.
    /// </summary>
    /// <typeparam name="TData">Your data class</typeparam>
    /// <param name="data"></param>
    public virtual void WriteCustomData<TData>(TData data)
    {

    }

    /// <summary>
    /// Add parameter action as child of this component.
    /// </summary>
    /// <param name="action">Child component</param>
    public void RunChildComponent(Action action)
    {
        action?.Invoke();
    }

}