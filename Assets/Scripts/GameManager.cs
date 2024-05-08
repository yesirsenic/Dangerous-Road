using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool is_actived;
    public GameObject gameoverUI;
    public ParticleSystem explosion_Particle;


    private void Awake()
    {
        is_actived = true;
    }


}
