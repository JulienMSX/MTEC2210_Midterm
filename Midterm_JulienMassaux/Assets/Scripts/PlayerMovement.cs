using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 1000;
    public TextMeshPro playerScoreText;
    public SpriteRenderer sr;
    //public Sprite Sprite1;
    //public Sprite Sprite2;
    float xMove;
    float yMove;
    Rigidbody2D rb;
    
    public AudioClip holy;
    public AudioClip medusa;
    public AudioClip orb;
    AudioSource audioSource;
    public Animator animate;
   


    public int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        //animate = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        playerScoreText.text = playerScore.ToString();
        xMove = Input.GetAxisRaw("Horizontal");
        //yMove = Input.GetAxisRaw("Vertical");


        //transform.Translate(Time.deltaTime*movementSpeed*xMove,0,0);

    }
    public void IncrementScore(int scoreChange)
    {

        playerScore += scoreChange;
    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Time.deltaTime * movementSpeed * xMove, 0);
        animate.SetFloat("pspeed", Mathf.Abs(xMove));
       
        if(xMove > 0) { 
        
           
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

       

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Coin")
        {
            var coin = collision.gameObject.GetComponent<coinscript>();
            if (coin.coinValue == 0)
            {
                IncrementScore(1);
                
                print("Player collected: " + gameObject.name);
                Destroy(collision.gameObject);
                audioSource.PlayOneShot(holy,1f);
            }
            if (coin.coinValue == 1)
            {
                print("Game Over");
                audioSource.PlayOneShot(medusa, 1f);
                //animate.SetBool("death", true);


                Destroy(gameObject);
                Destroy(collision.gameObject);
                //go to main menu
                
                



            }
            if (coin.coinValue == 2)
            {
                print("change scene");
                audioSource.PlayOneShot(orb, 1f);
                Destroy(collision.gameObject);
                

            }






        }
    }
}
