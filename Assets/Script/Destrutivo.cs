using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destrutivo : MonoBehaviour
{
    public Rigidbody2D rg;
    public float time = 1f;
    void Start()
    {
        
    }

private void OnCollisionEnter2D(Collision2D colisor) {
    
    if (colisor.gameObject.tag.Equals("Player"))

         rg.bodyType = RigidbodyType2D.Dynamic;

     }
        
}


