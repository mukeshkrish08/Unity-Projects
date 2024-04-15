using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UnityEngine.UI namespace is a part of the Unity game engine
using UnityEngine.SceneManagement; // The "UnityEngine.SceneManagement" namespace provides functionality for managing scenes in Unity.

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")]
    public void addScore(int scoreTadd)
    {
        playerScore = playerScore + scoreTadd;
        scoreText.text = playerScore.ToString(); 
        //scoreText is the variable representing the UI Text component, and .text is accessing the text property of that component.
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver() 
    {
        gameOverScreen.SetActive(true);
    }
}
