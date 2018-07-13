using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ThisButton : Selectable {
    [SerializeField] SelectCursor cursor;
    public BaseEventData baseEvent;

    // Update is called once per frame
    void Update () {
		if(IsHighlighted(baseEvent))
        {
            if(cursor)
            {
                cursor.transform.localPosition = transform.localPosition + new Vector3(0.0f, 64.0f, 0.0f);
            }
        }
	}
}
