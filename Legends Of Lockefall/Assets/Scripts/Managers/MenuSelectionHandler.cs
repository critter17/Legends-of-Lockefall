using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuSelectionHandler : MonoBehaviour {
    [SerializeField] private GameObject lastSelectedGameObject;

    private void Start()
    {
        InputManager.instance.OnKeyboardInput += SelectObject;
        InputManager.instance.OnMouseInput += DeselectObject;
    }

    private void OnDisable()
    {
        InputManager.instance.OnKeyboardInput -= SelectObject;
        InputManager.instance.OnMouseInput -= DeselectObject;
    }

    public virtual void SelectObject()
    {
        if(gameObject.activeSelf == true && EventSystem.current.currentSelectedGameObject == null)
            EventSystem.current.SetSelectedGameObject(lastSelectedGameObject);
    }

    public virtual void DeselectObject()
    {
        if(gameObject.activeSelf == true && EventSystem.current.currentSelectedGameObject != null)
        {
            lastSelectedGameObject = EventSystem.current.currentSelectedGameObject;
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}
