using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public static GameController instancia;

    public GameObject gameover;
    void Start()
    {
        instancia = this;
    }
    public void ShowGameOver(){
        gameover.SetActive(true);
    }

}
