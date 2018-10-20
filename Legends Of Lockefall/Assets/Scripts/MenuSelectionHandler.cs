using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class MenuSelectionHandler : MonoBehaviour {
    [SerializeField] private GameObject lastSelectedGameObject;

    private void Start()
    {
        //InputManager.instance.OnMouseInput += SelectObject;
        InputManager.instance.OnKeyboardInput += SelectObject;
    }

    private void OnDisable()
    {
        //InputManager.instance.OnMouseInput -= DeselectObject;
        InputManager.instance.OnKeyboardInput -= DeselectObject;
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
