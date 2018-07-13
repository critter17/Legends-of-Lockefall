using UnityEngine.EventSystems;
using UnityEngine;

public class SelectCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(EventSystem.current.currentSelectedGameObject != null)
        {
            //transform.localPosition = EventSystem.current.currentSelectedGameObject.transform.localPosition + new Vector3(0.0f, 64.0f, 0.0f);
        }
	}
}
