using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaX : MonoBehaviour
{
     private bool moveDown = true;
     public float speed = 3f;
     public Transform pontoA;
     public Transform pontoB;

    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > pontoA.position.y){
            moveDown=true;
        }else if(transform.position.y < pontoB.position.y){
            moveDown = false;
        }
    
        if(moveDown){
            transform.position = new Vector2(transform.position.x, transform.position.y-speed*Time.deltaTime);
        } else {
            transform.position = new Vector2(transform.position.x, transform.position.y+speed*Time.deltaTime);

        }
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

    