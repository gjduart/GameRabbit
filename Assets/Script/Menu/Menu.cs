using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string cena;
    public GameObject creditos;
    public LevelLoader levelLoader;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StarGame(){
        levelLoader.Transition(cena);
    }

    public void QuitGame(){
          //editor Unity 
          UnityEditor.EditorApplication.isPlaying = false;
          // Jogo Compilado
          //Application.Quit();
    }
    public void ShowCredits(){
        creditos.SetActive(true);
    }
    public void backToMenu(){
        creditos.SetActive(false);
    }
}
