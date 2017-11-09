using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName="Item/Equipment")]
public class Equipment : Item {


    public EquipmentSlot EquipSlot;

    //Characteristics
}

public enum EquipmentSlot {
    Helm,
    Chest,
    Belt,
    Legs,
    Boots,
    Gloves,
    Back
}