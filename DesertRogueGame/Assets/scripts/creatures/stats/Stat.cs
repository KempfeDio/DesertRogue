using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat {

    [SerializeField]
    private float baseValue;

    public float getValue() {
        return baseValue;
    }

    public void setValue(float newValue) {
        baseValue = newValue;
    }
    //FIXME
   /* public static Stat operator+(Stat s1, Stat s2) {
        Stat s3;
        return s3.setValue(s1.getValue() + s2.getValue());
    }

    public static Stat operator-(Stat s1, Stat s2) {
        Stat s3;
        return s3.setValue(s1.getValue() - s2.getValue());
    }*/

    
}
