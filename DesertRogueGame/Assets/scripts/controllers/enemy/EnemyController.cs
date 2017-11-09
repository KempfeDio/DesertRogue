using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Controller {

	void Start () {
		
	}

	void Update () {
		if(isMyTurn) {
            //Do some stuff
            Debug.Log("Enemy's turn");
        }
	}
}
