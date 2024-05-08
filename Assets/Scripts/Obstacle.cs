using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody obstacleRb;
    private Vector3 obstacle_Vector;
    private float gravity_Velocity = -9.8f;
    private float speed = 35f;

    private GameManager gameManager;
    private SoundManager soundManager;
    

    



    private void Start()
    {
        obstacleRb = GetComponent<Rigidbody>();
        obstacle_Vector = Vector3.back * speed;
        obstacle_Vector.y = gravity_Velocity;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    private void FixedUpdate()
    {
        Obstacle_Move();
    }


    void Obstacle_Move() // obstacle move player opposite direction
    {
        obstacleRb.velocity = obstacle_Vector;
    }

    private void OnCollisionEnter(Collision collision) // if obstacle collide player, the obstacle get destroy and player state have gameover
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gameManager.is_actived = false;
            gameManager.explosion_Particle.Play();
            gameManager.gameoverUI.SetActive(true);
            soundManager.Car_Crash();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Destroy_Point"))
        {
            Destroy(gameObject);
        }
    }

}
