using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleManager : MonoBehaviour {

    Actor actor;
    EnemyController enemy;

    [HideInInspector]
    public int turns;

    public Text turnDisplay;

    private void Start() {
        actor = Actor.getInstance();
        //find enemy
    }

    private void Update() {
        if(!actor.isMyTurn && !enemy.isMyTurn) {
            compareSpeed();
        }
    }

    private void compareSpeed() {
        float actorSpeed = 0f;
        float enemySpeed= 0f;

        
        for(int i = 0; i < actor.heroes.Count; i++) {
            actorSpeed += actor.heroes[i].creatureStats.speed.getValue();
        }

        for(int i = 0; i < enemy.heroes.Count; i++) {
            enemySpeed += enemy.heroes[i].creatureStats.speed.getValue();
        }

        //Compare
        if(actorSpeed > enemySpeed) { //Actor's turn
            actor.isMyTurn = true;
            enemy.isMyTurn = false;
        } else if(actorSpeed == enemySpeed) { //Actor's turn
            actor.isMyTurn = true;
            enemy.isMyTurn = false;
        } else {                      //Enemy's turn
            enemy.isMyTurn = true;
            actor.isMyTurn = false;
        }
    }

}
