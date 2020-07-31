using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public bool isJumping;
    public bool doubleJumping;
    public float walljumpForce;
    public Vector2 walljumpDirection;
    private Rigidbody2D jp;
    private Animator animacao;
    private bool isGrounded;
    public bool inWater;
    public Transform Wallcheck;
    public int life;
    public int qtdDano;
    public int qtdDonuts;
    public Text scoreText;
    public Text Vidas;
    

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
        if(!inWater){
            Jump();
        } else {
          if (Input.GetKey(KeyCode.UpArrow)){
            jp.AddForce(new Vector2(0, 6f * Time.deltaTime), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            jp.AddForce(new Vector2(0, -6f * Time.deltaTime), ForceMode2D.Impulse);
        }
        jp.AddForce(new Vector2(0, 10f * Time.deltaTime), ForceMode2D.Impulse);
        }

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
                    jp.AddForce(new Vector2(0f, JumpForce/1.005f), ForceMode2D.Impulse);
                    animacao.SetBool("jump", true);
                    doubleJumping = false;
               }
               
           }
       }
    }
    void nadar(){
   
    }
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag.Equals("Plataform")){
            this.transform.parent = collision.transform;
        }
        if(collision.gameObject.layer==8){
            isJumping = false;
            animacao.SetBool("jump", false);
            isGrounded = true;
        }
        if(collision.gameObject.tag.Equals("Dano")){
            Debug.Log("Tocou o espinho");
        }
        if(collision.gameObject.CompareTag("morte")){
            Destroy(gameObject);
            Vidas.text = 0.ToString();
            GameController.instancia.ShowGameOver();
        }
    }
     void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.tag.Equals("Plataform")){
            this.transform.parent = null;
        }
        if(collision.gameObject.layer==8){
            isJumping = true;
            isGrounded = false;
            animacao.SetBool("jump", true);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.CompareTag("life1")){
            qtdDano++;
            GameController.instancia.setTotalVidas(qtdDano);
            Vidas.text = GameController.instancia.getTotalVidas().ToString();
           
        }
        if (col.gameObject.CompareTag("Donut")){
            qtdDonuts++;
            scoreText.text = qtdDonuts.ToString();
            if(qtdDonuts>=100){
                qtdDano++;
                GameController.instancia.setTotalVidas(qtdDano);
                Vidas.text = GameController.instancia.getTotalVidas().ToString();
                qtdDonuts = 0;
                scoreText.text = qtdDonuts.ToString();
            }
        }
         if(col.gameObject.tag == "Dano"){
            qtdDano--;
            Vidas.text = GameController.instancia.getTotalVidas().ToString();
            GameController.instancia.setTotalVidas(qtdDano);
            qtdDonuts = 0;
             scoreText.text = qtdDonuts.ToString();
           // GameController.instancia.setLife(qtdDano);
            
            Debug.Log("vc tem " + qtdDano + "vidas");
            if(qtdDano <=0){
                    GameController.instancia.ShowGameOver();
                    Destroy(gameObject);
            }
        }
        if(col.gameObject.CompareTag("agua")){
            inWater = true;
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("agua")){
            inWater = false;
        }
    }


    private void OnDrawGizmos()
    {
     
 
    }
    
}

