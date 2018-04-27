using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Artifact")]
public class Artifact : Item {

    public override void ItemInteract(GameObject player)
    {
        PlayerInventory.instance.artifactInventory.AddArtifact(this);
    }
}
