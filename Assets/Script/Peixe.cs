using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peixe : MonoBehaviour
{
    public bool colider = false;
    private float move = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move, GetComponent<Rigidbody2D>().velocity.y);
        if (colider){
            Flip();
        }
    }
    private void Flip(){
        move *= -1;
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        colider = false;
    }
 
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if(colisor.gameObject.layer==8){
            colider = true;
        }
    }

    void OnCollisionExit2D(Collision2D colisor)
    {
        if(colisor.gameObject.layer==8){
            colider = false;
        }
    }
}
