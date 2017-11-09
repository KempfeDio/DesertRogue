using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "Creatures/Hero")]
public class Hero : Entity {


    public List<Item> backpack;
    public List<Equipment> equipment;
    public List<Talent> talents;

    /// <summary>
    /// Creates a hero with all the characteristics
    /// </summary>
    /// <param name="newName">Hero's name</param>
    /// <param name="newDescription">Hero's description</param>
    /// <param name="newImage">Hero's image</param>
    /// <param name="newStrength">Hero's strength</param>
    /// <param name="newAgility">Hero's agility</param>
    /// <param name="newItelligence">Hero's intelligence</param>
    /// <param name="newLuck">Hero's luck</param>
    /// <param name="newStamina">Hero's stamina</param>
    /// <param name="newAccuracy">Hero's accuracy</param>
    public Hero(string newName, string newDescription, Image newImage, Stat newStrength,
        Stat newAgility, Stat newItelligence, Stat newLuck, Stat newStamina, Stat newAccuracy, Stat newSpeed) {
        //Info
        creatureInfo._name = newName;
        creatureInfo._description = newDescription;
        creatureInfo._image = newImage;

        //Stats
        creatureStats.strength = newStrength;
        creatureStats.agility = newAgility;
        creatureStats.intelligence = newItelligence;
        creatureStats.luck = newLuck;
        creatureStats.stamina = newStamina;
        creatureStats.accuracy = newAccuracy;
        creatureStats.speed = newSpeed;

        //Size of Eqiupment slots
        equipment.Capacity = Enum.GetValues(typeof(EquipmentSlot)).Length;
    }
}
