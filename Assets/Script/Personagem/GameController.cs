using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public static GameController instancia;
    public int TotalVidas;
    public Text vidas;    
    public GameObject heart1,heart2,heart3;
    public GameObject gameover;
    void Start()
    {
        TotalVidas = 3;
     /**   heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);**/
        instancia = this;
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

}
