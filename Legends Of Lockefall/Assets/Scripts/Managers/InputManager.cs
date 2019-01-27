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
    public event Action OnMouseInput = delegate { };
    public event Action OnControllerInput = delegate { };

    private void Start()
    {

    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if(horizontal != 0 || vertical != 0)
        {
            OnKeyboardInput?.Invoke();
        }

        if(mouseX != 0 || mouseY != 0)
        {
            OnMouseInput?.Invoke();
        }

        if(Input.GetButtonDown("Pause"))
        {
            if(GameManager.instance.gameData.spriteIndex != -1)
                GameManager.instance.TogglePause();
        }
    }
}
