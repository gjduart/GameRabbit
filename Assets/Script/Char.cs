using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public bool isJumping;
    public bool doubleJumping;
    private Rigidbody2D jp;
    private Animator animacao;
   

    // Start is called before the first frame update
    void Start()
    {
        jp =GetComponent<Rigidbody2D>();
        animacao = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
        
        float inputAxis = Input.GetAxis("Horizontal");
   
       if(inputAxis < 0){
           transform.eulerAngles = new Vector2(0f, 0f);
            animacao.SetBool("walk", true);
       }
        if(inputAxis > 0){
           transform.eulerAngles = new Vector2(0f, 180f);
            animacao.SetBool("walk", true);
       }
        if(inputAxis == 0){
      
            animacao.SetBool("walk", false);
       }
    
    }
    void Jump()
    {
       if(Input.GetButtonDown("Jump")){
           if(!isJumping){
                jp.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                animacao.SetBool("jump", true);
                doubleJumping = true;
           }else {
               if(doubleJumping){
                    jp.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                    animacao.SetBool("jump", true);
                    doubleJumping = false;
               }
               
           }
       }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag.Equals("Plataform")){
            this.transform.parent = collision.transform;
        }
        if(collision.gameObject.layer==8){
            isJumping = false;
            animacao.SetBool("jump", false);
        }
    }
     void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.tag.Equals("Plataform")){
            this.transform.parent = null;
        }
        if(collision.gameObject.layer==8){
            isJumping = true;
            animacao.SetBool("jump", true);
        }
        
    }
}

