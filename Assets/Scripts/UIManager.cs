using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   
    public Text roundText;

 


    private void Start()
    {
        RoundUpdate();
    }

    private void RoundUpdate() // Round text update that player play next round
    {
        if (roundText == null)
            return;

        int round = PlayerPrefs.GetInt("round");
        

        roundText.text = "Round: " + round;
    }

    public void Restart() // game restart
    {
        PlayerPrefs.SetInt("round", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Move_Mainmenu() // go mainmenu that appear gamemenu UI in screen
    {
        SceneManager.LoadScene("Mainmenu");

    }

    public void GameStart() // game start button in mainmenu
    {
        PlayerPrefs.SetInt("round", 1);
        SceneManager.LoadScene("Dangerous Road");
    }

    public void GameExit() // game exit button in mainmenu
    {
        Application.Quit();
    }

}
