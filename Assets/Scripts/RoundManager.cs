using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundManager : MonoBehaviour
{
    GameManager gameManager;
    SoundManager soundManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && gameManager.is_actived == true) // if player trigger goal point and not gameover state, player can play next round
        {
            int round = PlayerPrefs.GetInt("round") + 1;
            PlayerPrefs.SetInt("round", round);
            soundManager.Goal_Arrive();
            nextRound_Init_();
        }
    }

    private void nextRound_Init_() // scene init for play nextround
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
