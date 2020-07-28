using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class PlataformaY : MonoBehaviour
{
     private bool moveRight = true;
     public float speed = 3f;
     public Transform pontoA;
     public Transform pontoB;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < pontoA.position.x){
            moveRight=true;
        }
        if(transform.position.x > pontoB.position.x){
            moveRight = false;
        }
    
        if(moveRight){
            transform.position = new Vector2(transform.position.x+speed*Time.deltaTime, transform.position.y);
        } else {
            transform.position = new Vector2(transform.position.x-speed*Time.deltaTime, transform.position.y);

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

    public override string ToString() => base.ToString();

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
