using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class coinscript : MonoBehaviour
{
    public int coinValue;
    //public TextMeshPro valueText;
    public SpriteRenderer sr;
    float fall = -5;
    float randomFallValue;
   
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;

    // Start is called before the first frame update
    void Start()
    {

        //sr = GetComponent<SpriteRenderer>();
        //ChangeCoinColor(Random.ColorHSV());
        //ChangeCoinValue(Random.Range(1,9));
        randomFallValue = Random.Range(fall / 2, fall * 2);
        





    }
    void Update()
    {
        //coinbody.velocity = new Vector2(0, fall);
        


        transform.Translate(0, Time.deltaTime * randomFallValue, 0);
    }

    // Update is called once per frame
    public void ChangeCoinSprite(int c) {
        if (c == 0)
        {
            sr.sprite = newSprite1;
            
        }
        if (c == 1)
        {
           
            sr.sprite = newSprite2;
            

        }
        if (c == 2)
        {
            sr.sprite = newSprite3;
        }

    }
    public void ChangeCoinValue(int v) {
        coinValue = v;
        //valueText.text = coinValue.ToString();
    }
    /*public void OnTriggerEnter2D(Collider2D collision){
      if (collision.gameObject.tag == "Player"){
        collision.gameObject.GetComponent<PlayerMovement>().IncrementScore(coinValue);
        print("Player collected: " + gameObject.name);
        Destroy(gameObject);
           

      }*/



}
