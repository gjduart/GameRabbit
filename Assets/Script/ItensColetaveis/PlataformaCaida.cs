using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaCaida : MonoBehaviour
{
 
    public Rigidbody2D rb;


    void OnCollisionEnter2D(Collision2D colisao) {
        if (colisao.gameObject.name.Equals("Char")){
       
                rb.bodyType = RigidbodyType2D.Dynamic;
                rb.mass = 50f;
                rb.gravityScale = 0.5f;
            
        }
    }
}
