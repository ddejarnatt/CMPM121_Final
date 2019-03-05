using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenControl : MonoBehaviour{

    //reload game
    public void PlayAgain(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //quit game
    public void QuitGame(){
    	Application.Quit();
    }
}
