using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposableSlot : ItemSlot {

    public Disposable disposable;

    private void Start()
    {

    }

    public void AddDisposable(Disposable newDisposable)
    {
        disposable = newDisposable;
        icon.sprite = disposable.itemSprite;
        icon.enabled = true;
    }

    public override void ClearSlot()
    {
        base.ClearSlot();
        disposable = null;
    }

    public void SelectDisposable()
    {
        disposable.InventoryItemAction();
    }
}
