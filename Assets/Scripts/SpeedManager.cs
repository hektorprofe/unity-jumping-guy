using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public static SpeedManager Instance { get; private set; }

    public float gameSpeedInc = 0.25f, gameSpeedTimer = 6f;

    void Awake()
    {
        Instance = this;
    }

    public void StartSpeedIncrease()
    {
        InvokeRepeating("IncreaseSpeed", gameSpeedTimer, gameSpeedTimer);
    }

    public void ResetSpeed() 
    {
        Time.timeScale = 1f;
        CancelInvoke("IncreaseSpeed");
    }

    void IncreaseSpeed()
    {
        Time.timeScale += gameSpeedInc;
    }
}
