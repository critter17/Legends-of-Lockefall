using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TitleMenu : MonoBehaviour {
    public Button playButton;
    public Button settingsButton;
    public Button quitButton;

    // Use this for initialization
    void Start () {
        EventSystem.current.SetSelectedGameObject(playButton.gameObject);
    }
}
