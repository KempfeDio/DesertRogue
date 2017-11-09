using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Controller {

#region Singleton
    private static Actor instance;

    private Actor() {}

    public static Actor getInstance() {
        if(instance == null) {
            instance = new Actor();
        }
        return instance;
    }
#endregion

    void Start () {
		
	}

    void Update() {
        if (isMyTurn) {
            //Do some staff
            Debug.Log("Player's turn");
        }
    }
}
