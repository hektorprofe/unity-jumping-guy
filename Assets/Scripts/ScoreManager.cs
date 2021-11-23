using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public Text pointsText;

    [SerializeField] private int points = 0;

    void Awake()
    {
        Instance = this;
    }

    public void IncreasePoints()
    {
        points++;
        pointsText.text = points.ToString();
    }

}
