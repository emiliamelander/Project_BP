using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{

    public string sceneToLoad;

    
    public void StartGame()
    {
       
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Ja nu st�ngs ju spelet ner, det ser ju jag");
    }
}
