using UnityEngine;
using UnityEngine.EventSystems;

public class SwitchCanvas : MonoBehaviour {
    public GameObject canvasToSwitchFrom;
    public GameObject canvasToSwitchTo;
    public GameObject firstObject;

	public void Switch()
    {
        canvasToSwitchFrom.SetActive(false);
        canvasToSwitchTo.SetActive(true);
        EventSystem.current.SetSelectedGameObject(firstObject);
    }
}
