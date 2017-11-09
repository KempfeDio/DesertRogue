using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : ScriptableObject {

    public baseInfo abilityInfo;

    public enum abilityType {

    }

    public abilityType abType;

    /// <summary>
    /// Using ability
    /// Don't forget about 'override' buddy
    /// </summary>
    public virtual void useAbility() {

        Debug.Log(abilityInfo._name + " has used");
    }
	
}
