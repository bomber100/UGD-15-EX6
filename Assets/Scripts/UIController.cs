using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
    public GameObject gameOverPanel;

    void Start() {
        gameOverPanel.SetActive(false);
       // SceneManager.LoadScene("start", LoadSceneMode.Single);
    }
    void Update() {
        if (PlayerController.health <= 0) {            
            gameOverPanel.SetActive(true);
        }
    }
    public void Button() {
        gameOverPanel = GameObject.Find("GameOver");
        print("button here " + gameOverPanel.name);
        gameOverPanel.SetActive(false);
        PlayerController.health = 100;
        SceneManager.LoadScene("Labyrinth", LoadSceneMode.Single);
    }
    public void begin() {
        
        SceneManager.LoadScene("start", LoadSceneMode.Single);
    }
    public void TutorialButton() {
        gameOverPanel = GameObject.Find("GameOver");
        gameOverPanel.SetActive(false);
        PlayerController.health = 100;
        SceneManager.LoadScene("tutorial", LoadSceneMode.Single);
    }
}