using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    private Vector3 offset = new Vector3(0,5,-7);
    private Vector3 change_Offset = new Vector3(0, 3, 0.5f);

    public bool is_Ohtercamera;

    public GameObject car;

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void LateUpdate()
    {
        CameraSetting();
        
    }

    void CameraSetting() // first and second camera setting in script and hierachy
    {
        if (is_Ohtercamera)
        {
            transform.position = car.transform.position + change_Offset;

        }

        else
        {
            transform.position = car.transform.position + offset;
        }
    }

}
