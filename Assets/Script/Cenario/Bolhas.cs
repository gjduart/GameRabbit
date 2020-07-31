using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolhas : MonoBehaviour
{
    private float time = 0.0f;
    public float timer;
    public bool inwater = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
      //  GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        if (!inwater){
            
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("agua")){
            Destroy(gameObject);
        }
    }
}
