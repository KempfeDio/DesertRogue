using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "Item/Item")]
public abstract class Item : ScriptableObject {

    public string itemName;
    public string itemDescription;

    public Image itemImage;
}
