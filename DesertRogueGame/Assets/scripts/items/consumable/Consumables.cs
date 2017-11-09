using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Item/Consumables")]
public abstract class Consumables : Item {

    public int itemCost;

    public abstract void itemUse();
}
