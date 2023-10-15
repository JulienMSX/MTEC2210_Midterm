using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
  public GameObject coinPrefab;
  private float heightValue = 7;
  private TextMeshPro ps;
  private int PScore;
  public PlayerMovement Player;
    public coinscript coins;

    //private float widthValue = 3;
  public Color [] coinColors;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnCoin", 4 ,1);
        ps = GetComponent<TextMeshPro>();



    }


    // Update is called once per frame
    void Update()
    {
      


       PScore = Player.playerScore;
        //print(PScore);
       ps.text = PScore.ToString();
        




    }
    public void SpawnCoin(){
      //float randomxValue = Random.Range(-widthValue,widthValue);
      float randomyValue = Random.Range(-heightValue,heightValue);
      Vector3 pos = new Vector3(randomyValue,5,0);
    

      GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity);
      coinscript coinScript = coin.GetComponent<coinscript>();
      
      int rndValue = Random.Range(0,3);
      coinScript.ChangeCoinValue(rndValue);
      coinScript.ChangeCoinSprite(rndValue);




      

    }
    public void Clean()
    {
        
    }


}
