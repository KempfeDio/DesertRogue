using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : ScriptableObject {

    public baseInfo creatureInfo;
    public baseStats creatureStats;
    public List<Ability> abilities;

    public void takeDamage(float damage) {

        Debug.Log(creatureInfo._name + " taking " + damage + " damage.");

        if (creatureStats.currentHealth.getValue() <= 0) {
            Die();
        }
    }

    /// <summary>
    /// 
    /// Virtual method
    /// </summary>
    public virtual void Die() {
        Debug.Log(creatureInfo._name + " died");
    }
}
