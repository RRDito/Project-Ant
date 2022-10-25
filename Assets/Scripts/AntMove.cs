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
        transform.Rotate (Vector3.forward * Random.Range(-180.0f, 180.0f));		
    }

    public bool isNearEdge()
	{
		
		if ( (r.localPosition.x > 475.0f) || (r.localPosition.x < -475.0f) ) {return true;}
		else if ( (r.localPosition.y > 265.0f) || (r.localPosition.y < -265.0f) ) {return true;}
		else {return false;}
	}

    // Update is called once per frame
    void Update()
    {		
		if (isNearEdge() == true)
		{			
			transform.Rotate (Vector3.forward * Random.Range(0.0f, 15.0f) * 80f * Time.deltaTime);
		}		
		else   //Random facing in a 30 degree
		{ 
			transform.Rotate (Vector3.forward * Random.Range(-15.0f, 15.0f) * 80f * Time.deltaTime);
		}		
		//move forward
		this.transform.position += (transform.up*moveSpeed*Time.deltaTime);
		//adjusting
		
    }
}
