using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take: MonoBehaviour
{
    private bool istake =  false;
    private bool isArea = false; 
    private GameObject dropArea;
    private Vector2 startPosition;
   

    // Update is called once per frame
    void Update()
    {
        if(istake){
            transform.position = new Vector2(Input.mousePosition.x,Input.mousePosition.y);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision){
	isArea = true;
	dropArea = collision.gameObject;

    }
   
    private void OnCollisionExit2D(Collision2D collision){
	isArea = false;
	dropArea = null;

    }

    public void StartTake(){
        
        startPosition = transform.position;
        istake = true;


    }

    public void  EndTake(){

        istake = false;
	if(isArea){
	   transform.SetParent(dropArea.transform,false);
	}
	else
	{
	   transform.position = startPosition;
	}
    }
}
