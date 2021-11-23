using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState { Ready, Playing};

public class GameManager : MonoBehaviour
{
    public GameState gameState = GameState.Ready;
    public RawImage background, platform;
    public float parallaxSpeed = 0.02f;
    public GameObject uiReady;

    void Update()
    {
        UpdateParallax();
        UpdateGameState();
    }

    void UpdateGameState()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            gameState = GameState.Playing;
            uiReady.SetActive(false);
        }
    }

    void UpdateParallax()
    {
        if (gameState == GameState.Playing)
        {
            float finalSpeed = parallaxSpeed * Time.deltaTime;
            background.uvRect = new Rect(background.uvRect.x + finalSpeed, 0f, 1f, 1f);
            platform.uvRect = new Rect(platform.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
        }
    }
}
