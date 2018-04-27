using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FileSlot : MonoBehaviour {
    public bool isNewGame = true;
    public Button newGameButton;
    public Button startGameButton;
    public Text fileText;

    private void OnEnable()
    {
        if(isNewGame)
        {
            newGameButton.gameObject.SetActive(true);
            startGameButton.gameObject.SetActive(false);
        }
        else
        {
            startGameButton.gameObject.SetActive(true);
            newGameButton.gameObject.SetActive(false);
        }
    }
}
