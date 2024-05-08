using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject[] obstacle;

    private GameManager gameManager;
    private float start_Delay = 1.5f;
    private float spawn_Rate = 1.5f;
    private float present_Round;

    private void Start()
    {
        present_Round = PlayerPrefs.GetInt("round");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if(spawn_Rate >0.1f)
        {
            spawn_Rate -= 0.1f * (present_Round - 1);
        }
        StartCoroutine(Obstacle_Spawn_Period());
    }

    private void Obstacle_Spawn() // car and rock spawn at spawnPos, car and rock have spawn randomly
    {
        int random_Obstacle_Index;
        int random_Obstacle_SpawnPos_Index;
        GameObject spawn_Obstacle;
        Vector3 spawnPos;

        random_Obstacle_Index = Random.Range(0, obstacle.Length);
        random_Obstacle_SpawnPos_Index = Random.Range(0, spawnPoint.Length);

        spawn_Obstacle = obstacle[random_Obstacle_Index];
        spawnPos = spawnPoint[random_Obstacle_SpawnPos_Index].transform.position;

        Instantiate(spawn_Obstacle, spawnPos, spawn_Obstacle.transform.rotation);
    }

    IEnumerator Obstacle_Spawn_Period() // all obstacle spawn specific period
    {
        yield return new WaitForSeconds(start_Delay);

        while(gameManager.is_actived)
        {
            Obstacle_Spawn();

            yield return new WaitForSeconds(spawn_Rate);
        }
    }


}
