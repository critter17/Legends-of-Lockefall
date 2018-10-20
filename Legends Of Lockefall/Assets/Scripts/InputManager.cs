using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    #region Singleton
    public static InputManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public event Action OnKeyboardInput = delegate { };

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal != 0 || vertical != 0)
        {
            OnKeyboardInput?.Invoke();
        }

        if(Input.GetButtonDown("Pause"))
        {
            if(GameManager.instance.gameData.spriteIndex != -1)
                GameManager.instance.TogglePause();
        }
    }
}
