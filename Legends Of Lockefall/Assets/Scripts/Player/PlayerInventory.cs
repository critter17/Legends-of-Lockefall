using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    #region Singleton
    public static PlayerInventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of PlayerInventory");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Weapon> weaponList;
    public List<Edible> consumableList;

    private WeaponController weaponController;

    public int itemSpace = 60;

    private void Start()
    {
        weaponList = new List<Weapon>();
        consumableList = new List<Edible>();
        weaponController = GetComponentInChildren<WeaponController>();
    }

    public bool AddWeapon(Weapon newWeapon)
    {
        if(weaponList.Count >= itemSpace)
        {
            Debug.Log("Not enough space");
            return false;
        }
        Debug.Log("Adding weapon");
        weaponList.Add(newWeapon);

        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

        return true;
    }

    public void RemoveWeapon(Weapon weaponToRemove)
    {
        weaponList.Remove(weaponToRemove);

        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
