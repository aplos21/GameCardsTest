using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Area;
    public GameObject Hand1;
    public GameObject Hand2;
    List<GameObject> cards = new List<GameObject>();

    void Start()
    {
        cards.Add(Card1);
        cards.Add(Card2);
        
    }

   public void OnClick()
    { 
	for (var i = 0; i < 5 ; i++){
       	   GameObject playerCard1 = Instantiate(cards[Random.Range(0,cards.Count)], new Vector3(i*50,i,0), Quaternion.identity);
	   playerCard1.transform.SetParent(Hand1.transform,false);

	   GameObject playerCard2 = Instantiate(cards[Random.Range(0,cards.Count)], new Vector3(i*50,i,0), Quaternion.identity);
	   playerCard2.transform.SetParent(Hand2.transform,false);
	}	

    }

   
}
