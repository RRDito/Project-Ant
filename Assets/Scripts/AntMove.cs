using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntMove : MonoBehaviour
{
	private float moveSpeed = 0.5f;
	private RectTransform r; 
		
	public GameObject Nest;
	
		
    // Start is called before the first frame update
    void Start()
    {   
	    r = this.GetComponent<RectTransform>();
		//transform.position = new Vector3(transform.position.x, transform.position.y, 10);	
        transform.Rotate (Vector3.forward * Random.Range(-180.0f, 180.0f));		
    }

    bool isNearEdge()
	{
		
		if ( (r.localPosition.x > 475.0f) || (r.localPosition.x < -475.0f) ) {return true;}
		else if ( (r.localPosition.y > 265.0f) || (r.localPosition.y < -265.0f) ) {return true;}
		else {return false;}
	}
	
		
	void AntMovement()
	{
		bool MoveReady = false;
		//Locate Food Object
		GameObject FoodObject = GameObject.FindWithTag("Food");
		//Calculate the current distance between the ant and the food
		float CurrentDistance = Vector3.Distance(this.transform.position, FoodObject.transform.position);
		
		Debug.Log(CurrentDistance);
		while (MoveReady == false)
		{
			if (isNearEdge() == true) //facing in a fixed direction if its near edge
			{			
				transform.Rotate (Vector3.forward * Random.Range(0.0f, 15.0f) * 80f * Time.deltaTime);
			}		
			else   //Random facing in a 30 degree
			{ 
				transform.Rotate (Vector3.forward * Random.Range(-15.0f, 15.0f) * 80f * Time.deltaTime);
			}		
			//move forward evaluation
			Vector3 EvalPoint = this.transform.position + (transform.up*moveSpeed*Time.deltaTime);
			//check if its closer
			float NewDistance = Vector3.Distance(this.transform.position, EvalPoint);
			
			//Move if NewDistance is closer
			if (NewDistance < CurrentDistance){MoveReady = true;}	
		}

		this.transform.position += (transform.up*moveSpeed*Time.deltaTime);	
	}
	
	
    // Update is called once per frame
    void Update()
    {		
		AntMovement();		
    }
}
