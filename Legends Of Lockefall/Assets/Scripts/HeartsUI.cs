using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour {

    Image[] hearts;
    public GameObject heartPrefab;
    public Sprite fullHeart, emptyHeart;

    private void Start()
    {
        Debug.Log("Now Active");
    }

    public void UpdateHearts(int currentHealth)
    {
        hearts = GetComponentsInChildren<Image>();
        Debug.Log("Hearts length: " + hearts.Length);

        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

    public void CreateHeart()
    {
        GameObject newHeart;
        newHeart = Instantiate(heartPrefab);
        newHeart.name = "Heart";
        newHeart.transform.SetParent(gameObject.transform);
        newHeart.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        newHeart.SetActive(true);
    }
}
