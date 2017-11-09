using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuButtonManager : MonoBehaviour {

	public void newGameClick(string level) {
        SceneManager.LoadScene(level);
    }

    public void exitGameClick() {
        Application.Quit();
    }
}
