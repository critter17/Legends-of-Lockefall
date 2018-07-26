using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterSelector : MonoBehaviour {

    [SerializeField] private GameObject[] characters;

    public Button dracaButton;
    public Button frawdButton;
    public Button faeButton;
    public Button yekNomButton;
    public Button grizbyButton;
    public Button pokkitsButton;
    public Button pennyButton;

    private bool objectSelected;

    public PlayerStats[] characterStats;
    public FileSlot[] fileSlots;
    private int currentIndex = 0;

    public GameObject firstSelectedObject;
    EventSystem currentES;

    public Text characterName;
    public Text attackNumber;
    public Text defenseNumber;
    public Text heartsNumber;
    public Text weaponSlotNumber;

    private void OnEnable()
    {
        currentES = EventSystem.current;
        currentES.SetSelectedGameObject(firstSelectedObject.gameObject);
    }

    // Use this for initialization
    void Start () {
        attackNumber.text = characterStats[0].baseStrength.ToString();
        defenseNumber.text = characterStats[0].baseDefense.ToString();
        heartsNumber.text = characterStats[0].maxHealth.ToString();
        weaponSlotNumber.text = characterStats[0].weaponSlotAmount.ToString();
	}

    private void Update()
    {
        if(currentES.currentSelectedGameObject != null)
        {
            if(currentES.currentSelectedGameObject == dracaButton.gameObject)
            {
                Select(0);
            }
            else if(currentES.currentSelectedGameObject == frawdButton.gameObject)
            {
                Select(1);
            }
            else if(currentES.currentSelectedGameObject == faeButton.gameObject)
            {
                Select(2);
            }
            else if(currentES.currentSelectedGameObject == yekNomButton.gameObject)
            {
                Select(3);
            }
            else if(currentES.currentSelectedGameObject == grizbyButton.gameObject)
            {
                Select(4);
            }
            else if(currentES.currentSelectedGameObject == pokkitsButton.gameObject)
            {
                Select(5);
            }
            else if(currentES.currentSelectedGameObject == pennyButton.gameObject)
            {
                Select(6);
            }
            objectSelected = true;
        }
        characterName.text = characterStats[currentIndex].name;
        attackNumber.text = characterStats[currentIndex].baseStrength.ToString();
        defenseNumber.text = characterStats[currentIndex].baseDefense.ToString();
        heartsNumber.text = characterStats[currentIndex].maxHealth.ToString();
        weaponSlotNumber.text = characterStats[currentIndex].weaponSlotAmount.ToString();
    }

    public void Select(int newIndex)
    {
        if(newIndex >= 0 && newIndex < characters.Length)
        {
            currentIndex = newIndex;
        }
        //Debug.Log(currentIndex);
    }

    public void OnStartGameButton()
    {
        GameObject selectedCharacter = characters[currentIndex];
        Debug.Log("Loading next scene");
        SceneManager.LoadScene("TestingSandbox");
        GameManager.instance.SetupGame(currentIndex, selectedCharacter);
    }
}
