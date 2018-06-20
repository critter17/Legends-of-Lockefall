using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartMeter : MonoBehaviour {
    Image[] hearts;
    public GameObject heartPrefab;
    public Sprite fullHeart, heart1, heart2, heart3, emptyHeart;
    public GameObject player;

    private void Start()
    {
        player = GameManager.instance.playerManager.player;
    }

    private void OnEnable()
    {
        Debug.Log("Enable player?");
        player = GameManager.instance.playerManager.player;
    }

    public void ResetHealth()
    {
        hearts = GetComponentsInChildren<Image>();
        for(int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }

    // Update hearts to show the current amount of health.
    public void UpdateHearts(int numHearts, int numFullHearts, int remainderHearts)
    {
        hearts = GetComponentsInChildren<Image>();
        Debug.Log("Number of full hearts: " + numFullHearts);
        Debug.Log("Number of remainder hearts: " + remainderHearts);
        int i = 0;
        for(; i < numFullHearts; i++)
        {
            hearts[i].sprite = fullHeart;
        }

        if(numFullHearts == numHearts)
        {
            return;
        }

        switch(remainderHearts)
        {
            case 0:
                hearts[i].sprite = emptyHeart;
                break;

            case 1:
                hearts[i].sprite = heart3;
                break;

            case 2:
                hearts[i].sprite = heart2;
                break;

            case 3:
                hearts[i].sprite = heart1;
                break;

            default:
                break;
        }

        i++;

        for(; i < hearts.Length; i++)
        {
            hearts[i].sprite = emptyHeart;
        }
    }

    public void CreateHearts(int numHearts)
    {
        for(int i = 0; i < numHearts; i++)
        {
            GameObject newHeart;
            newHeart = Instantiate(heartPrefab);
            newHeart.name = "Heart";
            newHeart.transform.SetParent(gameObject.transform);
            newHeart.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            newHeart.SetActive(true);
        }
    }

    public void Unsubscribe()
    {
        Debug.Log("Hoere");
        player.GetComponent<PlayerHealthManager>().health.OnHPChanged -= UpdateHearts;
        player = null;
    }

    public void Subscribe()
    {
        player = GameManager.instance.playerManager.player;
        player.GetComponent<PlayerHealthManager>().health.OnHPChanged += UpdateHearts;
    }
}
