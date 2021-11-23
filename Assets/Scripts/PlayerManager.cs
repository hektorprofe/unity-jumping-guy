using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }

    public Animator animator;
    public bool enemyCollision = false, grounded;
    float startY;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        grounded = transform.position.y == startY;
    }

    public void SetAnimation(string name)
    {
        animator.Play(name);
        if (name == "PlayerJump")
        {
            AudioManager.Instance.PlaySound("Jump");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            enemyCollision = true;
            GetComponent<BoxCollider2D>().enabled = false;
            AudioManager.Instance.StopMusic();
            AudioManager.Instance.PlaySound("Die");
        }
        else if (collider.tag == "Points") { 
            ScoreManager.Instance.IncreasePoints();
            AudioManager.Instance.PlaySound("Point");
        }
    }

}
