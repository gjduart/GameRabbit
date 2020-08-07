using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoInimigos : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;
    

    public GameObject collected;
    public int Score;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    
    void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.tag =="Player"){
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);
            
           


            Destroy(gameObject, 1f);
        }
    }
}