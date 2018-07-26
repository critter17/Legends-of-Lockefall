using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonNavigation : MonoBehaviour {
    public float yOffset;
    EventSystem currentEventSystem;
	// Use this for initialization
	void Start () {
		
	}

    private void OnEnable()
    {
        currentEventSystem = EventSystem.current;
    }

    // Update is called once per frame
    void Update () {
		if(EventSystem.current.currentSelectedGameObject != null)
        {
            GameObject selectedObject = currentEventSystem.currentSelectedGameObject;
            float newYPos = selectedObject.transform.position.y + yOffset;
            transform.position = new Vector3(selectedObject.transform.position.x, newYPos, selectedObject.transform.position.z);
        }
	}
}
