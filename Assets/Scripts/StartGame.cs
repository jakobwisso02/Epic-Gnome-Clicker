using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string startGame = "GnomeClicker";

    public void StartTheGame()
    {
        SceneManager.LoadScene(startGame);
    }
    
}
