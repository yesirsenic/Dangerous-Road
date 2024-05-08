using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller: MonoBehaviour
{
    private float horsepower = 2500;
    private float turnSpeed = 85;
    private Rigidbody carRb;
    private GameManager gameManager;

    public GameObject camera1;
    public GameObject camera2;
    

    private void Start()
    {
        carRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        ChangeView();
        
    }

    private void FixedUpdate()
    {
        Car_Move_Input();
    }

    void Car_Move_Input()// player input arrowkey has to car movement that can work
    {
        float vertical_Input = Input.GetAxis("Vertical");
        float horizontal_Input = Input.GetAxis("Horizontal");

        carRb.AddRelativeForce(Vector3.forward * vertical_Input * horsepower);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontal_Input);
    }

    void ChangeView()// player view change by space key
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
    }

    

}
