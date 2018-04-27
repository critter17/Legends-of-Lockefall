using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactSlot : ItemSlot {

    public Artifact artifact;

    private void Start()
    {

    }

    public void AddArtifact(Artifact newArtifact)
    {
        artifact = newArtifact;
        icon.sprite = artifact.itemSprite;
        icon.enabled = true;
    }

    public override void ClearSlot()
    {
        base.ClearSlot();
        artifact = null;
    }

    public void SelectArtifact()
    {
        artifact.InventoryItemAction();
    }
}
