using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    
    public void endOfGame()
    {
        //Debug.Log("HIT");
        Application.Quit();
        SceneManager.LoadScene("fps");
    }
}
