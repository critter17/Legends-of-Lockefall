using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemDescription : MonoBehaviour {
    public Text itemName;
    public Text itemDescription;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(EventSystem.current.currentSelectedGameObject == null)
        {
            return;
        }

        WeaponSlot weaponSlot = EventSystem.current.currentSelectedGameObject.GetComponent<WeaponSlot>();
        ArmorSlot armorSlot = EventSystem.current.currentSelectedGameObject.GetComponent<ArmorSlot>();
        DisposableSlot disposableSlot = EventSystem.current.currentSelectedGameObject.GetComponent<DisposableSlot>();
        ArtifactSlot artifactSlot = EventSystem.current.currentSelectedGameObject.GetComponent<ArtifactSlot>();
        EdibleSlot edibleSlot = EventSystem.current.currentSelectedGameObject.GetComponent<EdibleSlot>();

        if(weaponSlot && weaponSlot.weapon)
        {
            itemName.text = weaponSlot.weapon.itemName;
            itemDescription.text = weaponSlot.weapon.itemDescription;
        }
        else if(armorSlot && armorSlot.armor)
        {
            itemName.text = armorSlot.armor.itemName;
            itemDescription.text = armorSlot.armor.itemDescription;
        }
        else if(disposableSlot && disposableSlot.disposable)
        {
            itemName.text = disposableSlot.disposable.itemName;
            itemDescription.text = disposableSlot.disposable.itemDescription;
        }
        else if(artifactSlot && artifactSlot.artifact)
        {
            itemName.text = artifactSlot.artifact.itemName;
            itemDescription.text = artifactSlot.artifact.itemDescription;
        }
        else if(edibleSlot && edibleSlot.edible)
        {
            itemName.text = edibleSlot.edible.itemName;
            itemDescription.text = edibleSlot.edible.itemDescription;
        }
        else
        {
            itemName.text = "";
            itemDescription.text = "";
            //Debug.LogWarning("Selected Object is not an ItemSlot");
        }
	}
}
