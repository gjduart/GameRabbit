using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadilha : MonoBehaviour
{
     private Rigidbody2D rb;
    private SpriteRenderer sr;
    private CircleCollider2D circle;
    private BoxCollider2D box;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
        box = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.CompareTag("Player")){
            rb.bodyType = RigidbodyType2D.Dynamic;
        }    
    }
}
