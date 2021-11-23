using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }

    public Animator animator;
    public bool enemyCollision = false;

    void Awake()
    {
        Instance = this;
    }

    public void SetAnimation(string name)
    {
        animator.Play(name);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            enemyCollision = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (collider.tag == "Points") { 
            ScoreManager.Instance.IncreasePoints();
        }
    }

}
