using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour {

    [SerializeField] private GameObject[] characters;
    public PlayerStats[] characterStats;
    private int currentIndex = 0;

    public Text characterName;
    public Text attackNumber;
    public Text defenseNumber;
    public Text heartsNumber;
    public Text weaponSlotNumber;

	// Use this for initialization
	void Start () {
        attackNumber.text = characterStats[0].baseStrength.ToString();
        defenseNumber.text = characterStats[0].baseDefense.ToString();
        heartsNumber.text = characterStats[0].maxHealth.ToString();
        weaponSlotNumber.text = characterStats[0].weaponSlotAmount.ToString();
	}

    private void Update()
    {
        characterName.text = characterStats[currentIndex].name;
        attackNumber.text = characterStats[currentIndex].baseStrength.ToString();
        defenseNumber.text = characterStats[currentIndex].baseDefense.ToString();
        heartsNumber.text = characterStats[currentIndex].maxHealth.ToString();
        weaponSlotNumber.text = characterStats[currentIndex].weaponSlotAmount.ToString();
    }

    public void Select(int newIndex)
    {
        if(newIndex >= 0 || newIndex < characters.Length)
        {
            currentIndex = newIndex;
        }
        Debug.Log(currentIndex);
    }

    public void OnStartGameButton()
    {
        GameObject selectedCharacter = characters[currentIndex];
        Debug.Log(selectedCharacter.name);
        PlayerPrefs.SetInt("CharacterSelected", currentIndex);
        SceneManager.LoadScene("TestingSandbox");

    }
}
