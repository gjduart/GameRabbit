using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Historia : MonoBehaviour
{
    public LevelLoader levelLoader;

    public GameObject painel1;
    public GameObject painel2;
    public GameObject painel3;
    public GameObject painel4;
    public GameObject painel5;
    public GameObject painel6;
    public string cena;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void nextpane1(){
        painel2.SetActive(false);
        painel3.SetActive(false);
        painel4.SetActive(false);
        painel5.SetActive(false);
        painel6.SetActive(false);
    }

    public void nextpane2(){
        painel1.SetActive(false);
        painel2.SetActive(true);
        painel3.SetActive(false);
        painel4.SetActive(false);
        painel5.SetActive(false);
        painel6.SetActive(false);
    }

    public void nextpane3(){
        painel1.SetActive(false);
        painel2.SetActive(false);
        painel3.SetActive(true);
        painel4.SetActive(false);
        painel5.SetActive(false);
        painel6.SetActive(false);
    }

    public void nextpane4(){
        painel1.SetActive(false);
        painel2.SetActive(false);
        painel3.SetActive(false);
        painel4.SetActive(true);
        painel5.SetActive(false);
        painel6.SetActive(false);
    }

    public void nextpane5(){
        painel1.SetActive(false);
        painel2.SetActive(false);
        painel3.SetActive(false);
        painel4.SetActive(false);
        painel5.SetActive(true);
        painel6.SetActive(false);
    }

    public void nextpane6(){
        painel1.SetActive(false);
        painel2.SetActive(false);
        painel3.SetActive(false);
        painel4.SetActive(false);
        painel5.SetActive(false);
        painel6.SetActive(true);
    }

    public void showGame(){
       levelLoader.Transition(cena);
    }
}
