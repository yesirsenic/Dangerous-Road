using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip buttonClick_Clip;
    public AudioClip goalPoint_Arrive_Clip;
    public AudioClip car_Crash_Clip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonClick()
    {
        audioSource.clip = buttonClick_Clip;
        audioSource.Play();
    }

    public void Goal_Arrive()
    {
        audioSource.clip = goalPoint_Arrive_Clip;
        audioSource.Play();
    }

    public void Car_Crash()
    {
        audioSource.clip = car_Crash_Clip;
        audioSource.Play();
    }
}
