using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public static PopUpManager Instance { get; set; }
    [SerializeField] Canvas canvas;
    public GameObject PopUpPrefab;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        CreateDialog<TestPopUp>();
    }

    // TODO: Created dialog needs to be in queue and control the flow.
    // it can also be an object pool
    /// <summary>
    /// Dialog creation data will come from actual dialog class.
    /// </summary>
    /// <typeparam name="TDialog">Dialog type that you want to create</typeparam>
    /// <typeparam name="TData">Dialog data class that you want to pass</typeparam>
    /// <param name="data">Actual data</param>
    /// <param name="onOkBtnClickEvent">OK Button click event</param>
    /// <param name="variantID">Factory paramater</param>
    /// <param name="parent">Factory parameter</param>
    public void CreateDialog<TDialog>() where TDialog : BasePopup
    {
        GameObject instantiatedDialog = Instantiate(PopUpPrefab, canvas.transform);
        instantiatedDialog.AddComponent<TDialog>();
    }

}
