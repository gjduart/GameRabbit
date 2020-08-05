using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public static GameController instancia;
    public int TotalVidas;
    public Text vidas;    
    public GameObject heart1,heart2,heart3;
    public GameObject gameover;
     public LevelLoader levelLoader;


    [Header("Pause")]
    private bool ispaused;
    public GameObject pausePanel;
    public string cena;
    void Start()
    {
        TotalVidas = 3;
        instancia = this;
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            PauseScreen();
        }
    }
    void PauseScreen(){
        if(ispaused){
            pausePanel.SetActive(false);
            ispaused = false;
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }else{
            pausePanel.SetActive(true);
            ispaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void ShowGameOver(){
        gameover.SetActive(true);
    }
    public void setTotalVidas(int vidas){
        TotalVidas = vidas;
    }
    public int getTotalVidas(){
        return TotalVidas;
    }
  /**  public void setLife(int health){
        switch (health)
        {
            case 3: 
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);    
                heart2.gameObject.SetActive(false);    
                heart3.gameObject.SetActive(false);
                break;    
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
        }
    }**/
    public void backToMenu(){
        ispaused = false;
        Time.timeScale = 1f;
        levelLoader.Transition(cena);
    }
}
